using Entidades;
using Entidades.ExcepcionesPropias;
using Entidades.Tienda;
using System;
using System.Windows.Forms;

namespace UITiendaElectronica
{
    public partial class FrmEstadisticas : Form
    {
        int m, mx, my;
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
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Leds);
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Bobinas);
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Conectores);
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.CircuitosIntegrados);
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Plaquetas);
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.ControlTermico);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Limpieza);
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Soldado);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Herramientas);

        }

        private void btnCapacitores_Click(object sender, EventArgs e)
        {
            CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico.Capacitores);
        }

        private void CompletaCampoSegúnVendidosPorCategoria(ECategoriaElectronico categoria)
        {
            try
            {
                lblPromedioGananciasCategoria.Text = Math.Round(Estadisticas.PromedioVentasProducto(categoria), 2).ToString();
                lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(categoria).ToString();
                this.rhtDetalle.Text = Estadisticas.Mostrar(categoria);
                this.lblCantidadVendida.Text = Estadisticas.CantidadProdMasVendido.ToString();
            }
            catch (ListaVaciaException ex)
            {
                lblPromedioGananciasCategoria.Text = ex.Message;
                lblMasVendidoPorCategoria.Text = ex.Message;
                this.lblCantidadVendida.Text = ex.Message;
                this.rhtDetalle.Text = ex.Message + " en esta categoría .-"; 
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

        private void FrmEstadisticas_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void FrmEstadisticas_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void FrmEstadisticas_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }



    }
}
