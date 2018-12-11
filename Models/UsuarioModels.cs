using System;

namespace Senai.ProjetoFinal.Models
{
    [Serializable]
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Adm { get; set; }

         public UsuarioModel(string nome, string email, string senha) {
             this.Nome = nome;
             this.Email = email;
             this.Senha = senha;
             this.Adm = false;
        }

        public UsuarioModel(int id, string nome, string email, string senha, bool adm) {
            this.Id = id;
             this.Nome = nome;
             this.Email = email;
             this.Senha = senha;
             this.Adm = adm;
        }

    }
}

