using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SQUARE : Form
    {
        public SQUARE()
        {
            InitializeComponent();
        }

        private void BACKBUTTON_Click(object sender, EventArgs e)
        {
            AREA aREA = new AREA();
            aREA.Show();
            this.Hide();

        }

        private void COMPUTEBUTTON_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
