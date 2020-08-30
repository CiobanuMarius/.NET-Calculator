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
    public partial class FormHomepage : Form
    {
        FormAbout formAbout;
        FormCalculator formCalculator;

        public FormHomepage()
        {
            InitializeComponent();
            formAbout = new FormAbout();
            formAbout.Visible = false;
            formCalculator = new FormCalculator();
            formCalculator.Visible = false;
        }

        private void ButtonAboutForm_Click(object sender, EventArgs e)
        {
            if (formAbout.Visible == true)
                formAbout.Visible = false;
            if (formAbout.IsDisposed) formAbout = new FormAbout();
            else
                formAbout.Visible = true;
          

        }


        private void ButtonCalculatorForm_Click_1(object sender, EventArgs e)
        {
            if (formCalculator.Visible == true)
                formCalculator.Visible = false;
            if (formCalculator.IsDisposed) formCalculator = new FormCalculator();
            else
                formCalculator.Visible = true;

        }

        // MessageBox asking if the user wants to exit the Application
        private void FormHomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit APPLICATION ?", "YOU MIGHT WANT TO USE ME LATER !", MessageBoxButtons.YesNo);
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
