namespace Cadastro_de_Clientes
{
    partial class cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.InfosTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(71, 64);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(192, 27);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Digite seu nome:\r\n";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu sobrenome:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite seu email:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite sua idade:\r\n";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNome.Location = new System.Drawing.Point(328, 63);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(318, 31);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdade.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxIdade.Location = new System.Drawing.Point(328, 190);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(318, 31);
            this.textBoxIdade.TabIndex = 5;
            this.textBoxIdade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxEmail.Location = new System.Drawing.Point(328, 144);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(318, 31);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSobrenome.Location = new System.Drawing.Point(328, 104);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(318, 31);
            this.textBoxSobrenome.TabIndex = 7;
            // 
            // enviar
            // 
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.Location = new System.Drawing.Point(519, 239);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(127, 31);
            this.enviar.TabIndex = 8;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // fechar
            // 
            this.fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Location = new System.Drawing.Point(699, 399);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(89, 39);
            this.fechar.TabIndex = 9;
            this.fechar.Text = "fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfosTxt
            // 
            this.InfosTxt.AutoSize = true;
            this.InfosTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfosTxt.Location = new System.Drawing.Point(73, 271);
            this.InfosTxt.Name = "InfosTxt";
            this.InfosTxt.Size = new System.Drawing.Size(231, 25);
            this.InfosTxt.TabIndex = 10;
            this.InfosTxt.Text = "Suas informações aqui";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfosTxt);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "cadastro";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label InfosTxt;
    }
}

