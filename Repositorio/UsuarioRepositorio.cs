using Senai.ProjetoFinal.Models;
using Senai.ProjetoFinal.Controllers;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Senai.ProjetoFinal.Repositorio
{
    public class UsuarioRepositorio
    {
        // Lista que armazena os usuários do sistema
        public List<UsuarioModel> UsuariosSalvos { get;  set; } 

        public UsuarioRepositorio() {
            if (File.Exists("usuarios.dat")) {
                UsuariosSalvos = LerArquivoSerializado();
            } 
            else {
                UsuariosSalvos = new List<UsuarioModel>();

                UsuarioModel usuario = new UsuarioModel(
                    id: 1,
                    nome: "Administrador",
                    email: "admin@carfel.com",
                    senha: "admin", adm: true
                    );
                UsuariosSalvos.Add(usuario);
                EscreverNoArquivo();
            }
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario) {

            foreach (var item in UsuariosSalvos) {
                usuario.Id = item.Id + 1;
            }

            // usuario.Id = UsuariosSalvos.Count + 1;

            UsuariosSalvos.Add(usuario);

            EscreverNoArquivo();

            return usuario;
        }

        public List<UsuarioModel> Listar() {

            return UsuariosSalvos;

        }

        public UsuarioModel Login(string email, string senha){

            foreach (var item in UsuariosSalvos) {
                if(email == item.Email && senha == item.Senha){
                    return item;
                }
            }
            return null;
        }

        public bool VerificarAdm(UsuarioModel usuario){
            if (usuario.Adm == true){
                return true;
            }
            return false;
        }

        public void Excluir(int id){
            UsuarioModel usuarioBuscado = BuscarPorId(id);

            if (usuarioBuscado != null){
                UsuariosSalvos.Remove(usuarioBuscado);

                EscreverNoArquivo();
            }

        }
        public UsuarioModel BuscarPorId(int id){
            foreach (var usuario in UsuariosSalvos) {
                if (id == usuario.Id) {
                    return usuario;
                }
            }
                return null;
        }

        public List<UsuarioModel> LerArquivoSerializado(){
            byte[] bytesSerializados = File.ReadAllBytes("usuarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<UsuarioModel>) serializador.Deserialize(memoria);
        }
        private void EscreverNoArquivo() {
            // MemoryStream guarda os bytes da serialiazção
            MemoryStream memoria = new MemoryStream();

            // BynaryFormatter fará a serialização
            BinaryFormatter serialiazador = new BinaryFormatter();

            serialiazador.Serialize(memoria, UsuariosSalvos);

            // Pegando os bytes na memória
            byte[] bytes = memoria.ToArray();

            // Escreve os bytes no arquivo
            File.WriteAllBytes("usuarios.dat", bytes);
        }


    }
}