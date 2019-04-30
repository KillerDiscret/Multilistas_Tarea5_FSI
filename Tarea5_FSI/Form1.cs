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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoCaja frm = new FrmIngresoCaja();
            frm.ShowDialog();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoCompra frm = new FrmIngresoCompra();
            frm.ShowDialog();
        }

        private void listarComprasDeUnaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarComprasDeCaja frm = new FrmListarComprasDeCaja();
            frm.ShowDialog();
        }

        private void obtenerCajaConMásComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerCajaMasCompras frm = new ObtenerCajaMasCompras();
            frm.ShowDialog();
        }

        private void listarCajasDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCajasDeCliente frm = new ListarCajasDeCliente();
            frm.ShowDialog();
        }
    }
}
