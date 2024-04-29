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
    public partial class RECTANGLE : Form
    {
        public RECTANGLE()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BACKBUTTON_Click(object sender, EventArgs e)
        {
            AREA aREA = new AREA();
            aREA.Show();
            this.Hide();
        }

        private void COMPUTEBUTTON_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToInt32(Length.Text) * Convert.ToInt32(Width.Text)).ToString();
        }

        private void Width_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
