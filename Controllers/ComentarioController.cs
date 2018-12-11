using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Senai.ProjetoFinal.Models;
using Senai.ProjetoFinal.Repositorio;
using Senai.ProjetoFinal.Controllers;

namespace Senai.ProjetoFinal.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form){
            ComentarioModel comentario = new ComentarioModel(
                idLogado: UsuarioController.usuarioLogado.Id,
                nomeLogado: UsuarioController.usuarioLogado.Nome,
                texto: form["texto"]
                );

                ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                comentarioRepositorio.Cadastrar(comentario);

            TempData["Mensagem"] = "Depoimento cadastrado com sucesso";

            return RedirectToAction("Comentarios", "Comentario");
        }

        [HttpGet]
        public IActionResult Listar(){
            if (UsuarioController.usuarioLogado == null || UsuarioController.usuarioLogado.Adm == false) {
                return RedirectToAction("AcessoNegado","Page");
            }
            
            return RedirectToAction("PainelComentario","Page");
        }

        [HttpGet]
        public IActionResult Comentarios(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ViewData["Comentarios"] = comentarioRepositorio.Listar();

            return View();
        }

        [HttpGet]
        public IActionResult Aprovar(int id){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Aprovar(id);

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Reprovar(int id){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Reprovar(id);

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Excluir(int id){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Excluir(id);

            return RedirectToAction("Listar");
        }

    }
}