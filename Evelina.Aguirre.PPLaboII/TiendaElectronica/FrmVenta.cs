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
        List<Producto> auxListaCarrito = new List<Producto>();
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

            //Carga descipción producto
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
            //Calcula total a medida que se agregan los productos
            this.lblTotalCarrito.Text =TiendaElectronica.CalculaTotal((double)Convert.ToInt32(this.lblTotalCarrito.Text),
                (double)Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[3].Value),'+').ToString();
        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que el form inicie con las columnas correspondientes pero sin datos.
            this.dgvProductosTienda.DataSource = auxLista;
            this.dgvCarritoCliente.DataSource = auxLista;
            this.lblTotalCarrito.Text = "0";
            this.lblTotalCarrito.Text = "0";
            this.lblCalculoVuelto.Text = "0";
            this.rdoEfectivo.Checked = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Limpieza);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Soldado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.Herramientas);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.dgvCarritoCliente.Rows.Count>1 && this.dgvCarritoCliente.CurrentRow.Cells[0].Value is not null)
            {
                this.lblTotalCarrito.Text = TiendaElectronica.CalculaTotal((double)Convert.ToInt32(this.lblTotalCarrito.Text),
                    (double)Convert.ToInt32(this.dgvCarritoCliente.CurrentRow.Cells[1].Value),'-').ToString();
                this.dgvCarritoCliente.Rows.RemoveAt(dgvCarritoCliente.CurrentRow.Index);
            }
        }

        private void rdoDebiro_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAbonacon.Enabled = false;
            this.txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.btnVerVuelto.Enabled = false;
            this.lblCalculoVuelto.Text = "-";
            this.txtAbonacon.Text = this.lblTotalCarrito.Text;
        
        }

        private void rdoCredito_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAbonacon.Enabled = false;
            this.txtAbonacon.BackColor = Color.FromArgb(185, 185, 185);
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.btnVerVuelto.Enabled = false;
            this.lblCalculoVuelto.Text = "-";
            this.txtAbonacon.Text = this.lblTotalCarrito.Text;
        }

        private void btnVerVuelto_Click(object sender, EventArgs e)
        {
            double abonaCon;
            bool esNumero = double.TryParse(this.txtAbonacon.Text, out abonaCon);
         
            if(this.txtAbonacon.Text != null && esNumero)
            {
                this.lblCalculoVuelto.Text = TiendaElectronica.CalculoVuelto((double)Convert.ToInt32(this.lblTotalCarrito.Text),
                    (double)Convert.ToInt32(this.txtAbonacon.Text)).ToString();
                if(Convert.ToInt32(this.lblTotalCarrito.Text) > Convert.ToInt32(this.txtAbonacon.Text))
                {
                    this.lblMontoInsuficiente.Text = "Monto insuficiente";
                    this.timer1.Interval = 3000;
                    this.timer1.Start();
                }
            }
            else if(this.txtAbonacon.Text == null || ! esNumero)
            {
                this.lblCalculoVuelto.Text = "-";
                this.lblMontoInsuficiente.Text = "Debe ingresar un valor numérico";
                this.timer1.Interval = 3000;
                this.timer1.Start();
                
            }
            
            
        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAbonacon.BackColor = Color.White;
            this.txtAbonacon.BorderStyle = BorderStyle.FixedSingle;
            this.txtAbonacon.Enabled = true;
            this.btnVerVuelto.Enabled = true;

        }

        private void txtAbonacon_Click(object sender, EventArgs e)
        {
            this.txtAbonacon.Text = string.Empty;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblMontoInsuficiente.Text = "";
            timer1.Stop();
        }

        private void txtBuscat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox) ya fue manejado;
                e.Handled = true;
                this.btnVerVuelto.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxFormaDePago;
            foreach (RadioButton item in this.grbFormaDePago.Controls)
            {
                if (this.rdoEfectivo.Checked)
                {
                    auxFormaDePago = "Efectivo";
                }
                else if(this.rdoCredito.Checked)
                {
                    auxFormaDePago = "Credito";
                }
                else if (this.rdoDebiro.Checked)
                {
                    auxFormaDePago = "Debito";
                }
                MessageBox.Show();//Y acá tengo que llamar algún método que me muestre losdetalles de la compra / factura

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

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            this.dgvProductosTienda.DataSource = Producto.CargarDataPorCategoria(ECategoriaElectronico.ControlTermico);
        }


        
    }
}
