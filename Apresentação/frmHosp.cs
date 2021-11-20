using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Apresentação
{
    public partial class frmHosp : Form
    {
        DataTable dt = new DataTable();
        public frmHosp()
        {
            InitializeComponent();
            ConfigurarTabela();
        }
        private void ConfigurarTabela()
        {
            dt.Columns.Add("id", typeof(Int32));
            dt.Columns["id"].AutoIncrement = true;
            dt.Columns["id"].AutoIncrementSeed = 1;

            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("nomel", typeof(string));
            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                AtualizarLinha(Convert.ToInt32("0" + lblid.Text));
                LimparForm();
                txtEmail.Focus();
            }
        }
            private bool validarForm()
            {
                var result = true;
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email é Obrigatório?", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    result = false;
                }
                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome Completo é obrigatório?", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    result = false;

                }
                return result;
            }
            private void AtualizarLinha(int id)

            {
                if (id == 0)
                {
                    dt.Rows.Add(null, txtEmail.Text, txtNome.Text);

                }
            else
            {
                DataRow[] row = dt.Select("id = " + id);
                if(row.Length > 0)
                {
                    row[0]["email"] = txtEmail.Text;
                    row[0]["nome"] = txtNome.Text;

                }
            }

            }
        

        private void LimparForm()
        {
            lblid.Text = "";
            txtEmail.Clear();
            txtNome.Clear();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            GetEmail(txtEmail.Text);
        }
        private void GetEmail(string email)
        {
            DataRow[] row = dt.Select("email = " + email + "'");
            if (row.Length > 0)
            {
                lblid.Text = row[0]["id"].ToString();
                txtEmail.Text = row[0]["email"].ToString();
                txtNome.Text = row[0]["nome"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblid.Text != "")
            {
                if(MessageBox.Show("Deseja Excluir?", "Validar", MessageBoxButtons, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluirLinha(Convert.ToInt32(0 + lblid.Text));
                    LimparForm();
                    txtEmail.Focus();
                }
            }
        }

        private void ExcluirLinha(indexer id)
        {
            DataRow[] row = dt.Select("id = " + id);
            if (row.Length > 0)
                row[0].Delete();
        }
    }

}
