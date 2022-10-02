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

        private void btnConectores_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.Conectores);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.CircuitosIntegrados);
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

            this.dgvCarritoCliente.ColumnCount = 2;
            this.dgvCarritoCliente.Columns[0].Name = "Producto";
            this.dgvCarritoCliente.Columns[1].Name = "Precio";

            dgvCarritoCliente.Rows.Add(this.dgvProductosTienda.CurrentRow.Cells[1].Value, this.dgvProductosTienda.CurrentRow.Cells[3].Value);

           
            //Carga descipción producto
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
            //Calcula total a medida que se agregan los productos
            this.lblTotalCarrito.Text =TiendaElectronica.CalculaTotal((double)Convert.ToInt32(this.lblTotalCarrito.Text),
                (double)Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[3].Value),'+').ToString();

            
            Producto auxProducto = new Producto(
               this.dgvProductosTienda.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[3].Value.ToString()),
               (short)Convert.ToInt32(this.dgvProductosTienda.CurrentRow.Cells[0].Value), "",
               (ECategoriaElectronico)this.dgvProductosTienda.CurrentRow.Cells[5].Value);

               auxListaCarrito.Add(auxProducto);
        }

        private void dgvProductosTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblDescripcionProducto.Text = this.dgvProductosTienda.CurrentRow.Cells[4].Value.ToString();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            this.dgvCarritoCliente.ColumnCount = 2;
            this.dgvCarritoCliente.Columns[0].Name = "Producto";
            this.dgvCarritoCliente.Columns[1].Name = "Precio";
            List<Producto> auxLista = new List<Producto>();
            //Asigno una lista de Productos vacía para que el form inicie con las columnas correspondientes a un producto pero sin datos.
            this.dgvProductosTienda.DataSource = auxLista;
            this.lblTotalCarrito.Text = "0";
            this.lblTotalCarrito.Text = "0";
            this.lblCalculoVuelto.Text = "0";
            this.rdoEfectivo.Checked = true;
            this.cmbCuotas.Visible = false;
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
            this.txtAbonacon.Text = this.lblTotalCarrito.Text;
        
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
            this.txtAbonacon.Text = this.lblTotalCarrito.Text;

            this.cmbCuotas.Visible = true;
            this.cmbCuotas.SelectedItem = 0;

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
            Factura factura;
            foreach (Control item in this.grbFormaDePago.Controls)
            {
                if (item is RadioButton)
                {
                    if (this.rdoEfectivo.Checked)
                    {
                        factura = new Factura(auxListaCarrito, EMetodosDePago.efectivo, Convert.ToDouble(this.lblTotalCarrito.Text.ToString()),
                           Convert.ToDouble(this.txtAbonacon.Text.ToString()), Convert.ToDouble(this.lblVuelto.Text.ToString()));
                    }
                    else if (this.rdoCredito.Checked)
                    {

                        factura = new Factura(auxListaCarrito, EMetodosDePago.Credito, Convert.ToDouble(this.lblTotalCarrito.Text),
                            Convert.ToInt32(this.txtAbonacon.Text), Convert.ToInt32(this.cmbCuotas.SelectedValue.ToString()));
                    }
                    else if (this.rdoDebiro.Checked)
                    {
                        factura = new Factura(auxListaCarrito, EMetodosDePago.Debito, Convert.ToDouble(this.lblTotalCarrito.Text));
                    }

                }
                //MessageBox.Show();//Y acá tengo que llamar algún método que me muestre los detalles de la compra / factura

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
            this.dgvProductosTienda.DataSource = Producto.CargarProductosPorCategoria(ECategoriaElectronico.ControlTermico);
        }


        
    }
}
