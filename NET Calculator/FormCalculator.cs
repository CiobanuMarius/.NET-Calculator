using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonScadere_Click(object sender, EventArgs e)
        {

            // Defined Substract Operation

            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 - termen2;
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {

            // Defined Multiply Operation

            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 * termen2;
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {

            // Defined Divide Operation
            // Added try-catch Statement for the "Divide by 0 exception"

            try
            {
                decimal termen1 = numericUpDownTermen1.Value;
                decimal termen2 = numericUpDownTermen2.Value;

                decimal rezultat = termen1 / termen2;
                textBoxRezultat.Text = rezultat.ToString();
            }

            // Output for "Divide by 0 exception" error message

            catch (DivideByZeroException)

            {
                string rezultat_error = "ACCORDING TO SCIENCE, WE CANNOT DIVIDE BY 0 !";
                textBoxRezultat.Text = rezultat_error.ToString();

            }

        }

        // MessageBox asking if the user wants to close the Calculator
        private void FormCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Close CALCULATOR ?", "PLEASE SAVE RESULT BEFORE CLOSING !", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }    
            else 
            {
                e.Cancel = true;
            }
        }
    }
}
