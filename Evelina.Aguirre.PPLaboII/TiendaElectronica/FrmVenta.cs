﻿using Entidades;
using Entidades.TiendaElectronica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UITiendaElectronica
{
    public partial class Venta : Form
    {
        int m, mx, my;

        //Factura auxiliar a partir de la cual se instanciará una Factura-Efectivo/Debito/Crédito una vez elegido el método de pago.
        private Factura auxFactura = new Factura(EMetodosDePago.efectivo,0);
        
        public Venta()
        {
            InitializeComponent();
        }
        private void Venta_Load(object sender, EventArgs e)
        {
            this.dgvCarritoCliente.ColumnCount = 3;
            this.dgvCarritoCliente.Columns[0].Name = "ID";
            this.dgvCarritoCliente.Columns[1].Name = "Producto";
            this.dgvCarritoCliente.Columns[2].Name = "Precio";

            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que el form inicie con las columnas correspondientes a un producto pero sin datos.
            this.dgvProductosTienda.DataSource = auxLista;
            this.lblTotalCarrito.Text = "0";
            this.lblCalculoVuelto.Text = "-";
            this.rdoEfectivo.Checked = true;
            this.cmbCuotas.Visible = false;
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }


        private void btnLeds_Click(object sender, EventArgs e)
        {

            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, TiendaDeElectronica.InventarioTienda);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, TiendaDeElectronica.InventarioTienda);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, TiendaDeElectronica.InventarioTienda);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, TiendaDeElectronica.InventarioTienda);
        }
        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            this.dgvProductosTienda.DataSource = TiendaDeElectronica.BuscarProductoPorNombre(txtBuscat.Text.ToString().ToLower());
        }

        private void txtBuscat_Click(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que se carguen las columnas correspondientes a un producto pero sin datos.
            this.dgvProductosTienda.DataSource = auxLista;
            this.txtBuscat.Text = string.Empty;
            this.dgvProductosTienda.DataSource = null;
        }


        
        private void dgvProductosTienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instancia un producto para poder agregarlo a la factura.
            Producto auxProducto = new Producto(
              this.dgvProductosTienda.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[3].Value.ToString()),
               (short)Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[0].Value), "",
               (ECategoriaElectronico)this.dgvProductosTienda.CurrentRow.Cells[5].Value);

            //Vista previa del producto agregador al dgv de los productos a vender.
            this.dgvCarritoCliente.Rows.Add(this.dgvProductosTienda.CurrentRow.Cells[0].Value, this.dgvProductosTienda.CurrentRow.Cells[1].Value,
                dgvProductosTienda.CurrentRow.Cells[3].Value);

            //Muestra descrición del producto en el label de detalles.
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();

            //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
            this.auxFactura += auxProducto;

            //Muestra el total actual de la factura auxiliar con el producto agregado.
            this.lblTotalCarrito.Text = this.auxFactura.TotalCompra.ToString();
        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }




        private void llbBorrarProductoDeLista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (this.dgvCarritoCliente.Rows.Count > 1 && this.dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
             {
                int id = Convert.ToInt32(this.dgvCarritoCliente.CurrentRow.Cells[0].Value);
                _ = auxFactura - id;
                this.lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
                dgvCarritoCliente.Rows.RemoveAt(dgvCarritoCliente.CurrentRow.Index);
            }
        }

        private void rdoDebiro_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCuotasAbonaCon.Text = "Abona con";
            this.lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 25);
            this.lblMontoInsuficiente.Visible = false;
            this.lblAuxlblVuelto.Visible = false;
            this.btnVerVuelto.Visible = false;
            this.lblsimboloPesos.Visible = false;
            this.lblCalculoVuelto.Visible = false;

            this.txtAbonacon.Enabled = false;
            this.txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.txtAbonacon.Text = lblTotalCarrito.Text;

        }

        private void rdoCredito_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 60);
            this.lblMontoInsuficiente.Visible = false;
            this.lblCuotasAbonaCon.Text = "Cant. Cuotas";
            this.lblAuxlblVuelto.Visible = false;
            this.btnVerVuelto.Visible = false;
            this.lblsimboloPesos.Visible = false;
            this.lblCalculoVuelto.Visible = false;

            this.txtAbonacon.Enabled = false;
            this.txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.txtAbonacon.Text = lblTotalCarrito.Text;

            this.cmbCuotas.Visible = true;
            this.cmbCuotas.SelectedIndex = 0;

        }

        private void btnVerVuelto_Click(object sender, EventArgs e)
        {
            float abonaCon;
            bool esNumero = float.TryParse(this.txtAbonacon.Text, out abonaCon);

            if (this.txtAbonacon.Text != null && esNumero)
            {
                //La propiedad "Vuelto" la tiene la facturaEfectivo, que se instanciará recién al al elegir el método de pago,
                //Uso el método de esta clase (facturaEfectivo) para poder mostrarlo en el form de manera orientativa para el usuario.
                lblCalculoVuelto.Text = FacturaEfectivo.CalculoVuelto(auxFactura.TotalCompra, float.Parse(this.txtAbonacon.Text)).ToString();
                  
                if (float.Parse(this.lblTotalCarrito.Text) > float.Parse(this.txtAbonacon.Text))
                {
                    this.lblMontoInsuficiente.Text = "Monto insuficiente";
                    this.timer1.Interval = 3000;
                    this.timer1.Start();
                }
            }
            else if (txtAbonacon.Text == null || !esNumero)
            {
                this.lblCalculoVuelto.Text = "-";
                this.lblMontoInsuficiente.Text = "Debe ingresar un valor numérico";
                this.timer1.Interval = 3000;
                this.timer1.Start();
            }


        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 25);
            this.lblCuotasAbonaCon.Text = "Abona con";
            this.btnVerVuelto.Visible = true;
            this.btnVerVuelto.Enabled = true;
            this.lblMontoInsuficiente.Visible = true;
            this.txtAbonacon.Text = "";
            this.txtAbonacon.BackColor = Color.White;
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.cmbCuotas.Visible = false;
            this.lblAuxlblVuelto.Visible = true;
            this.lblsimboloPesos.Visible = true;
            this.lblCalculoVuelto.Visible = true;
            this.txtAbonacon.Enabled = true;


        }

        private void txtAbonacon_Click(object sender, EventArgs e)
        {
            this.txtAbonacon.Text = string.Empty;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblMontoInsuficiente.Text = "";
            this.timer1.Stop();
        }

        private void txtBuscat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                this.btnBuscar.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.dgvCarritoCliente.Rows.Count > 1 && this.dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
            {
                Factura facturaFinal;
                foreach (Control item in this.grbFormaDePago.Controls)
                {
                    if (item is RadioButton)
                    {
                        if (rdoEfectivo.Checked)
                        {
                            int abonaCon;
                            bool esNumero = int.TryParse(this.txtAbonacon.Text, out abonaCon);

                            if (this.txtAbonacon.Text != null && esNumero && Convert.ToInt32(this.lblTotalCarrito.Text) < Convert.ToInt32(this.txtAbonacon.Text))
                            {
                                facturaFinal = new FacturaEfectivo(EMetodosDePago.efectivo, auxFactura.TotalCompra, 0,
                               Convert.ToDouble(txtAbonacon.Text));
                                MessageBox.Show(facturaFinal.ToString());
                                //Resetea la lista de la factura de la venta ya concretada y limpia dgv y labels.
                                Factura.Carrito.Clear();
                                this.lblTotalCarrito.Text = string.Empty;
                                this.dgvCarritoCliente.Rows.Clear();
                                this.rdoEfectivo.Checked = true;

                            }
                            else
                            {   //El Botón ver vuelto ya setea qué acciones tomar en caso de que el monto sea insuficiente o inválido.
                                btnVerVuelto.PerformClick();
                            }
                           

                        }
                        else if (rdoCredito.Checked)
                        {
                            facturaFinal = new FacturaCredito( EMetodosDePago.Credito, Convert.ToDouble(lblTotalCarrito.Text),
                                 Convert.ToInt32(cmbCuotas.SelectedItem.ToString()));
                            MessageBox.Show(facturaFinal.ToString());
                            //Resetea la lista de la factura de la venta concretada y limpia dgv y labels.
                            Factura.Carrito.Clear();
                            this.lblTotalCarrito.Text = string.Empty;
                            this.dgvCarritoCliente.Rows.Clear();
                            this.rdoEfectivo.Checked = true;
                        }
                        else if (rdoDebiro.Checked)
                        {
                            facturaFinal = new FacturaDebito( EMetodosDePago.Debito, Convert.ToDouble(lblTotalCarrito.Text));
                            MessageBox.Show(facturaFinal.ToString());
                            //Resetea la lista de la factura de la venta concretada y limpia dgv y labels. 
                            Factura.Carrito.Clear();
                            this.lblTotalCarrito.Text = string.Empty;
                            this.dgvCarritoCliente.Rows.Clear();
                            this.rdoEfectivo.Checked = true;
                        }
                        break;

                    }

                }
            }
            
        }


        private void txtAbonacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                this.btnVerVuelto.PerformClick();
            }
        }


        private void Venta_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Venta_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void Venta_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }



    }
}
