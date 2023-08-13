using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Por favor, ingrese una palabra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedUppercase = new string(charArray).ToUpper();

            textBoxResult.Text = reversedUppercase;
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
                errorProvider.SetError(textBoxInput, "Solo se permiten letras.");
            }
            else
            {
                errorProvider.Clear();
            }

        }
    }
}

