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

namespace UITiendaElectronica
{
    public partial class Inicio : Form
    {
      
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if(TiendaElectronica.Logueo(this.txtUsuario.Text, this.txtClave.Text) is EPersona.Vendedor)
            {
                Venta frmVenta = new Venta();
                frmVenta.Show();
                this.Hide();
            }
            else if (TiendaElectronica.Logueo(this.txtUsuario.Text, this.txtClave.Text) is EPersona.Dueño)
            {
                Menú frmMenuPrincipal = new Menú();
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
