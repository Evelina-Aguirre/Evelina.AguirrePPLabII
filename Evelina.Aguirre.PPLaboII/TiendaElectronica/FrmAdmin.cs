using Entidades;
using Entidades.Tienda;
using Entidades.TiendaElectronica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
            dgvCatalogoProveedor.ColumnCount = 5;
            dgvCatalogoProveedor.Columns[0].Name = "Nombre";
            dgvCatalogoProveedor.Columns[1].Name = "Descripción";
            dgvCatalogoProveedor.Columns[2].Name = "Precio";
            dgvCatalogoProveedor.Columns[3].Name = "Categoria";
            dgvCatalogoProveedor.Columns[4].Name = "Id";

            List<Producto> cargaColumnasDgv = new List<Producto>();
            dgvInventarioTienda.DataSource = cargaColumnasDgv;
            dgvCarrito.ColumnCount = 4;
            dgvCarrito.Columns[0].Name = "Id";
            dgvCarrito.Columns[1].Name = "Producto";
            dgvCarrito.Columns[2].Name = "Precio";
            dgvCarrito.Columns[3].Name = "Cantidad";

            rdoEfectivo.Checked = true;
            txtAbonacon.Text = TiendaDeElectronica.CuentaTienda.ToString();
            lblSaldoTienda.Text = TiendaDeElectronica.CuentaTienda.ToString();
        }


        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lblCuotasAbonaCon.Location = new System.Drawing.Point(156, 25);
            lblCuotasAbonaCon.Text = "Abona con";
            btnVerVuelto.Visible = true;
            btnVerVuelto.Enabled = false;
            lblMontoInsuficiente.Visible = true;
            txtAbonacon.Text = "";
            txtAbonacon.BackColor = Color.White;
            txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            txtAbonacon.Enabled = true;
        }


        private void btnLeds_Click(object sender, EventArgs e)
        {
            if (this.dgvCatalogoProveedor.Rows[0].Cells[0].Value is null)
            {
                List<Producto> auxLista = new List<Producto>();
                auxLista = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, CatalogoProveedor.Catalogo);

                dgvCatalogoProveedor.ColumnCount = 5;
                dgvCatalogoProveedor.Columns[0].Name = "Nombre";
                dgvCatalogoProveedor.Columns[1].Name = "Descripción";
                dgvCatalogoProveedor.Columns[2].Name = "Precio";
                dgvCatalogoProveedor.Columns[3].Name = "Categoria";
                dgvCatalogoProveedor.Columns[3].Name = "Id";

                foreach (Producto item in auxLista)
                {
                    dgvCatalogoProveedor.Rows.Add(item.Nombre, item.Descripcion, item.Precio, item.Categoria, item.Id);
                }

            }
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, TiendaDeElectronica.InventarioTienda);

        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, TiendaDeElectronica.InventarioTienda);
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico, TiendaDeElectronica.InventarioTienda);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, TiendaDeElectronica.InventarioTienda);
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, TiendaDeElectronica.InventarioTienda);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            dgvCatalogoProveedor.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, CatalogoProveedor.Catalogo);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, TiendaDeElectronica.InventarioTienda);
        }

        private void dgvCatalogoProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instancia un producto para poder agregarlo a la factura.
            Producto auxProducto = new Producto(
              dgvCatalogoProveedor.CurrentRow.Cells[0].Value.ToString(),
               1, Convert.ToDouble(dgvCatalogoProveedor.CurrentRow.Cells[2].Value.ToString()),
               (int)Convert.ToInt32(dgvCatalogoProveedor.CurrentRow.Cells[4].Value), "",
               (ECategoriaElectronico)dgvCatalogoProveedor.CurrentRow.Cells[3].Value);

            //Vista previa del producto agregador al dgv de los productos a vender.
            int cantidad = 1;
            int existe = -1;

            if (dgvCarrito.Rows.Count > 1 && dgvCarrito.Rows[0].Cells[0].Value is not null)
            {
                foreach (DataGridViewRow row in dgvCarrito.Rows)
                {
                    if (Convert.ToInt32(dgvCatalogoProveedor.CurrentRow.Cells[4].Value) == Convert.ToInt32(row.Cells[0].Value))
                    {
                        existe = row.Index;
                    }
                }
            }

            if (existe > -1)
            {
                cantidad = Convert.ToInt32(dgvCarrito.Rows[existe].Cells[3].Value);
                cantidad++;
                dgvCarrito.Rows[existe].Cells[3].Value = cantidad;
                dgvCarrito.Rows[existe].Cells[2].Value = Convert.ToInt32(dgvCatalogoProveedor.CurrentRow.Cells[2].Value) * cantidad;
            }
            else
            {
                dgvCarrito.Rows.Add(dgvCatalogoProveedor.CurrentRow.Cells[4].Value, dgvCatalogoProveedor.CurrentRow.Cells[0].Value,
                dgvCatalogoProveedor.CurrentRow.Cells[2].Value, cantidad);
            }

            //Agrega el producto a la lista de la factura y suma el precio del mismo al total.
            auxFactura += auxProducto;

            //Muestra el total actual de la factura auxiliar con el producto agregado.
            lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
        }

        private void llbRemover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvCarrito.Rows.Count > 1 && dgvCarrito.CurrentRow.Cells[0].Value is not null)
            {
                int id = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[0].Value);
                _ = auxFactura - id;
                lblTotalCarrito.Text = auxFactura.TotalCompra.ToString();
                if (Convert.ToInt32(dgvCarrito.CurrentRow.Cells[3].Value) == 1)
                {
                    dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
                }
                else
                {
                    int aux = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[3].Value);
                    aux--;
                    dgvCarrito.CurrentRow.Cells[3].Value = aux;
                }
            }
        }

        private void txtAbonacon_Click(object sender, EventArgs e)
        {
            txtAbonacon.Text = string.Empty;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count > 1 && dgvCarrito.CurrentRow.Cells[0].Value is not null)
            {
                Factura facturaFinal;
                TiendaDeElectronica tienda = new TiendaDeElectronica();

                int abonaCon;
                bool esNumero = int.TryParse(txtAbonacon.Text, out abonaCon);

                if (txtAbonacon.Text != null && esNumero && Convert.ToInt32(lblTotalCarrito.Text) < Convert.ToInt32(txtAbonacon.Text))
                {
                    facturaFinal = new FacturaEfectivo(EMetodosDePago.efectivo, auxFactura.TotalCompra, 0,
                   Convert.ToDouble(txtAbonacon.Text));
                    MessageBox.Show(facturaFinal.ToString());
                    foreach (DataGridViewRow row in dgvCarrito.Rows)
                    {
                        if (row.Cells[0].Value is not null)
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            int cantidadDeUnProducto = Convert.ToInt32(row.Cells[3].Value);
                            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                            {
                                if (item.Value.Id == id)
                                {
                                    for (int i = 0; i < cantidadDeUnProducto; i++)
                                    {
                                        item.Value.Cantidad++;
                                    }
                                }
                            }
                        }
                    }
                    //Resetea la lista de la factura de la venta ya concretada y limpia dgv y labels.
                    Factura.Carrito.Clear();
                    auxFactura.TotalCompra = 0;
                    lblTotalCarrito.Text = string.Empty;
                    dgvCarrito.Rows.Clear();
                    rdoEfectivo.Checked = true;

                }
                else
                {   //El Botón ver vuelto ya setea qué acciones tomar en caso de que el monto sea insuficiente o inválido.
                    VerificaMontoSuficiente();
                }
            }
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void FrmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void txtAbonacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnVender.PerformClick();
            }
        }

        private void VerificaMontoSuficiente()
        {
            float abonaCon;
            bool esNumero = float.TryParse(txtAbonacon.Text, out abonaCon);

            if (txtAbonacon.Text != null && esNumero)
            {
                if (float.Parse(lblTotalCarrito.Text) > float.Parse(txtAbonacon.Text))
                {
                    lblMontoInsuficiente.Text = "Monto insuficiente";
                    timer1.Interval = 3000;
                    timer1.Start();
                }
            }
            else if (txtAbonacon.Text == null || !esNumero)
            {
                lblMontoInsuficiente.Text = "Debe ingresar un valor numérico";
                timer1.Interval = 3000;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMontoInsuficiente.Text = "";
            timer1.Stop();
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
