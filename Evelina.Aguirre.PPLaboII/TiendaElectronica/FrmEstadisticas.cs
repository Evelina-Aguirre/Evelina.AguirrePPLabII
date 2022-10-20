using Entidades.Tienda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.lblCantidadVentasRealizadas.Text = Estadisticas.CantidadVentas.ToString();
            this.lblMasVendidoPorCategoria.Text = "Elija una categoría";
            this.lblPromedioGananciasCategoria.Text = "Elija una categoría";
            this.lblGananciasTotal.Text = Estadisticas.GananciaAcumulada.ToString();
        }

        private void btnLeds_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Leds).ToString();
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Leds).ToString();
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Bobinas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Bobinas).ToString();
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Conectores).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Conectores).ToString();
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.CircuitosIntegrados).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.CircuitosIntegrados).ToString();
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Plaquetas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Plaquetas).ToString();
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.ControlTermico).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.ControlTermico).ToString();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Limpieza).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Limpieza).ToString();
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Soldado).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Soldado).ToString();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = "";
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Herramientas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Herramientas).ToString();
        }


        private void llbVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                this.lblPromedioGananciasCategoria.Text = "";
                Prueba frmPruebaApp = new Prueba();
                this.Hide();
                frmPruebaApp.ShowDialog();
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
    }
}
