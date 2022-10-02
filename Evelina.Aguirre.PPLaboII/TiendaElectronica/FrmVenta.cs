using Entidades;
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
            dgvCarritoCliente.ColumnCount = 3;
            dgvCarritoCliente.Columns[0].Name = "ID";
            dgvCarritoCliente.Columns[1].Name = "Producto";
            dgvCarritoCliente.Columns[2].Name = "Precio";

            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que el form inicie con las columnas correspondientes a un producto pero sin datos.
            dgvProductosTienda.DataSource = auxLista;
            lblTotalCarrito.Text = "0";
            lblTotalCarrito.Text = "0";
            lblCalculoVuelto.Text = "0";
            rdoEfectivo.Checked = true;
            cmbCuotas.Visible = false;
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

            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas);
        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas);
        }
        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvProductosTienda.DataSource = TiendaDeElectronica.BuscarProductoPorNombre(txtBuscat.Text.ToString().ToLower());
        }

        private void txtBuscat_Click(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que se carguen las columnas correspondientes a un producto pero sin datos.
            dgvProductosTienda.DataSource = auxLista;
            txtBuscat.Text = string.Empty;
            dgvProductosTienda.DataSource = null;
        }


        
        private void dgvProductosTienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instancia un producto para poder agregarlo a la factura.
            Producto auxProducto = new Producto(
               dgvProductosTienda.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[3].Value.ToString()),
               (short)Convert.ToInt32(dgvProductosTienda.CurrentRow.Cells[0].Value), "",
               (ECategoriaElectronico)dgvProductosTienda.CurrentRow.Cells[5].Value);

            //Vista previa del producto agregador al dgv de los productos a vender.
            dgvCarritoCliente.Rows.Add(dgvProductosTienda.CurrentRow.Cells[0].Value, dgvProductosTienda.CurrentRow.Cells[1].Value,
                dgvProductosTienda.CurrentRow.Cells[3].Value);

            //Muestra descrición del producto en el label de detalles.
            lblDescripcionProducto.Text = dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();

            //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
            this.auxFactura += auxProducto;

            //Muestra el total actual de la factura auxiliar con el producto agregado.
            lblTotalCarrito.Text = this.auxFactura.TotalCompra.ToString();
        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDescripcionProducto.Text = dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (this.dgvCarritoCliente.Rows.Count > 1 && this.dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
             {
                int id = Convert.ToInt32(this.dgvCarritoCliente.CurrentRow.Cells[0].Value);
               // Producto auxPorducto = TiendaDeElectronica.BuscarProductoPorId(id, Factura.Carrito);
                _ = auxFactura - id;
                this.lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
                dgvCarritoCliente.Rows.RemoveAt(dgvCarritoCliente.CurrentRow.Index);
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

        }

        private void btnVerVuelto_Click(object sender, EventArgs e)
        {
            double abonaCon;
            bool esNumero = double.TryParse(txtAbonacon.Text, out abonaCon);

            if (txtAbonacon.Text != null && esNumero)
            {
                //La propiedad "Vuelto" la tiene la facturaEfectivo, que se instanciará recién al terminar la venta,
                //Uso el método de esta clase (facturaEfectivo) para poder mostrarlo en el form de manera orientativa para el usuario.
                lblCalculoVuelto.Text = FacturaEfectivo.CalculoVuelto(auxFactura.TotalCompra, Convert.ToDouble(this.txtAbonacon.Text)).ToString();
                  
                if (Convert.ToInt32(lblTotalCarrito.Text) > Convert.ToInt32(txtAbonacon.Text))
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
            
            if (dgvCarritoCliente.Rows.Count > 1 && dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
            {
                Factura facturaFinal;
                foreach (Control item in grbFormaDePago.Controls)
                {
                    if (item is RadioButton)
                    {
                        if (rdoEfectivo.Checked)
                        {
                            double abonaCon;
                            bool esNumero = double.TryParse(txtAbonacon.Text, out abonaCon);

                            if (txtAbonacon.Text != null && esNumero && Convert.ToInt32(lblTotalCarrito.Text) < Convert.ToInt32(txtAbonacon.Text))
                            {
                                facturaFinal = new FacturaEfectivo(EMetodosDePago.efectivo, auxFactura.TotalCompra, 0,
                               Convert.ToDouble(txtAbonacon.Text));
                                MessageBox.Show(facturaFinal.ToString());
                                //Resetea la lista de la factura de la venta concretada y limpia dgv y labels.
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
                btnVerVuelto.PerformClick();
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
