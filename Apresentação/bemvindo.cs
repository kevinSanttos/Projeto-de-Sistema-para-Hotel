using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Apresentação;

namespace WindowsFormsApp2
{
    public partial class bemvindo : Form
    {
        private Form frmAtivo;
        public bemvindo()
        {
            InitializeComponent();
        }

        private void FormsShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelSistema.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.Gray;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            FormsShow(new frmHome());
        }

        private void btnHospedClick(object sender, EventArgs e)
        {
            ActiveButton(btnHosped);
            FormsShow(new frmHosp());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnUsuarios);
            FormsShow(new frmUsuarios());
        }
        
        private void btnQuartos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnQuartos);
            FormsShow(new frmQuartos2());
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnGraficos);
            FormsShow(new frmGraficos());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            ActiveFormClose();
            Application.Exit();
        }
            
        }
    }