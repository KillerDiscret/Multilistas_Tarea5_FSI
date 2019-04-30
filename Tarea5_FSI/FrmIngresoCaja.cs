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
    public partial class FrmIngresoCaja : Form
    {
        Control objcontrol = new Control();

        public FrmIngresoCaja()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtBoxCodCaja.Text!=""&&txtBoxNombreCaja.Text!="")
            {
                if(objcontrol.CajaExiste(txtBoxCodCaja.Text)==false)
                {

                    Caja aux = new Caja();
                    aux.Codigo = txtBoxCodCaja.Text;
                    aux.Nombre = txtBoxNombreCaja.Text;
                    objcontrol.CrearCaja(aux);
                }
                else
                {
                    MessageBox.Show("¡El código ya existe!");
                }
                txtBoxCodCaja.Clear();
                txtBoxNombreCaja.Clear();
                txtBoxCodCaja.Focus();
            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }
            
        }

        private void btnSalirCaja_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
