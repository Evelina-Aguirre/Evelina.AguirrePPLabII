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
            this.Close();
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
