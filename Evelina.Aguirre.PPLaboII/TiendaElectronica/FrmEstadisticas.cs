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
            this.lblMasVendidoPorCategoria.Text = "No se ralizaron ventas en esta categoría";
            this.lblPromedioGananciasCategoria.Text = "No se realizaron ventas en esta categoría";
        }

        private void btnLeds_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Leds).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Leds).ToString();
        }

        private void btnBobinas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Bobinas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Bobinas).ToString();
        }

        private void btnConectores_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Conectores).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Conectores).ToString();
        }

        private void btnCircuitosIntegrados_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.CircuitosIntegrados).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.CircuitosIntegrados).ToString();
        }

        private void btnPlaquetas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Plaquetas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Plaquetas).ToString();
        }

        private void btnControlTermico_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.ControlTermico).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.ControlTermico).ToString();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Limpieza).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Limpieza).ToString();
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Soldado).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Soldado).ToString();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            this.lblPromedioGananciasCategoria.Text = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Herramientas).ToString();
            this.lblMasVendidoPorCategoria.Text = Estadisticas.ProductoMasVendido(ECategoriaElectronico.Herramientas).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba frmPruebaApp = new Prueba();
            this.Hide();
            frmPruebaApp.ShowDialog();
        }
    }
}
