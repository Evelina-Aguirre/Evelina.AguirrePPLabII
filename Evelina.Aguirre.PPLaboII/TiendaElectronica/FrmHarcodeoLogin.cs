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
    public partial class Prueba : Form
    {
        int m, mx, my;
        public Prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio.cargo = 0;
            Venta frmVenta = new Venta();
            this.Close();
            frmVenta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio.cargo = 1;
            Menú frmAdmin = new Menú();
            this.Close();
            frmAdmin.Show();
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio.cargo = 3;
            FrmEstadisticas frmEst = new FrmEstadisticas();
            this.Close();
            frmEst.Show();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }

        private void Prueba_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }

        private void Prueba_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Prueba_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
