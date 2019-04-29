namespace Chamados
{
    partial class frmListagem
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
            this.cbbTecnico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcurarEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurarEmpresa = new System.Windows.Forms.Button();
            this.dgvProcurarEmpresa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresaSelecionada = new System.Windows.Forms.TextBox();
            this.btnListarResultado = new System.Windows.Forms.Button();
            this.dgvListarResultado = new System.Windows.Forms.DataGridView();
            this.aberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtEmpresaID = new System.Windows.Forms.TextBox();
            this.btnLimparEmpresa = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTecnico
            // 
            this.cbbTecnico.FormattingEnabled = true;
            this.cbbTecnico.Items.AddRange(new object[] {
            "Jefferson",
            "Fabio",
            "Jadilson",
            "Thiago",
            "Todos"});
            this.cbbTecnico.Location = new System.Drawing.Point(67, 5);
            this.cbbTecnico.Name = "cbbTecnico";
            this.cbbTecnico.Size = new System.Drawing.Size(100, 21);
            this.cbbTecnico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Técnico:";
            // 
            // txtProcurarEmpresa
            // 
            this.txtProcurarEmpresa.Location = new System.Drawing.Point(597, 5);
            this.txtProcurarEmpresa.Name = "txtProcurarEmpresa";
            this.txtProcurarEmpresa.Size = new System.Drawing.Size(459, 20);
            this.txtProcurarEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa:";
            // 
            // btnProcurarEmpresa
            // 
            this.btnProcurarEmpresa.Location = new System.Drawing.Point(492, 31);
            this.btnProcurarEmpresa.Name = "btnProcurarEmpresa";
            this.btnProcurarEmpresa.Size = new System.Drawing.Size(99, 23);
            this.btnProcurarEmpresa.TabIndex = 4;
            this.btnProcurarEmpresa.Text = "Procurar Empresa";
            this.btnProcurarEmpresa.UseVisualStyleBackColor = true;
            this.btnProcurarEmpresa.Click += new System.EventHandler(this.btnProcurarEmpresa_Click);
            // 
            // dgvProcurarEmpresa
            // 
            this.dgvProcurarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurarEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnpj,
            this.nome,
            this.telefone});
            this.dgvProcurarEmpresa.Location = new System.Drawing.Point(597, 31);
            this.dgvProcurarEmpresa.Name = "dgvProcurarEmpresa";
            this.dgvProcurarEmpresa.RowHeadersVisible = false;
            this.dgvProcurarEmpresa.Size = new System.Drawing.Size(459, 144);
            this.dgvProcurarEmpresa.TabIndex = 5;
            this.dgvProcurarEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurarEmpresa_CellClick);
            this.dgvProcurarEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurarEmpresa_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empresa Selecionada:";
            // 
            // txtEmpresaSelecionada
            // 
            this.txtEmpresaSelecionada.Location = new System.Drawing.Point(12, 154);
            this.txtEmpresaSelecionada.Name = "txtEmpresaSelecionada";
            this.txtEmpresaSelecionada.Size = new System.Drawing.Size(474, 20);
            this.txtEmpresaSelecionada.TabIndex = 6;
            // 
            // btnListarResultado
            // 
            this.btnListarResultado.Location = new System.Drawing.Point(492, 152);
            this.btnListarResultado.Name = "btnListarResultado";
            this.btnListarResultado.Size = new System.Drawing.Size(99, 23);
            this.btnListarResultado.TabIndex = 7;
            this.btnListarResultado.Text = "Listar Resultado";
            this.btnListarResultado.UseVisualStyleBackColor = true;
            this.btnListarResultado.Click += new System.EventHandler(this.btnListarResultado_Click);
            // 
            // dgvListarResultado
            // 
            this.dgvListarResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aberto,
            this.id1,
            this.fk_idempresa,
            this.dataFinal,
            this.fk_idtecnico,
            this.resumo,
            this.data,
            this.atendimento,
            this.telefone1,
            this.contato});
            this.dgvListarResultado.Location = new System.Drawing.Point(12, 182);
            this.dgvListarResultado.Name = "dgvListarResultado";
            this.dgvListarResultado.RowHeadersVisible = false;
            this.dgvListarResultado.Size = new System.Drawing.Size(1044, 387);
            this.dgvListarResultado.TabIndex = 6;
            // 
            // aberto
            // 
            this.aberto.DataPropertyName = "aberto";
            this.aberto.HeaderText = "aberto";
            this.aberto.Name = "aberto";
            this.aberto.Visible = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "id1";
            this.id1.Name = "id1";
            this.id1.Visible = false;
            // 
            // fk_idempresa
            // 
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.Visible = false;
            // 
            // dataFinal
            // 
            this.dataFinal.DataPropertyName = "dataFinal";
            this.dataFinal.HeaderText = "dataFinal";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Visible = false;
            // 
            // fk_idtecnico
            // 
            this.fk_idtecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.fk_idtecnico.DataPropertyName = "fk_idtecnico";
            this.fk_idtecnico.HeaderText = "Técnico";
            this.fk_idtecnico.Name = "fk_idtecnico";
            this.fk_idtecnico.Width = 21;
            // 
            // resumo
            // 
            this.resumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resumo.DataPropertyName = "resumo";
            this.resumo.HeaderText = "Resumo";
            this.resumo.Name = "resumo";
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 55;
            // 
            // atendimento
            // 
            this.atendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.atendimento.DataPropertyName = "atendimento";
            this.atendimento.HeaderText = "Atendimento";
            this.atendimento.Name = "atendimento";
            this.atendimento.Width = 21;
            // 
            // telefone1
            // 
            this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefone1.DataPropertyName = "telefone";
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.Name = "telefone1";
            this.telefone1.Width = 74;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contato.DataPropertyName = "contato";
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            this.contato.Width = 69;
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.Items.AddRange(new object[] {
            "CNPJ",
            "Nome"});
            this.cbbEmpresa.Location = new System.Drawing.Point(512, 5);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(79, 21);
            this.cbbEmpresa.TabIndex = 2;
            this.cbbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbbEmpresa_SelectedIndexChanged);
            // 
            // txtEmpresaID
            // 
            this.txtEmpresaID.Location = new System.Drawing.Point(512, 63);
            this.txtEmpresaID.Name = "txtEmpresaID";
            this.txtEmpresaID.Size = new System.Drawing.Size(79, 20);
            this.txtEmpresaID.TabIndex = 11;
            this.txtEmpresaID.Visible = false;
            // 
            // btnLimparEmpresa
            // 
            this.btnLimparEmpresa.Location = new System.Drawing.Point(492, 60);
            this.btnLimparEmpresa.Name = "btnLimparEmpresa";
            this.btnLimparEmpresa.Size = new System.Drawing.Size(99, 23);
            this.btnLimparEmpresa.TabIndex = 5;
            this.btnLimparEmpresa.Text = "Limpar Empresa";
            this.btnLimparEmpresa.UseVisualStyleBackColor = true;
            this.btnLimparEmpresa.Click += new System.EventHandler(this.btnLimparEmpresa_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // cnpj
            // 
            this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.Width = 59;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.Visible = false;
            // 
            // frmListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 581);
            this.Controls.Add(this.btnLimparEmpresa);
            this.Controls.Add(this.txtEmpresaID);
            this.Controls.Add(this.cbbEmpresa);
            this.Controls.Add(this.btnListarResultado);
            this.Controls.Add(this.txtEmpresaSelecionada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListarResultado);
            this.Controls.Add(this.dgvProcurarEmpresa);
            this.Controls.Add(this.btnProcurarEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProcurarEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTecnico);
            this.Name = "frmListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Chamados";
            this.Load += new System.EventHandler(this.frmListagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcurarEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurarEmpresa;
        private System.Windows.Forms.DataGridView dgvProcurarEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresaSelecionada;
        private System.Windows.Forms.Button btnListarResultado;
        private System.Windows.Forms.DataGridView dgvListarResultado;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private System.Windows.Forms.TextBox txtEmpresaID;
        private System.Windows.Forms.Button btnLimparEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}