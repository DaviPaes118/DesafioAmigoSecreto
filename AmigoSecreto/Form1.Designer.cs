namespace AmigoSecreto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Nome = new TextBox();
            label2 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            button_Cadastro = new Button();
            button_GerarAmigoSecreto = new Button();
            listBox_AmigoSecreto = new ListBox();
            button_Limpar = new Button();
            button_Resultado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(64, 89);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(255, 23);
            textBox_Nome.TabIndex = 1;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(64, 125);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(255, 23);
            textBox_Email.TabIndex = 3;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 14);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(359, 37);
            label3.TabIndex = 4;
            label3.Text = "CADASTRO AMIGO SECRETO";
            // 
            // button_Cadastro
            // 
            button_Cadastro.Location = new Point(64, 178);
            button_Cadastro.Name = "button_Cadastro";
            button_Cadastro.Size = new Size(80, 32);
            button_Cadastro.TabIndex = 5;
            button_Cadastro.Text = "Cadastrar";
            button_Cadastro.UseVisualStyleBackColor = true;
            button_Cadastro.Click += button_Cadastro_Click;
            // 
            // button_GerarAmigoSecreto
            // 
            button_GerarAmigoSecreto.Location = new Point(150, 178);
            button_GerarAmigoSecreto.Name = "button_GerarAmigoSecreto";
            button_GerarAmigoSecreto.Size = new Size(75, 32);
            button_GerarAmigoSecreto.TabIndex = 7;
            button_GerarAmigoSecreto.Text = "Gerar";
            button_GerarAmigoSecreto.UseVisualStyleBackColor = true;
            button_GerarAmigoSecreto.Click += button_GerarAmigoSecreto_Click;
            // 
            // listBox_AmigoSecreto
            // 
            listBox_AmigoSecreto.Enabled = false;
            listBox_AmigoSecreto.FormattingEnabled = true;
            listBox_AmigoSecreto.ItemHeight = 15;
            listBox_AmigoSecreto.Location = new Point(452, 89);
            listBox_AmigoSecreto.MultiColumn = true;
            listBox_AmigoSecreto.Name = "listBox_AmigoSecreto";
            listBox_AmigoSecreto.Size = new Size(336, 349);
            listBox_AmigoSecreto.TabIndex = 8;
            // 
            // button_Limpar
            // 
            button_Limpar.Location = new Point(231, 178);
            button_Limpar.Name = "button_Limpar";
            button_Limpar.Size = new Size(88, 32);
            button_Limpar.TabIndex = 9;
            button_Limpar.Text = "Limpar";
            button_Limpar.UseVisualStyleBackColor = true;
            button_Limpar.Click += button_Limpar_Click;
            // 
            // button_Resultado
            // 
            button_Resultado.Location = new Point(12, 406);
            button_Resultado.Name = "button_Resultado";
            button_Resultado.Size = new Size(73, 32);
            button_Resultado.TabIndex = 10;
            button_Resultado.Text = "Resultado";
            button_Resultado.UseVisualStyleBackColor = true;
            button_Resultado.Click += button_Resultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Resultado);
            Controls.Add(button_Limpar);
            Controls.Add(listBox_AmigoSecreto);
            Controls.Add(button_GerarAmigoSecreto);
            Controls.Add(button_Cadastro);
            Controls.Add(label3);
            Controls.Add(textBox_Email);
            Controls.Add(label2);
            Controls.Add(textBox_Nome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Nome;
        private Label label2;
        private TextBox textBox_Email;
        private Label label3;
        private Button button_Cadastro;
        private Button button_GerarAmigoSecreto;
        private ListBox listBox_AmigoSecreto;
        private Button button_Limpar;
        private Button button_Resultado;
    }
}