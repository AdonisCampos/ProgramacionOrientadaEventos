using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Restriccion : Form
    {
        public Restriccion()
        {
            InitializeComponent();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ejercicio 3 
            //Crear un programa que solamente permita al usuario
            //ingresar números, la tecla BORRAR y la tecla ESPACIO

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 

                MessageBox.Show("Solo se permite números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
