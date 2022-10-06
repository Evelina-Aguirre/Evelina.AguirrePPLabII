using Entidades;
using Entidades.Tienda;
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
    public partial class Modificar : Form
    {

        public Modificar()
        {
            InitializeComponent();
        }
        public Modificar(int id, string nombre, string categoria, double precio) : this()
        {
            this.lblId.Text = id.ToString();
            this.lblNombreProductp.Text = nombre;
            this.lblCategoriaActual.Text = categoria;
            this.lblPrecio.Text = precio.ToString();
            this.txtPrecio.Text = precio.ToString();
        }


        private void FrmModificar_Load(object sender, EventArgs e)
        {
            //Producto auxProducto = TiendaDeElectronica.BuscarProducto(this.Id);

            // this.lblProducto.Text=(auxProducto.Nombre.ToString());

            this.cmbCategoria.DataSource = System.Enum.GetValues(typeof(ECategoriaElectronico));
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int abonaCon;
            bool esNumero = int.TryParse(txtPrecio.Text, out abonaCon);

            if (txtPrecio.Text != null && esNumero && Convert.ToInt32(txtPrecio.Text) > Convert.ToInt32(lblPrecio.Text))
            {

            }


            //int id = Convert.ToInt32(this.dgvInventarioTienda.CurrentRow.Cells[5].Value);

            //    foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            //    {
            //        if(id = item.Value.Id)
            //        {

            //        }
            //    }



        }
    }
}
