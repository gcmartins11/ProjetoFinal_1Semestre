using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Senai.ProjetoFinal.Repositorio;
using Senai.ProjetoFinal.Controllers;

namespace Senai.ProjetoFinal.Controllers
{
    public class PageController : Controller
    {
        [HttpGet]
        public IActionResult AcessoNegado(){
            return View();
        }

        [HttpGet]
        public IActionResult PainelUsuario(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["Usuarios"] = usuarioRepositorio.Listar();

            if (UsuarioController.usuarioLogado == null ||UsuarioController.usuarioLogado.Adm == false) {
                return RedirectToAction("AcessoNegado","Page");
            }

            return View();
        }

        [HttpGet]
        public IActionResult PainelComentario(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ViewData["Comentarios"] = comentarioRepositorio.Listar();

            if (UsuarioController.usuarioLogado == null ||UsuarioController.usuarioLogado.Adm == false) {
                return RedirectToAction("AcessoNegado","Page");
            }

            return View();
        }
    }
}