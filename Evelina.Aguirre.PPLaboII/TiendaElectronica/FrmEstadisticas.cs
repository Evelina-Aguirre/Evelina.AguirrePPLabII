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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Leds), 2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Bobinas),2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Conectores),2).ToString();
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
                lblPromedioGananciasCategoria.Text =Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.CircuitosIntegrados),2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Plaquetas), 2).ToString();
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

                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.ControlTermico), 2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Limpieza),2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Soldado),2).ToString();
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
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Herramientas),2).ToString();
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
