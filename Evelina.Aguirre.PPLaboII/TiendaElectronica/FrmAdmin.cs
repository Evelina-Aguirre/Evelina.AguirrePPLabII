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

namespace UITiendaElectronica
{
    public partial class FrmAdmin : Form
    {
        int m, mx, my;
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
