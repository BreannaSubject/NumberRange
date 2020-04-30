using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberRange
{
    public partial class Form1 : Form
    {
        int startnumber, endnumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void startInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                startnumber = Convert.ToInt16(startInput.Text);
            }
            catch
            {
                outputLabel.Text = "You must enter an Integer";
            }
            
        }

        private void endInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                endnumber = Convert.ToInt16(endInput.Text);
            }
            catch
            {
                outputLabel.Text = "You must enter an Integer";
            }
            
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            for (int i = startnumber; i <= endnumber; i++)
            {
                outputLabel.Text += Convert.ToString(i) + " ";
            }
        }
    }
}
