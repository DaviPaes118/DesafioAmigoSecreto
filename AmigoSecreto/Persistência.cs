using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    internal class Persistência
    {
        public static void gerarArquivoAmigoSecreto(List<Amigo> lista, List<Amigo> listaTmp)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("secreto.csv");

                for (int i = 0; i < lista.Count; i++)
                {
                    escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                }

                escritor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void gerarArquivoAmigo(Amigo amigo, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(amigo.Nome + ";" + amigo.Email);

                escritor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void lerAmigoSecreto(ListView listView)
        {
            try
            {
                StreamReader leitor = new StreamReader("secreto.csv");

                while (!leitor.EndOfStream)
                {
                    string[] leitorAmigoSecreto = leitor.ReadLine().Split(";");
                    listView.Items.Add(new ListViewItem(leitorAmigoSecreto));
                }

                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void popularArquivoLista(string nomeArquivo, List<Amigo> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                Amigo tmp;
                do
                {
                    linha = leitor.ReadLine();
                    if (string.IsNullOrEmpty(linha)) 
                    { 
                        leitor.Close();
                        return; 
                    }

                    vetorLinha = linha.Split(";"); 
                    tmp = new Amigo(vetorLinha[0], vetorLinha[1]);
                    if (!lista.Contains(tmp))
                    {
                        lista.Add(tmp);
                    }

                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
