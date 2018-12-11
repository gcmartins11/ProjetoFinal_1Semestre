using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Senai.ProjetoFinal.Models;
using Senai.ProjetoFinal.Repositorio;
using Senai.ProjetoFinal.Util;

namespace Senai.ProjetoFinal.Controllers
{
    public class UsuarioController : Controller
    {
        public static UsuarioModel usuarioLogado;

        [HttpGet]
        public IActionResult Comentarios(){
            return View();
        }
        [HttpGet]
        public IActionResult LoginCadastrar(){
            return View();
        }

        [HttpGet]
        public IActionResult Deslogar(){
            usuarioLogado = null;
            return RedirectToAction("LoginCadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            string confirmarSenha = form["confirmarSenha"];
            UsuarioModel usuario = new UsuarioModel(
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"]
            );

            if (form["nome"] == "" || form["email"] == "" || form["senha"] == "" || form["confirmarSenha"] == ""){
                TempData["Mensagem"] = "Por favor, preencha todos os campos";
            }
            if (!Verificacao.VerificarSenha(usuario.Senha)){   
            
            TempData["Mensagem"] = "A senha deve possuir pelo menos 8 caracteres";
            return RedirectToAction("LoginCadastrar");

            }
            if(!Verificacao.VerificacarEmail(usuario.Email)){
                TempData["Mensagem"] = "Esse email já foi cadastrado";
            return RedirectToAction("LoginCadastrar");

            }
            if(!Verificacao.ConfirmarSenha(usuario.Senha, confirmarSenha)){
                TempData["Mensagem"] = "As senhas não correspondem";
            return RedirectToAction("LoginCadastrar");
            }

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

            TempData["Cadastrado"] = "Usuário Cadastrado";

            return RedirectToAction("LoginCadastrar");

        }

        [HttpGet]
        public IActionResult Listar(){
            if (usuarioLogado == null || usuarioLogado.Adm == false) {
                return RedirectToAction("AcessoNegado","Page");
            }

            return RedirectToAction("PainelUsuario","Page");
        }
        
        [HttpPost]
        public IActionResult Login(IFormCollection form){
            string email, senha;

            email = form["email"];
            senha = form["senha"];


            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            UsuarioModel usuario = usuarioRepositorio.Login(email, senha);
            
            if ( usuario != null){
                usuarioLogado = usuario;

                if(usuarioRepositorio.VerificarAdm( usuario )){
                
                return RedirectToAction("PainelUsuario","Page");
                    
                }

                return RedirectToAction("Comentarios", "Comentario");
            }
            
            return RedirectToAction("LoginCadastrar");
        }

        [HttpGet]
        public IActionResult Excluir(int id){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Usuário Excluido";

            return RedirectToAction("Listar");
        }

    }
}