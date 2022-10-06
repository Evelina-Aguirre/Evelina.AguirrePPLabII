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
        int m, mx, my;
        public static int cargo = 0;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if(TiendaDeElectronica.Logueo(this.txtUsuario.Text, this.txtClave.Text) is EPersona.Vendedor)
            {
                Venta frmVenta = new Venta();
                frmVenta.Show();
                this.Hide();
            }
            else if (TiendaDeElectronica.Logueo(this.txtUsuario.Text, this.txtClave.Text) is EPersona.Dueño)
            {
                cargo = 1;
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

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Inicio_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void lnklblOlvidasteClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Prueba frmHarcodeo = new Prueba();
            frmHarcodeo.Show();
            this.Hide();
        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
