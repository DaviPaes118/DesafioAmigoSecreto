using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    public class AmigoManager
    {
        public List<Amigo> listaAmigos = new List<Amigo>();

        public bool CadastrarAmigo(string nome, string email)
        {
            if (!utilidades.EmailIsValid(email))
            {
                MessageBox.Show("Digite um email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!AmigoJaCadastrado(nome, email))
            {
                Amigo amigo = new Amigo(nome, email);
                listaAmigos.Add(amigo);
                Persistência.gerarArquivoAmigo(amigo, "Amigos.csv");
                return true;
            }

            MessageBox.Show("Amigo já cadastrado. Escolha outro nome ou email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public List<Amigo> ListarAmigos()
        {
            return listaAmigos;
        }

        public bool GerarAmigoSecreto()
        {
            if (listaAmigos.Count < 2)
            {
                MessageBox.Show("Amigos insuficientes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool verificaLista;
            List<Amigo> amigosEmbaralhados = new List<Amigo>();
            amigosEmbaralhados.AddRange(listaAmigos);

            do
            {
                verificaLista = true;
                amigosEmbaralhados = amigosEmbaralhados.OrderBy(x => Random.Shared.Next()).ToList();

                for (int i = 0; i < listaAmigos.Count; i++)
                {
                    if (listaAmigos[i] == amigosEmbaralhados[i])
                    {
                        // Evita que uma pessoa seja amiga secreta de si mesma
                        verificaLista = false;
                        amigosEmbaralhados.Clear();
                        amigosEmbaralhados.AddRange(listaAmigos);
                        break;
                    }
                }

            } while (!verificaLista);

            Persistência.gerarArquivoAmigoSecreto(listaAmigos, amigosEmbaralhados);
            return true;
        }

        private bool AmigoJaCadastrado(string nome, string email)
        {
            return listaAmigos.Any(amigo => amigo.Nome == nome || amigo.Email == email);
        }

        public void LimparListaAmigos()
        {
            listaAmigos.Clear();
        }
    }
}
