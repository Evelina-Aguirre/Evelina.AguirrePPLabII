﻿using Entidades;
using Entidades.Productos;
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
        int m, mx, my;
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
            if (txtPrecio.Text != null && esNumero && abonaCon > 0)
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

                foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (Convert.ToInt32(this.lblId.Text) == item.Value.Id)
                    {
                        item.Value.Categoria = Buscador.StringAECategoriaElectronico(this.cmbCategoria.Text);
                        break;
                    }
                }

                DialogResult resultado = MessageBox.Show($"Item:  {this.lblNombreProductp.Text}  --  Id: {this.lblId.Text} \n\nNuevo Precio:         $" +
                    $"{this.txtPrecio.Text}\nNueva Categoría:      {this.cmbCategoria.SelectedItem.ToString()}", "Desdea Guardar los cambios?"
                , MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                {
                    Producto auxProducto = Buscador.BuscarProducto(Convert.ToInt32(this.lblId.Text),TiendaDeElectronica.InventarioTienda);
                    auxProducto.Precio = Convert.ToDouble(this.lblPrecio.Text);
                    auxProducto.Categoria = Buscador.StringAECategoriaElectronico(this.lblCategoriaActual.Text);
                }
                else
                {
                    this.Close();
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
           
            

        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.timerError.Stop();
        }

        private void Modificar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Modificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAceptar.PerformClick();
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                this.btnAceptar.PerformClick();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                this.btnAceptar.PerformClick();
            }
        }

        private void Modificar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Modificar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }
    }
}
