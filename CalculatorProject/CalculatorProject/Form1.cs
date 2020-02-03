using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorApp : Form
    {
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void one_Box_Click(object sender, EventArgs e)
        {
            OperatorHandler h = new OperatorHandler();

            displayBox.Text=h.getVar();

        }

        private void two_Box_Click(object sender, EventArgs e)
        {

        }

        private void plus_Box_Click(object sender, EventArgs e)
        {

        }

        private void equals_Box_Click(object sender, EventArgs e)
        {

        }
    }
}
