using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UITiendaElectronica
{
    public partial class Venta : Form
    {
        int m, mx, my;
        public Venta()
        {
            InitializeComponent();
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {

        }

        private void btnLeds_Click(object sender, EventArgs e)
        {
            
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Leds);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Bobinas);
        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Capacitores);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Conectores);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.CircuitosIntegrados);
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
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvProductosTienda.DataSource = TiendaElectronica.BuscarProductoPorNombre(this.txtBuscat.Text.ToString().ToLower());
        }

        private void txtBuscat_Click(object sender, EventArgs e)
        {
            this.txtBuscat.Text = string.Empty;
            dgvProductosTienda.DataSource = null;
        }

        private void txtBuscat_Enter(object sender, EventArgs e)
        {

        }

        private void dgvProductosTienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Producto> auxListaCarrito = new List<Producto>();
            //Producto auxProducto = new Producto(
            //   this.dgvProductosTienda.CurrentRow.Cells[1].Value.ToString(),
            //   Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[2].Value.ToString()),
            //   Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[3].Value.ToString()),
            //   (short)Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[0].Value), "",
            //   (ECategoriaElectronico)this.dgvProductosTienda.CurrentRow.Cells[5].Value);
            
            //auxListaCarrito.Add(auxProducto);

            this.dgvCarritoCliente.ColumnCount = 2;
            this.dgvCarritoCliente.Columns[0].Name = "Producto";
            this.dgvCarritoCliente.Columns[1].Name = "Precio";

            dgvCarritoCliente.Rows.Add(this.dgvProductosTienda.CurrentRow.Cells[1].Value, this.dgvProductosTienda.CurrentRow.Cells[3].Value);

            // Cliente auxCliente = new Cliente(auxListaCarrito, );//ME FALTA MÉTODO DE PAGO Y ABONA CON


            //dgCarrito.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio);
            //listaCarrito.Add(auxProducto);
            //lblTotal.Text = Tienda.SumarPrecioArticulosAgregados(listaCarrito).ToString();

            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Plaquetas);
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            auxLista.AddRange(Producto.CargarDataPorCategoria(ECategoriaElectronico.ControlTermico));
            auxLista.AddRange(Producto.CargarDataPorCategoria(ECategoriaElectronico.Limpieza));
            auxLista.AddRange( Producto.CargarDataPorCategoria(ECategoriaElectronico.Soldado));
            auxLista.AddRange(Producto.CargarDataPorCategoria(ECategoriaElectronico.Herramientas));
            dgvProductosTienda.DataSource = auxLista;
        }
    }
}
