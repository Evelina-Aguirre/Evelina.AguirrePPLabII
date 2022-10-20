using Entidades;
using Entidades.ExcepcionesPropias;
using Entidades.Tienda;
using System;
using System.Windows.Forms;

namespace UITiendaElectronica
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            lblCantidadVentasRealizadas.Text = Estadisticas.CantidadVentas.ToString();
            lblMasVendidoPorCategoria.Text = "Elija una categoría";
            lblPromedioGananciasCategoria.Text = "Elija una categoría";
            lblGananciasTotal.Text = Estadisticas.GananciaAcumulada.ToString();
            this.lblSaldoTienda.Text = TiendaDeElectronica.CuentaTienda.ToString();
        }

        private void btnLeds_Click(object sender, EventArgs e)
        {
            try
            {
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Leds).ToString();
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Leds).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Bobinas).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Bobinas).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Conectores).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Conectores).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.CircuitosIntegrados).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.CircuitosIntegrados).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Plaquetas).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Plaquetas).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            try
            {

                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.ControlTermico).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.ControlTermico).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
            }
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Limpieza).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Limpieza).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Soldado).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Soldado).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Herramientas).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Herramientas).ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
            }

        }


        private void llbVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lblPromedioGananciasCategoria.Text = "";
            Prueba frmPruebaApp = new Prueba();
            Hide();
            frmPruebaApp.ShowDialog();

        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
