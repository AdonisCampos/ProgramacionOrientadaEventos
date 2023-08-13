using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            errorProvider.SetIconAlignment(textBoxNumber, ErrorIconAlignment.MiddleRight);
        }

        private void CheckDivisibilityButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsValidNumberInput(textBoxNumber.Text))
            {
                int number = int.Parse(textBoxNumber.Text);

                if (number % 15 == 0)
                {
                    MessageBox.Show("El número es divisible entre 15.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El número no es divisible entre 15.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool IsValidNumberInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                errorProvider.SetError(textBoxNumber, "Ingrese un número.");
                return false;
            }

            if (!int.TryParse(input, out _))
            {
                errorProvider.SetError(textBoxNumber, "Ingrese un número válido.");
                return false;
            }

            return true;
        }

    }
}

