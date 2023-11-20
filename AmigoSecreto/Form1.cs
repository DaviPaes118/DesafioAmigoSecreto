using AmigoSecreto;
using System.Collections.Generic;

namespace AmigoSecreto
{
    public partial class Form1 : Form
    {
        private AmigoManager amigoManager = new AmigoManager();
        
        public Form1()
        {
            InitializeComponent();
            Persistência.popularArquivoLista("Amigos.csv", amigoManager.listaAmigos);
            AtualizarListaAmigos();
        }

        private void button_Cadastro_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void button_ListarAmigos_Click(object sender, EventArgs e)
        {
            AtualizarListaAmigos();
        }

        private void button_GerarAmigoSecreto_Click(object sender, EventArgs e)
        {
            if (amigoManager.GerarAmigoSecreto())
            {
                MessageBox.Show("Amigo secreto gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao gerar amigo secreto. Certifique-se de ter pelo menos dois amigos cadastrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListaAmigos()
        {
            listBox_AmigoSecreto.Items.Clear();
            foreach (Amigo amigo in amigoManager.ListarAmigos())
            {
                listBox_AmigoSecreto.Items.Add($"{amigo.Nome} - {amigo.Email}");
            }
        }

        private void LimparCampos()
        {
            textBox_Nome.Clear();
            textBox_Email.Clear();
            textBox_Nome.Focus();
        }

        private void button_Resultado_Click(object sender, EventArgs e)
        {
            VerAmigoSecreto verAmigo = new VerAmigoSecreto();

            verAmigo.ShowDialog();
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            amigoManager.LimparListaAmigos();
            LimparListBoxAmigos();
            LimparArquivoSecreto();
            File.WriteAllText("Amigos.csv", string.Empty);

            MessageBox.Show("Dados limpos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparListBoxAmigos()
        {
            listBox_AmigoSecreto.Items.Clear();
        }

        private void LimparArquivoSecreto()
        {
            File.WriteAllText("secreto.csv", string.Empty);
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBox_Email.Focus();
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cadastrar();
            }
        }

        private void cadastrar()
        {
            string nome = textBox_Nome.Text;
            string email = textBox_Email.Text;

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amigoManager.CadastrarAmigo(nome, email))
            {
                MessageBox.Show("Amigo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListaAmigos();

                // Perguntar se deseja cadastrar outro amigo
                DialogResult resultado = MessageBox.Show("Deseja cadastrar outro amigo?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes || resultado == DialogResult.No)
                {
                    LimparCampos();
                }
            }
        }
    }
}