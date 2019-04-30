using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_FSI
{
    public partial class FrmListarComprasDeCaja : Form
    {
        public FrmListarComprasDeCaja()
        {
            InitializeComponent();
        }

        private void FrmListarComprasDeCaja_Load(object sender, EventArgs e)
        {
            lBoxCajas.DisplayMember = "Nombre";
            lBoxCajas.ValueMember = "Codigo";
            lBoxCajas.DataSource = Control.Cajas;
        }

        private void lBoxCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caja objcaja = (Caja)lBoxCajas.SelectedItem;
            lBoxCompras.DisplayMember = "DNI";
            lBoxCompras.ValueMember = "Monto";
            lBoxCompras.DataSource = objcaja.Compras;
            lBoxMonto.DisplayMember = "Monto";
            lBoxMonto.ValueMember = "DNI";
            lBoxMonto.DataSource = objcaja.Compras;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
