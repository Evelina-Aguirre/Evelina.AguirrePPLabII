using Entidades;
using Entidades.Productos;
using Entidades.Tienda;
using Entidades.TiendaElectronica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UITiendaElectronica
{
    public partial class Venta : Form
    {
        //variables para tomar pocisión del puntero si se intenta mover el formulario.
        int m, mx, my;

        //Factura auxiliar a partir de la cual se instanciará una Factura-Efectivo/Debito/Crédito una vez elegido el método de pago.
        private FacturaDebito auxFactura = new FacturaDebito(EMetodosDePago.efectivo, 0);
        private Estadisticas auxEstadistica = new Estadisticas();

        public Venta()
        {
            InitializeComponent();
        }
        private void Venta_Load(object sender, EventArgs e)
        {
            dgvCarritoCliente.ColumnCount = 4;
            dgvCarritoCliente.Columns[0].Name = "ID";
            dgvCarritoCliente.Columns[1].Name = "Producto";
            dgvCarritoCliente.Columns[2].Name = "Precio";
            dgvCarritoCliente.Columns[3].Name = "Cantidad";

            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que el form inicie con las columnas correspondientes a un producto pero sin datos.
            dgvProductosTienda.DataSource = auxLista;
            lblTotalCarrito.Text = "0";
            lblCalculoVuelto.Text = "-";
            rdoEfectivo.Checked = true;
            cmbCuotas.Visible = false;
            lblVentaCredito.Visible = false;
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
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Leds, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, TiendaDeElectronica.InventarioTienda);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, TiendaDeElectronica.InventarioTienda);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, TiendaDeElectronica.InventarioTienda);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, TiendaDeElectronica.InventarioTienda);
        }
        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Buscador.BuscarProducto(txtBuscat.Text.ToString().ToLower(), TiendaDeElectronica.InventarioTienda);
            
        }

        private void txtBuscat_Click(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            dgvProductosTienda.DataSource = auxLista;
            txtBuscat.Text = string.Empty;
            dgvProductosTienda.DataSource = null;
        }



        private void dgvProductosTienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCarritoCliente.Rows.Count > 1 && dgvCarritoCliente.Rows[0].Cells[0].Value is not null)
            {


                TiendaDeElectronica tienda = new TiendaDeElectronica();


                //Instancia un producto para poder agregarlo a la factura.
                Producto auxProducto = new Producto(
             dgvProductosTienda.CurrentRow.Cells[0].Value.ToString(), Convert.ToDouble(dgvProductosTienda.CurrentRow.Cells[2].Value.ToString()),
              (int)Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[5].Value), "",
              (ECategoriaElectronico)dgvProductosTienda.CurrentRow.Cells[4].Value, 1);


                //Vista previa del producto agregador al dgv de los productos a vender.
                int cantidad = 1;
                int existe = -1;
                int id = Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[5].Value);

                if (dgvCarritoCliente.Rows.Count > 1 && dgvCarritoCliente.Rows[0].Cells[0].Value is not null)
                {
                    foreach (DataGridViewRow row in dgvCarritoCliente.Rows)
                    {
                        if (Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[5].Value) == Convert.ToInt32(row.Cells[0].Value))
                        {
                            existe = row.Index;
                        }
                    }
                }

                if (existe > -1 && Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[1].Value) > 0)
                {
                    //Si existe toma el valor cantidad para incrementarlo
                    cantidad = Convert.ToInt32(dgvCarritoCliente.Rows[existe].Cells[3].Value);
                    cantidad++;
                    dgvCarritoCliente.Rows[existe].Cells[3].Value = cantidad;
                    dgvCarritoCliente.Rows[existe].Cells[2].Value = Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[2].Value) * cantidad;

                    //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
                    auxFactura += auxProducto;

                    //Lo sumo a la lista de productos para estadísticas
                    _ = auxEstadistica + id;

                    //resto el producto de la tienda
                    _ = tienda - id;

                    //Actualiza dgvProductos en tienda
                    ECategoriaElectronico categoria = Buscador.ObtenerCategoria(dgvProductosTienda.CurrentRow.Cells[4].Value.ToString());
                    dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(categoria, TiendaDeElectronica.InventarioTienda);

                    //Muestra el total actual de la factura auxiliar con el producto agregado.
                    lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();

                }
                else if (Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[1].Value) > 0)
                {
                    //Si el id no existe en el carrito y hay cantidad de ese producto en el inventario de la tienda, lo agrega.
                    dgvCarritoCliente.Rows.Add(dgvProductosTienda.CurrentRow.Cells[5].Value, dgvProductosTienda.CurrentRow.Cells[0].Value,
                    dgvProductosTienda.CurrentRow.Cells[2].Value, cantidad);

                    //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
                    auxFactura += auxProducto;

                    //Lo sumo a la lista de productos para estadísticas
                    _ = auxEstadistica + id;

                    //resto el producto de la tienda
                    _ = tienda - id;

                    //Actualiza dgvProductos en tienda
                    ECategoriaElectronico categoria = Buscador.ObtenerCategoria(dgvProductosTienda.CurrentRow.Cells[4].Value.ToString());
                    dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(categoria, TiendaDeElectronica.InventarioTienda);


                }

                //Muestra el total actual de la factura auxiliar con el producto agregado.
                lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();

                //Muestra descripción del producto en el label de detalles.
                lblDescripcionProducto.Text = dgvProductosTienda.CurrentRow.Cells[3].Value.ToString();
            }

        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProductosTienda.Rows[0].Cells[0].Value is not null)
            {
                lblDescripcionProducto.Text = dgvProductosTienda.CurrentRow.Cells[3].Value.ToString();
            }
        }




        private void llbBorrarProductoDeLista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TiendaDeElectronica tienda = new TiendaDeElectronica();

            if (dgvCarritoCliente.Rows.Count > 1 && dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
            {
                int id = Convert.ToInt32(dgvCarritoCliente.CurrentRow.Cells[0].Value);
                _ = auxFactura - id;
                lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
                //Sumo la cantidad del inventario de la tienda
                _ = tienda + id;

                //resta cantidad del actual y la restituye a la tienda
                int cantidadActual = Convert.ToInt32(dgvCarritoCliente.CurrentRow.Cells[3].Value);

                if (Convert.ToInt32(dgvCarritoCliente.CurrentRow.Cells[3].Value) == 1)
                {
                    dgvCarritoCliente.Rows.RemoveAt(dgvCarritoCliente.CurrentRow.Index);
                    //  _ = auxEstadistica - id;

                }
                else
                {
                    cantidadActual--;
                    dgvCarritoCliente.CurrentRow.Cells[3].Value = cantidadActual;
                }


                //Actualiza dgvProductos en tienda
                ECategoriaElectronico categoria = Buscador.ObtenerCategoria(id);
                dgvProductosTienda.DataSource = Buscador.CargarProductosPorCategoria(categoria, TiendaDeElectronica.InventarioTienda);
            }
        }

        private void rdoDebiro_CheckedChanged(object sender, EventArgs e)
        {
            lblCuotasAbonaCon.Text = "Abona con";
            lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 25);
            lblMontoInsuficiente.Visible = false;
            lblAuxlblVuelto.Visible = false;
            btnVerVuelto.Visible = false;
            lblsimboloPesos.Visible = false;
            lblCalculoVuelto.Visible = false;

            txtAbonacon.Enabled = false;
            txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            txtAbonacon.Text = lblTotalCarrito.Text;
            lblVentaCredito.Visible = false;

        }

        private void rdoCredito_CheckedChanged(object sender, EventArgs e)
        {
            lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 60);
            lblMontoInsuficiente.Visible = false;
            lblCuotasAbonaCon.Text = "Cant. Cuotas";
            lblAuxlblVuelto.Visible = false;
            btnVerVuelto.Visible = false;
            lblsimboloPesos.Visible = false;
            lblCalculoVuelto.Visible = false;

            txtAbonacon.Enabled = false;
            txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            txtAbonacon.Text = lblTotalCarrito.Text;

            cmbCuotas.Visible = true;
            cmbCuotas.SelectedIndex = 0;
            lblVentaCredito.Visible = true;
            lblVentaCredito.Text = "Se aplicará 10% de recargo";

        }

        private void btnVerVuelto_Click(object sender, EventArgs e)
        {
            float abonaCon;
            string txtConComa = txtAbonacon.Text.Replace('.', ',');
            txtAbonacon.Text = txtConComa;
            bool esNumero = float.TryParse(txtAbonacon.Text, out abonaCon);

            if (txtAbonacon.Text != null && esNumero)
            {
                //La propiedad "Vuelto" la tiene la facturaEfectivo, que se instanciará recién al al elegir el método de pago,
                //Uso el método de esta clase (facturaEfectivo) para poder mostrarlo en el form de manera orientativa para el usuario.
                lblCalculoVuelto.Text = Math.Round(FacturaEfectivo.CalculoVuelto(auxFactura.TotalCompra, float.Parse(txtAbonacon.Text)), 2).ToString();

                if (float.Parse(lblTotalCarrito.Text) > float.Parse(txtAbonacon.Text))
                {
                    lblMontoInsuficiente.Text = "Monto insuficiente";
                    timer1.Interval = 3000;
                    timer1.Start();
                }
            }
            else if (txtAbonacon.Text == null || !esNumero)
            {
                lblCalculoVuelto.Text = "-";
                lblMontoInsuficiente.Text = "Debe ingresar un valor numérico";
                timer1.Interval = 3000;
                timer1.Start();
            }


        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 25);
            lblCuotasAbonaCon.Text = "Abona con";
            btnVerVuelto.Visible = true;
            btnVerVuelto.Enabled = true;
            lblMontoInsuficiente.Visible = true;
            txtAbonacon.Text = "";
            txtAbonacon.BackColor = Color.White;
            txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            cmbCuotas.Visible = false;
            lblAuxlblVuelto.Visible = true;
            lblsimboloPesos.Visible = true;
            lblCalculoVuelto.Visible = true;
            txtAbonacon.Enabled = true;
            lblVentaCredito.Visible = false;


        }

        private void txtAbonacon_Click(object sender, EventArgs e)
        {
            txtAbonacon.Text = string.Empty;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMontoInsuficiente.Text = "";
            timer1.Stop();
        }

        private void txtBuscat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                btnBuscar.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiendaDeElectronica tienda = new TiendaDeElectronica();
            if (dgvCarritoCliente.Rows.Count > 1 && dgvCarritoCliente.Rows[0].Cells[0].Value is not null)
            {
                FacturaDebito facturaFinal;
                foreach (Control item in grbFormaDePago.Controls)
                {
                    if (item is RadioButton)
                    {
                        if (rdoEfectivo.Checked)
                        {
                            string txtConComa = txtAbonacon.Text.Replace('.', ',');
                            txtAbonacon.Text = txtConComa;
                            double abonaCon;
                            bool esNumero = double.TryParse(txtAbonacon.Text, out abonaCon);

                            if (txtAbonacon.Text != null && esNumero && auxFactura.TotalCompra < Convert.ToDouble(txtAbonacon.Text))
                            {
                                facturaFinal = new FacturaEfectivo(EMetodosDePago.efectivo, auxFactura.TotalCompra, 0,
                                Convert.ToDouble(txtAbonacon.Text));

                                //Se agrega la venta a las estadísticas de la tienda
                                Estadisticas.ListaFacturas.Add(facturaFinal);
                                Estadisticas.CantidadVentas++;

                                MessageBox.Show("Factura:\n\n" + facturaFinal.ToString());
                                TiendaDeElectronica.CuentaTienda += facturaFinal.TotalCompra;
                                //Resetea la lista de la factura de la venta ya concretada y limpia form.
                                Factura.Carrito.Clear();
                                auxFactura.TotalCompra = 0;
                                lblTotalCarrito.Text = string.Empty;
                                dgvCarritoCliente.Rows.Clear();
                                rdoEfectivo.Checked = true;

                            }
                            else
                            {   //El Botón ver vuelto ya setea qué acciones tomar en caso de que el monto sea insuficiente o inválido.
                                btnVerVuelto.PerformClick();
                            }


                        }
                        else if (rdoCredito.Checked)
                        {
                            facturaFinal = new FacturaCredito(EMetodosDePago.Credito, Convert.ToDouble(lblTotalCarrito.Text),
                                 Convert.ToInt32(cmbCuotas.SelectedItem.ToString()));
                            MessageBox.Show("Factura:\n\n" +
                                facturaFinal.ToString() +
                                "\n Recuerde que se aplica\n" +
                                " un 10 % de recargo a las\n" +
                                " compras en crédito.");

                            TiendaDeElectronica.CuentaTienda += facturaFinal.TotalCompra;

                            //Se agrega la venta a las estadísticas de la tienda
                            Estadisticas.ListaFacturas.Add(facturaFinal);
                            Estadisticas.CantidadVentas++;

                            //Resetea la lista de la factura de la venta concretada y limpia form.
                            Factura.Carrito.Clear();
                            auxFactura.TotalCompra = 0;
                            lblTotalCarrito.Text = string.Empty;
                            dgvCarritoCliente.Rows.Clear();
                            rdoEfectivo.Checked = true;
                        }
                        else if (rdoDebiro.Checked)
                        {
                            facturaFinal = new FacturaDebito(EMetodosDePago.Debito, Convert.ToDouble(lblTotalCarrito.Text));
                            MessageBox.Show("Factura:\n\n" + facturaFinal.ToString());
                            TiendaDeElectronica.CuentaTienda += facturaFinal.TotalCompra;

                            //Se agrega la venta a las estadísticas de la tienda
                            Estadisticas.ListaFacturas.Add(facturaFinal);
                            Estadisticas.CantidadVentas++;

                            Factura.Carrito.Clear();
                            auxFactura.TotalCompra = 0;
                            lblTotalCarrito.Text = string.Empty;
                            dgvCarritoCliente.Rows.Clear();
                            rdoEfectivo.Checked = true;
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
                btnVerVuelto.PerformClick();
            }
        }


        private void Venta_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void llbVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TiendaDeElectronica tienda = new TiendaDeElectronica();
            FacturaDebito.CancelarCompra(tienda);
            Factura.Carrito.Clear();


                if (Inicio.cargo == 1)
                {
                    Menú frmMenu = new Menú();
                    Hide();
                    frmMenu.ShowDialog();

                }
                else
                {
                    Prueba frmPruebaApp = new Prueba();
                    Hide();
                    frmPruebaApp.ShowDialog();
                }
            
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
