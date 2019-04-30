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
    public partial class ObtenerCajaMasCompras : Form
    {
        Control objcontrol = new Control();

        public ObtenerCajaMasCompras()
        {
            InitializeComponent();
        }

        private void ObtenerCajaMasCompras_Load(object sender, EventArgs e)
        {
            Caja aux = objcontrol.Caja_Mayor();
            listBoxCaja.Items.Add(aux.Nombre);
            listBoxCompras.DisplayMember = "DNI";
            listBoxCompras.ValueMember = "Codigo";
            listBoxCompras.DataSource = aux.Compras;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
