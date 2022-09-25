using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaElectronica
{
    public partial class FrmLogueo : Form
    {
      
        public FrmLogueo()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text == "vend" && this.txtClave.Text == "vend")
            {
                FrmVenta frmVenta = new FrmVenta();
                frmVenta.Show();
                this.Hide();
            }
            else if (this.txtUsuario.Text == "dueño" && this.txtClave.Text == "dueño")
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos.");
            }

        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
