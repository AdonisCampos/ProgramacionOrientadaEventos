using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Numero_primo : Form
    {
        public Numero_primo()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            //Ejercicio 2 Crear un programa que permita determinar
            //si el número ingresado por el usuario es un número primo

            //variable
            int numero_ingresado = int.Parse(txtnumero.Text);
           

            if (EsNumeroPrimo(numero_ingresado))
            {
                lblresutado.Text = "El numero " + numero_ingresado +" Si es un numero primo";
            }
            else
            {
                lblresutado.Text = "El numero " + numero_ingresado + " No es un numero primo";
            }
        }
        //verficar numero
        private bool EsNumeroPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            if (numero <= 3)
                return true;

            if (numero % 2 == 0 || numero % 3 == 0)
                return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        // hacer que solo se puedan ingresar numeros en la caja de texto
        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

