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
    public partial class FrmIngresoCompra : Form
    {
        Control objcontrol = new Control();
        public FrmIngresoCompra()
        {
            InitializeComponent();
        }

        private void FrmIngresoCompra_Load(object sender, EventArgs e)
        {
            lboxcajas.DisplayMember = "Nombre";
            lboxcajas.ValueMember = "Codigo";
            lboxcajas.DataSource = Control.Cajas;
            lboxcajas.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtBoxDNI.Text!=""&&txtBoxMonto.Text!=""&&txtBoxDia.Text!=""&&txtBoxMes.Text!=""&&txtBoxYear.Text!=""&&lboxcajas.SelectedIndex!=-1)
            {
                Compra objcompra = new Compra();
                objcompra.DNI = Convert.ToInt32(txtBoxDNI.Text);
                objcompra.Monto = Convert.ToDouble(txtBoxMonto.Text);
                DateTime auxfecha = new DateTime(Convert.ToInt32(txtBoxYear.Text), Convert.ToInt32(txtBoxMes.Text), Convert.ToInt32(txtBoxDia.Text));
                objcompra.Fecha = auxfecha;
                Caja objcaja = new Caja();
                objcaja = (Caja)lboxcajas.SelectedItem;
                objcontrol.InsertarCompraEnCaja(objcaja.Codigo, objcompra);
                txtBoxDNI.Clear();
                txtBoxMes.Clear();
                txtBoxYear.Clear();
                txtBoxDia.Clear();
                txtBoxMonto.Clear();
                lboxcajas.SelectedIndex = -1;
                txtBoxDNI.Focus();

            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
