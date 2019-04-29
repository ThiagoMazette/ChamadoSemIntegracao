using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamadaModelos;
using CamadaDados;
using System.Data.OleDb;

namespace Chamados
{

    public partial class frmAtenderChamado : Form
    {
        public frmAtenderChamado()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string txtEmpresaString;
        private void frmAtenderChamado_Load(object sender, EventArgs e)
        {
            cbbAtendimento.SelectedIndex = 0;
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.txtEmpresaID = txtEmpresaID.Text;
            _mdlEmpresa.txtID = txtChamadoID.Text;
            dgvOutrosAtendimentos.DataSource = _ctlEmpresa.CarregarOutrosChamados(_mdlEmpresa);
            dgvOutrosAtendimentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // dgvOutrosAtendimentos.;




            /*mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            txtEmpresa.Text = _mdlEmpresa.txtEmpresa; */


            /*
            frmAtenderChamado frmAC = new frmAtenderChamado();
            frmAC.MdiParent = this.MdiParent;
            frmAC.txtEmpresa.Text = dgvOutrosAtendimentos.CurrentRow.Cells[1].FormattedValue.ToString();
            frmAC.ShowDialog(); */
            /*
            FormEditarCliente fed = new FormEditarCliente();
            fed.MdiParent = this.MdiParent;
            fed.txtnumcli.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
            fed.txtnome.Text = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            fed.txtnif.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
            fed.txtemail.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            fed.txtend.Text = dataGridView1.CurrentRow.Cells[5].FormattedValue.ToString();
            fed.txtende2.Text = dataGridView1.CurrentRow.Cells[6].FormattedValue.ToString();
            fed.txtcp.Text = dataGridView1.CurrentRow.Cells[7].FormattedValue.ToString();
            fed.txtpais.Text = dataGridView1.CurrentRow.Cells[8].FormattedValue.ToString();
            fed.Show();
            */


        }
               
        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOutrosAtendimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.Telefone = txtTelefone.Text;
            _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
            //_mdlEmpresa.cbbTecnico = cbbTecnico.SelectedValue.ToString(); <-- usar qdo popular
            _mdlEmpresa.Contato = txtContato.Text;
            _mdlEmpresa.Resumo = txtResumo.Text;
            _mdlEmpresa.ID = txtChamadoID.Text;
            _mdlEmpresa.Atendimento = cbbAtendimento.Text;

            bool retorno1 = _ctlEmpresa.FinalizarChamado (_mdlEmpresa);
            if (retorno1)
            {
                MessageBox.Show("Chamado fechado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao fechar chamado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.TextLength == 11 || txtTelefone.TextLength == 15)
            {
                txtTelefone.Mask = "(00) 00000-0000";
            }
            else
            {
                txtTelefone.Mask = "(00) 0000-0000";
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Mask = "";
        }
    }
}
