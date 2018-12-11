using System;

namespace Senai.ProjetoFinal.Models
{
    [Serializable]
    public class ComentarioModel
    {
        public int Id { get; set; }
        public int IdLogado { get; set; }
        public string NomeLogado { get; set; }
        public string Texto { get; set; }
        public bool Aprovado { get; set; }
        public DateTime DataPublicacao { get; set; }

        public ComentarioModel(int id, int idUsuario, string texto, DateTime DataPublicacao) {
            this.Id = id;
            this.Texto = texto;
            this.DataPublicacao = DataPublicacao;    
        }

        public ComentarioModel(int idLogado, string nomeLogado, string texto) {
            this.IdLogado = idLogado;
            this.NomeLogado = nomeLogado;
            this.Texto = texto;
        }

    }
}