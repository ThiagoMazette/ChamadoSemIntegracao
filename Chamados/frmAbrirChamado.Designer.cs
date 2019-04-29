namespace Chamados
{
    partial class frmAbrirChamado
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.cbbSelecao = new System.Windows.Forms.ComboBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtEmpresaAbrirChamado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.txtAbrirChamadoID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(457, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(85, 23);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // cbbSelecao
            // 
            this.cbbSelecao.FormattingEnabled = true;
            this.cbbSelecao.Items.AddRange(new object[] {
            "CNPJ",
            "Nome"});
            this.cbbSelecao.Location = new System.Drawing.Point(12, 26);
            this.cbbSelecao.Name = "cbbSelecao";
            this.cbbSelecao.Size = new System.Drawing.Size(69, 21);
            this.cbbSelecao.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnpj,
            this.nome,
            this.telefone});
            this.dgvResultado.Location = new System.Drawing.Point(12, 63);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.Size = new System.Drawing.Size(611, 270);
            this.dgvResultado.TabIndex = 6;
            this.dgvResultado.TabStop = false;
            this.dgvResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellClick);
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentClick);
            this.dgvResultado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cnpj
            // 
            this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 59;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 60;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(548, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(548, 357);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtEmpresaAbrirChamado
            // 
            this.txtEmpresaAbrirChamado.Location = new System.Drawing.Point(69, 360);
            this.txtEmpresaAbrirChamado.Name = "txtEmpresaAbrirChamado";
            this.txtEmpresaAbrirChamado.ReadOnly = true;
            this.txtEmpresaAbrirChamado.Size = new System.Drawing.Size(374, 20);
            this.txtEmpresaAbrirChamado.TabIndex = 4;
            this.txtEmpresaAbrirChamado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empresa:";
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(457, 357);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(85, 23);
            this.btnAbrirChamado.TabIndex = 5;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(87, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(297, 20);
            this.txtProcurar.TabIndex = 2;
            this.txtProcurar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcurar_KeyPress);
            this.txtProcurar.Leave += new System.EventHandler(this.txtProcurar_Leave);
            // 
            // txtAbrirChamadoID
            // 
            this.txtAbrirChamadoID.Location = new System.Drawing.Point(12, 334);
            this.txtAbrirChamadoID.Name = "txtAbrirChamadoID";
            this.txtAbrirChamadoID.Size = new System.Drawing.Size(51, 20);
            this.txtAbrirChamadoID.TabIndex = 12;
            this.txtAbrirChamadoID.TabStop = false;
            this.txtAbrirChamadoID.Visible = false;
            // 
            // frmAbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 414);
            this.Controls.Add(this.txtAbrirChamadoID);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnAbrirChamado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpresaAbrirChamado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.cbbSelecao);
            this.Controls.Add(this.btnProcurar);
            this.Name = "frmAbrirChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Chamado";
            this.Load += new System.EventHandler(this.frmAbrirChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ComboBox cbbSelecao;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtEmpresaAbrirChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.TextBox txtAbrirChamadoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}