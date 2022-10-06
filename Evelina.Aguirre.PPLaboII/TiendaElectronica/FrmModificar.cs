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
    public partial class FrmModificar : Form
    {
        private int id;

        public FrmModificar(int id)
        {
            this.id = id;
        }

        public FrmModificar()
        {
            InitializeComponent();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }


        //int id = Convert.ToInt32(this.dgvInventarioTienda.CurrentRow.Cells[5].Value);

        //    foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
        //    {
        //        if(id = item.Value.Id)
        //        {

        //        }
        //    }



    }
}
