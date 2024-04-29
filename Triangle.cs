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
    public partial class Triangle : Form
    {
        public Triangle()
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
            RESULT.Text = ( 0.5 * Convert.ToInt32(BASE.Text) * Convert.ToInt32(HEIGHT.Text)).ToString();
        }

        private void BASE_TextChanged(object sender, EventArgs e)
        {

        }

        private void HEIGHT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
