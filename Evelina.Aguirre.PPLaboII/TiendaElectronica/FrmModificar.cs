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
            this.cmbCategoria.SelectedIndex = -1;
        }


        private void FrmModificar_Load(object sender, EventArgs e)
        {
            //Producto auxProducto = TiendaDeElectronica.BuscarProducto(this.Id);

            // this.lblProducto.Text=(auxProducto.Nombre.ToString());

            this.cmbCategoria.DataSource = System.Enum.GetValues(typeof(ECategoriaElectronico));
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


            //Cambio Precio
            if (txtPrecio.Text != null && esNumero)
            {
                int id = Convert.ToInt32(this.lblId.Text);

                foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (id == item.Value.Id)
                    {
                        item.Value.Precio = Convert.ToDouble(this.txtPrecio.Text);
                        break;
                    }
                }
            }
            else
            {
                this.lblError.Text = "Monto inválido";
                this.timerError.Interval = 3000;
                this.timerError.Start();
            }

            if(cmbCategoria.SelectedIndex == -1)
            {
                this.lblError.Text = "Debe elegir una categoría";
                this.timerError.Interval = 3000;
                this.timerError.Start();
            }
            else
            {
                foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (Convert.ToInt32(this.lblId.Text) == item.Value.Id)
                    {
                        item.Value.Categoria = Producto.StringAECategoriaElectronico(this.cmbCategoria.Text);
                        break;
                    }
                }
            }

            DialogResult resultado = MessageBox.Show($"Item:{this.lblNombreProductp.Text} Id: {this.lblId.Text} \n\n Nuevo Precio: " +
                $"{this.txtPrecio.Text}\nNueva Categoría: {this.cmbCategoria.SelectedItem.ToString()}", "Desdea Guardar los cambios ?"
                , MessageBoxButtons.YesNo);
            if(resultado == DialogResult.No)
            {
                Producto auxProducto = TiendaDeElectronica.BuscarProducto(Convert.ToInt32(this.lblId.Text));
                auxProducto.Precio = Convert.ToDouble(this.lblPrecio.Text);
                auxProducto.Categoria = Producto.StringAECategoriaElectronico(this.lblCategoriaActual.Text);
            }

            
            

        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.timerError.Stop();
        }
    }
}
