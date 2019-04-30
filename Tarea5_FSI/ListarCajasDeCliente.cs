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
    public partial class ListarCajasDeCliente : Form
    {
        Control objcontrol = new Control();
        public ListarCajasDeCliente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarCajasDeCliente_Load(object sender, EventArgs e)
        {
            listBoxDNI.DisplayMember = "DNI";
            listBoxDNI.ValueMember = "Monto";
            listBoxDNI.DataSource = Control.ListaCompras;
            Compra auxobj = (Compra)listBoxDNI.SelectedItem;
            listBoxCodigo.Items.Clear();
            List<Caja> auxlist = new List<Caja>();
            auxlist = objcontrol.ListarCajasDeCliente(auxobj);
            listBoxCodigo.DisplayMember = "Codigo";
            listBoxCodigo.ValueMember = "Nombre";
            listBoxCodigo.DataSource = auxlist;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
