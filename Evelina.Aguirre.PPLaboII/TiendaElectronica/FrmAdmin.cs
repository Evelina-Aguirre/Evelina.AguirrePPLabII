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
    public partial class FrmAdmin : Form
    {
        int m, mx, my;
        //Factura auxiliar a partir de la cual se instanciará una Factura-Efectivo/Debito/Crédito una vez elegido el método de pago.
        private FacturaDebito auxFactura = new FacturaDebito(EMetodosDePago.efectivo, 0);
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
            this.txtAbonacon.Text = TiendaDeElectronica.CuentaTienda.ToString();
            this.txtAbonacon.Enabled = false;
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

        /// <summary>
        /// Vuelve a cargar dgvCatalogoPorveeedor según categoría.
        /// </summary>
        /// <param name="categoria">Categoría con la que desea que se cargue</param>
        private void ActualizarDGVCatalago(ECategoriaElectronico categoria)
        {
            List<Producto> auxLista = new List<Producto>();
            auxLista = Producto.CargarProductosPorCategoria(categoria, CatalogoProveedor.Catalogo);
            if (dgvCatalogoProveedor.Rows.Count>0)
                dgvCatalogoProveedor.Rows.Clear();

            if (dgvCatalogoProveedor.Rows[0].Cells[0].Value is null  || dgvCatalogoProveedor.Rows.Count==0)
            {

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
            else
            {
                foreach (Producto item in auxLista)
                {
                    dgvCatalogoProveedor.Rows.Add(item.Nombre, item.Descripcion, item.Precio, item.Categoria, item.Id);
                }
            }


        }

        private void btnLeds_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Leds);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Leds, TiendaDeElectronica.InventarioTienda);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Bobinas);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Bobinas, TiendaDeElectronica.InventarioTienda);

        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Capacitores);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Capacitores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Conectores);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores, TiendaDeElectronica.InventarioTienda);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.CircuitosIntegrados);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados, TiendaDeElectronica.InventarioTienda);
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Plaquetas);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Plaquetas, TiendaDeElectronica.InventarioTienda);
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.ControlTermico);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico, TiendaDeElectronica.InventarioTienda);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Limpieza);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Limpieza, TiendaDeElectronica.InventarioTienda);
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Soldado);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Soldado, TiendaDeElectronica.InventarioTienda);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            ActualizarDGVCatalago(ECategoriaElectronico.Herramientas);
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Herramientas, TiendaDeElectronica.InventarioTienda);
        }

        private void dgvCatalogoProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instancia un producto para poder agregarlo a la factura.
            Producto auxProducto = new Producto(
              dgvCatalogoProveedor.CurrentRow.Cells[0].Value.ToString(), Convert.ToDouble(dgvCatalogoProveedor.CurrentRow.Cells[2].Value.ToString()),
               (int)Convert.ToInt32(dgvCatalogoProveedor.CurrentRow.Cells[4].Value), "",
               (ECategoriaElectronico)dgvCatalogoProveedor.CurrentRow.Cells[3].Value, 1);

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
            ECategoriaElectronico categoria = ECategoriaElectronico.SinCategoria;

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

                categoria = Producto.ObtenerCategoria(id);
            }
            dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(categoria, TiendaDeElectronica.InventarioTienda);

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

                string txtConComa = txtAbonacon.Text.Replace('.', ',');
                txtAbonacon.Text = txtConComa;
                int abonaCon;
                bool esNumero = int.TryParse(txtAbonacon.Text, out abonaCon);

                if (txtAbonacon.Text != null && esNumero && Convert.ToDouble(lblTotalCarrito.Text) < Convert.ToDouble(txtAbonacon.Text))
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

                    //Resto el total de la factura del saldo de la tienda.
                    TiendaDeElectronica.CuentaTienda -= facturaFinal.TotalCompra;

                    ECategoriaElectronico categoria = Producto.ObtenerCategoria(dgvCatalogoProveedor.Rows[0].Cells[3].Value.ToString());
                    dgvInventarioTienda.DataSource = Producto.CargarProductosPorCategoria(categoria, TiendaDeElectronica.InventarioTienda);
                    //Resetea la lista de la factura de la venta ya concretada y limpia dgv y labels.
                    Factura.Carrito.Clear();
                    auxFactura.TotalCompra = 0;
                    lblSaldoTienda.Text = TiendaDeElectronica.CuentaTienda.ToString();
                    txtAbonacon.Text = TiendaDeElectronica.CuentaTienda.ToString();
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
            Application.Exit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
                string nombre = "";
            string categoria = "";
            double precio = 0;
            if (dgvInventarioTienda.Rows.Count > 0)
            {
                id = Convert.ToInt32(dgvInventarioTienda.CurrentRow.Cells[5].Value);
                nombre = dgvInventarioTienda.CurrentRow.Cells[0].Value.ToString();
                categoria = dgvInventarioTienda.CurrentRow.Cells[4].Value.ToString();
                precio = Convert.ToDouble(dgvInventarioTienda.CurrentRow.Cells[2].Value);
                Modificar modificar = new Modificar(id, nombre, categoria, precio);
                modificar.Show();
            }

        }

        private void llbVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menú frmMenu = new Menú();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void dgvInventarioTienda_DoubleClick(object sender, EventArgs e)
        {
            this.btnModificar.PerformClick();
        }

        private void btnBuscarEnProveedor_Click(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            auxLista = Buscador.BuscarProducto(this.txtBuscarEnProveedor.Text.ToString().ToLower(), CatalogoProveedor.Catalogo);
            if (dgvCatalogoProveedor.Rows[0].Cells[0].Value is null || dgvCatalogoProveedor is null)
            {

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
            else
            {
                this.dgvCatalogoProveedor.Rows.Clear();
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

        }

        private void btnBuscarEnInventarioTienda_Click(object sender, EventArgs e)
        {
           this.dgvInventarioTienda.DataSource = Buscador.BuscarProducto(this.txtBuscarInventarioTienda.Text.ToString().ToLower(), TiendaDeElectronica.InventarioTienda);
        }

        private void txtBuscarEnProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                this.btnBuscarEnProveedor.PerformClick();
            }
        }

        private void txtBuscarInventarioTienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                this.btnBuscarEnInventarioTienda.PerformClick();
            }

        }

        private void txtBuscarEnProveedor_Click(object sender, EventArgs e)
        {
            this.txtBuscarEnProveedor.Text = string.Empty;
        }

        private void txtBuscarInventarioTienda_Click(object sender, EventArgs e)
        {
            this.txtBuscarInventarioTienda.Text = string.Empty;
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
