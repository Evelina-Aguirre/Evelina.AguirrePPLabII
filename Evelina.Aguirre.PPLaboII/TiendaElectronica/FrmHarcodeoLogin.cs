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
    }
}
