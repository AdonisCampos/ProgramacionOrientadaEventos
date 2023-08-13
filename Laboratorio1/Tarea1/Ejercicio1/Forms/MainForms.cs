using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircleLibrary;

namespace Ejercicio1.Forms
{
    public partial class MainForms : Form
    {
        private Circle circle;
        public MainForms()
        {
            InitializeComponent();
            circle = new Circle();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                circle.Radius = Convert.ToDouble(txtRadius.Text);
                double area = circle.CalculateArea();
                double perimeter = circle.CalculatePerimeter();

                txtResult.Text = $"Area: {area:F2} \r\nPerimetro: {perimeter:F2}";
            }
        }

        private bool ValidateInput()
        {
            if (!double.TryParse(txtRadius.Text, out _))
            {
                MessageBox.Show("Introduzca un radio numérico válido.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadius.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtResult.Clear();
            txtRadius.Focus();
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

            if (!double.TryParse(txtRadius.Text, out _))
            {
                errorProviderRadio.SetError(txtRadius, "Debe ingresar un valor numérico.");
            }
            else
            {
                errorProviderRadio.Clear();
            }
        }


    }
}

