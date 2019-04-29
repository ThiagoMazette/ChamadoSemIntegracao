﻿namespace Chamados
{
    partial class frmListarChamado
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.EmpresaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpresaID,
            this.chamadoId,
            this.atendimento,
            this.data_final,
            this.aberto,
            this.fk_idempresa,
            this.Nome,
            this.fk_idtecnico,
            this.resumo,
            this.data});
            this.dgvResultado.Location = new System.Drawing.Point(23, 24);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(468, 394);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellClick);
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentClick);
            this.dgvResultado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentDoubleClick);
            // 
            // EmpresaID
            // 
            this.EmpresaID.DataPropertyName = "tb_empresas.id";
            this.EmpresaID.HeaderText = "Empresa ID";
            this.EmpresaID.Name = "EmpresaID";
            this.EmpresaID.ReadOnly = true;
            this.EmpresaID.Visible = false;
            // 
            // chamadoId
            // 
            this.chamadoId.DataPropertyName = "tb_chamados.id";
            this.chamadoId.HeaderText = "Chamado ID";
            this.chamadoId.Name = "chamadoId";
            this.chamadoId.ReadOnly = true;
            this.chamadoId.Visible = false;
            // 
            // atendimento
            // 
            this.atendimento.DataPropertyName = "atendimento";
            this.atendimento.HeaderText = "atendimento";
            this.atendimento.Name = "atendimento";
            this.atendimento.ReadOnly = true;
            this.atendimento.Visible = false;
            // 
            // data_final
            // 
            this.data_final.DataPropertyName = "data_final";
            this.data_final.HeaderText = "data_final";
            this.data_final.Name = "data_final";
            this.data_final.ReadOnly = true;
            this.data_final.Visible = false;
            // 
            // aberto
            // 
            this.aberto.DataPropertyName = "aberto";
            this.aberto.HeaderText = "aberto";
            this.aberto.Name = "aberto";
            this.aberto.ReadOnly = true;
            this.aberto.Visible = false;
            // 
            // fk_idempresa
            // 
            this.fk_idempresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.ReadOnly = true;
            this.fk_idempresa.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // fk_idtecnico
            // 
            this.fk_idtecnico.DataPropertyName = "fk_idtecnico";
            this.fk_idtecnico.HeaderText = "Tecnico";
            this.fk_idtecnico.Name = "fk_idtecnico";
            this.fk_idtecnico.ReadOnly = true;
            this.fk_idtecnico.Visible = false;
            // 
            // resumo
            // 
            this.resumo.DataPropertyName = "resumo";
            this.resumo.HeaderText = "resumo";
            this.resumo.Name = "resumo";
            this.resumo.ReadOnly = true;
            this.resumo.Visible = false;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 55;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(497, 24);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(497, 395);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmListarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 438);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmListarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Chamado";
            this.Load += new System.EventHandler(this.frmListarChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}