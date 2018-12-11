using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.ProjetoFinal.Models;


namespace Senai.ProjetoFinal.Repositorio
{
    public class ComentarioRepositorio
    {
        private List<ComentarioModel> ComentariosSalvos { get; set;}

        public ComentarioRepositorio(){
            if (File.Exists("comentarios.dat")){
                ComentariosSalvos = LerArquivoSerializado();
            }
            else {
                ComentariosSalvos = new List<ComentarioModel>();
            }

        }

        public ComentarioModel Cadastrar(ComentarioModel comentario){
            // comentario.Id = ComentariosSalvos.Count + 1;
            foreach (var item in ComentariosSalvos) {
                comentario.Id = item.Id + 1;
            }

            comentario.Aprovado = false;
            comentario.DataPublicacao = DateTime.Now;

            ComentariosSalvos.Add(comentario);

            EscreverNoArquivo(); 

            return comentario;
        }

        public List<ComentarioModel> Listar(){
            return ComentariosSalvos;
        }

        public void Aprovar(int id){
            foreach (var comentario in ComentariosSalvos) {
                if(id == comentario.Id){
                    comentario.Aprovado = true;
                    break;
                }
            }

            EscreverNoArquivo();

        }

        public void Reprovar(int id){
            foreach (var comentario in ComentariosSalvos) {
                if (id == comentario.Id){
                    comentario.Aprovado = false;
                    break;
                }
            }

            EscreverNoArquivo();

        }

        public void Excluir(int id){
            ComentarioModel comentarioBuscado = BuscarPorId(id);

            if (comentarioBuscado != null) {
                ComentariosSalvos.Remove(comentarioBuscado);

                EscreverNoArquivo();
            }
        }

        public ComentarioModel BuscarPorId(int id){
            foreach (var comentario in ComentariosSalvos) {
                if (id == comentario.Id){
                    return comentario;
                }
            }

            return null;
        }

        public List<ComentarioModel> LerArquivoSerializado(){
            byte[] bytesSerializados = File.ReadAllBytes("comentarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<ComentarioModel>) serializador.Deserialize(memoria);
        }
        private void EscreverNoArquivo() {
            // MemoryStream guarda os bytes da serialiazção
            MemoryStream memoria = new MemoryStream();

            // BynaryFormatter fará a serialização
            BinaryFormatter serialiazador = new BinaryFormatter();

            serialiazador.Serialize(memoria, ComentariosSalvos);

            // Pegando os bytes na memória
            byte[] bytes = memoria.ToArray();

            // Escreve os bytes no arquivo
            File.WriteAllBytes("comentarios.dat", bytes);
        }

    }
}