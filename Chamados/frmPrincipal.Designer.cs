namespace Chamados
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.btnAtenderChamado = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(133, 131);
            this.btnAbrirChamado.TabIndex = 1;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtenderChamado
            // 
            this.btnAtenderChamado.Location = new System.Drawing.Point(192, 12);
            this.btnAtenderChamado.Name = "btnAtenderChamado";
            this.btnAtenderChamado.Size = new System.Drawing.Size(139, 131);
            this.btnAtenderChamado.TabIndex = 2;
            this.btnAtenderChamado.Text = "Atender Chamado";
            this.btnAtenderChamado.UseVisualStyleBackColor = true;
            this.btnAtenderChamado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 208);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 132);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(192, 208);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(139, 132);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAtenderChamado);
            this.Controls.Add(this.btnAbrirChamado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.Button btnAtenderChamado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
    }
}

