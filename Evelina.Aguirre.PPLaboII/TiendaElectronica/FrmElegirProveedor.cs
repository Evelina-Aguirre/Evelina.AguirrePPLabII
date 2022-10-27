using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UITiendaElectronica;
using Entidades;
using Entidades.ExcepcionesPropias;
using Entidades.Productos;
using Entidades.Tienda;
using Entidades.TiendaElectronica;

namespace UITiendaElectronica
{
    public partial class FrmElegirProveedor : Form
    {
        public static int proveeedorElegido = 0;
        public FrmElegirProveedor()
        {
            InitializeComponent();
        }

        private void FrmElegirProveedor_Load(object sender, EventArgs e)
        {
            List<string> proveedores = new List<string>();
            proveedores.Add("Electrónica buen precio");
            proveedores.Add("Electrónica buena calidad");
            this.cmbProveedores.DataSource = proveedores;
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveeedorElegido = this.cmbProveedores.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
