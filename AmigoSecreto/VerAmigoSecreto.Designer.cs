namespace AmigoSecreto
{
    partial class VerAmigoSecreto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView_VerAmigoSecreto = new ListView();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            columnHeader_AmigoSecreto = new ColumnHeader();
            SuspendLayout();
            // 
            // listView_VerAmigoSecreto
            // 
            listView_VerAmigoSecreto.Columns.AddRange(new ColumnHeader[] { Nome, Email, columnHeader_AmigoSecreto });
            listView_VerAmigoSecreto.Location = new Point(184, 12);
            listView_VerAmigoSecreto.Name = "listView_VerAmigoSecreto";
            listView_VerAmigoSecreto.Size = new Size(414, 426);
            listView_VerAmigoSecreto.TabIndex = 0;
            listView_VerAmigoSecreto.UseCompatibleStateImageBehavior = false;
            listView_VerAmigoSecreto.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 100;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 140;
            // 
            // columnHeader_AmigoSecreto
            // 
            columnHeader_AmigoSecreto.Text = "Amigo Secreto";
            columnHeader_AmigoSecreto.Width = 100;
            // 
            // VerAmigoSecreto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_VerAmigoSecreto);
            Name = "VerAmigoSecreto";
            Text = "VerAmigoSecreto";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_VerAmigoSecreto;
        private ColumnHeader Nome;
        private ColumnHeader Email;
        private ColumnHeader columnHeader_AmigoSecreto;
    }
}