using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelos;
using System.Data.OleDb;

namespace Chamados
{
    public partial class frmAbrirChamado : Form
    {

        public frmAbrirChamado()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbrirChamado_Load(object sender, EventArgs e)
        {
            cbbSelecao.SelectedIndex = 1;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProcurar.Text = "";
            txtEmpresaAbrirChamado.Text = "";
        }

        void Procurar()
        {
            string str = txtProcurar.Text;
            string test = str.Replace("/", "").Replace(".", "").Replace("-", "");
            txtProcurar.Text = test;
            txtProcurar.Select(txtProcurar.Text.Length, 0);

            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.FiltroAbrirChamado = cbbSelecao.Text;
            _mdlEmpresa.FiltrotxtProcurar = txtProcurar.Text;
            dgvResultado.DataSource = _ctlEmpresa.EmpresaPesquisarMDL(_mdlEmpresa);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
        }
        
        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpresaAbrirChamado.Text = dgvResultado.CurrentRow.Cells["Nome"].Value.ToString();
            txtAbrirChamadoID.Text = dgvResultado.CurrentRow.Cells["id"].ToString();
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void AbrirChamado()
        {
            if (txtEmpresaAbrirChamado.Text == "")
            {
                MessageBox.Show("Selecione uma empresa !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcurar.Focus();
            }
            else
            {
                ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();


                //      _mdlEmpresa.Abrir = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();
                _mdlEmpresa.ID = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                //     dgvResultado.DataSource = _ctlEmpresa.EmpresaAbrirChamado(_mdlEmpresa); aki duplica


                bool retorno1 = _ctlEmpresa.EmpresaAbrirChamado(_mdlEmpresa);
                if (retorno1)
                {
                    MessageBox.Show("Chamado Aberto com sucesso");
                    Close();
                   /* dgvResultado.DataSource = null;
                    txtEmpresaAbrirChamado.Text = "";
                    txtProcurar.Text = "";
                    txtProcurar.Focus(); */
                }
                else
                {
                    MessageBox.Show("Erro ao abrir chamado");
                }
            }
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado();
        }

        private void txtProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtProcurar.Text.Length >= 2)
            {
                Procurar();
            }
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirChamado();
        }

        private void txtProcurar_Leave(object sender, EventArgs e)
        {

        }
    }
}
