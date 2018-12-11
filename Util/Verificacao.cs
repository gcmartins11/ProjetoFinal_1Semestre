using Senai.ProjetoFinal.Repositorio;
using Senai.ProjetoFinal.Models;
using System.Collections.Generic;

namespace Senai.ProjetoFinal.Util
{
    public class Verificacao
    {
        public static bool VerificarSenha(string senha){
            if (senha.Length >= 8) {
                return true;
            }
            return false;
        }

        public static bool ConfirmarSenha(string senha, string confirmarSenha){
            if (senha != confirmarSenha) {
                return false;
            }
            return true;
        }

        public static bool VerificacarEmail(string email){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            foreach (var item in usuarioRepositorio.UsuariosSalvos) {
                if (email == item.Email) {
                    return false;
                }
            }
            return true;
        }

    }
}