using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Tienda;
using Entidades.TiendaElectronica;

namespace UITiendaElectronica
{
    public partial class FrmAdmin : Form
    {
        int m, mx, my;
        //Factura auxiliar a partir de la cual se instanciará una Factura-Efectivo/Debito/Crédito una vez elegido el método de pago.
        private Factura auxFactura = new Factura(EMetodosDePago.efectivo, 0);
        public FrmAdmin()
        {
            InitializeComponent();
        }


        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            List<Producto> cargaColumnasDgv = new List<Producto>();
            this.dgvCatalogoProveedor.DataSource = cargaColumnasDgv;
            this.dgvInventarioTienda.DataSource = cargaColumnasDgv;
            this.dgvCarrito.ColumnCount = 3;
            this.dgvCarrito.Columns[0].Name = "Id";
            this.dgvCarrito.Columns[1].Name = "Producto";
            this.dgvCarrito.Columns[2].Name = "Precio";
            this.rdoEfectivo.Checked = true;
            this.cmbCuotas.Visible = false;
            this.lblSaldoTienda.Text = TiendaDeElectronica.CuentaTienda.ToString();
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

        private void btnLeds_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, TiendaDeElectronica.InventarioTienda);

        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, TiendaDeElectronica.InventarioTienda);
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico, TiendaDeElectronica.InventarioTienda);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, TiendaDeElectronica.InventarioTienda);
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, TiendaDeElectronica.InventarioTienda);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            this.dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, CatalogoProveedor.Catalogo);
            this.dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, TiendaDeElectronica.InventarioTienda);
        }

        private void dgvCatalogoProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instancia un producto para poder agregarlo a la factura.
            Producto auxProducto = new Producto(
              this.dgvCatalogoProveedor.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32(this.dgvCatalogoProveedor.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32(this.dgvCatalogoProveedor.CurrentRow.Cells[3].Value.ToString()),
               (short)Convert.ToInt32(this.dgvCatalogoProveedor.CurrentRow.Cells[0].Value), "",
               (ECategoriaElectronico)this.dgvCatalogoProveedor.CurrentRow.Cells[5].Value);

            //Vista previa del producto agregador al dgv de los productos a vender.
            this.dgvCarrito.Rows.Add(this.dgvCatalogoProveedor.CurrentRow.Cells[0].Value, this.dgvCatalogoProveedor.CurrentRow.Cells[1].Value,
                dgvCatalogoProveedor.CurrentRow.Cells[3].Value);

            //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
            this.auxFactura += auxProducto;

            //Muestra el total actual de la factura auxiliar con el producto agregado.
            this.lblTotalCarrito.Text = this.auxFactura.TotalCompra.ToString();
        }

        private void llbRemover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.dgvCarrito.Rows.Count > 1 && this.dgvCarrito.CurrentRow.Cells[0].Value is not null)
            {
                int id = Convert.ToInt32(this.dgvCarrito.CurrentRow.Cells[0].Value);
                _ = auxFactura - id;
                this.lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
                dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
            }
        }

        private void txtAbonacon_Click(object sender, EventArgs e)
        {
            this.txtAbonacon.Text = string.Empty;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.dgvCarrito.Rows.Count > 1 && this.dgvCarrito.CurrentRow.Cells[0].Value is not null)
            {
                Factura facturaFinal;
                foreach (Control item in this.grbFormaDePago.Controls)
                {
                    if (item is RadioButton)
                    {
                        if (this.rdoEfectivo.Checked)
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
                                this.dgvCarrito.Rows.Clear();
                                this.rdoEfectivo.Checked = true;

                            }
                            else
                            {   //El Botón ver vuelto ya setea qué acciones tomar en caso de que el monto sea insuficiente o inválido.
                                this.VerificaMontoSuficiente();
                            }


                        }
                        else if (rdoCredito.Checked)
                        {
                            facturaFinal = new FacturaCredito(EMetodosDePago.Credito, Convert.ToDouble(lblTotalCarrito.Text),
                                 Convert.ToInt32(cmbCuotas.SelectedItem.ToString()));
                            MessageBox.Show(facturaFinal.ToString());
                            //Resetea la lista de la factura de la venta concretada y limpia dgv y labels.
                            Factura.Carrito.Clear();
                            this.lblTotalCarrito.Text = string.Empty;
                            this.dgvCarrito.Rows.Clear();
                            this.rdoEfectivo.Checked = true;
                        }
                        else if (rdoDebiro.Checked)
                        {
                            facturaFinal = new FacturaDebito(EMetodosDePago.Debito, Convert.ToDouble(lblTotalCarrito.Text));
                            MessageBox.Show(facturaFinal.ToString());
                            //Resetea la lista de la factura de la venta concretada y limpia dgv y labels. 
                            Factura.Carrito.Clear();
                            this.lblTotalCarrito.Text = string.Empty;
                            this.dgvCarrito.Rows.Clear();
                            this.rdoEfectivo.Checked = true;
                        }
                        break;

                    }

                }
            }
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void FrmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void txtAbonacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                VerificaMontoSuficiente();
            }
        }

        private void VerificaMontoSuficiente()
        {
            float abonaCon;
            bool esNumero = float.TryParse(this.txtAbonacon.Text, out abonaCon);

            if (this.txtAbonacon.Text != null && esNumero)
            {
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblMontoInsuficiente.Text = "";
            this.timer1.Stop();
        }

        private void FrmAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        private void FrmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
