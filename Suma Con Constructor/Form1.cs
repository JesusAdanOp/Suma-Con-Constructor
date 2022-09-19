using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_Con_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            clSuma suma = new clSuma(int.Parse(txtv1.Text), int.Parse(txtv2.Text));
            txtResult.Text = suma.suma().ToString();
        }
    }
}
