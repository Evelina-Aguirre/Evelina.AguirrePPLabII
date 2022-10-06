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
    public partial class FrmHarcodeoLogin : Form
    {
        public FrmHarcodeoLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta frmVenta = new Venta();
            WindowState = FormWindowState.Minimized;
            frmVenta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menú frmAdmin = new Menú();
            WindowState = FormWindowState.Minimized;
            frmAdmin.ShowDialog();
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
