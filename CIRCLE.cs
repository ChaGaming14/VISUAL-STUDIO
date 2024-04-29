using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CIRCLE : Form
    {
        public CIRCLE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RESULT.Text = (3.1416 * Convert.ToInt32(RADIUS.Text) * Convert.ToInt32(RADIUS.Text)).ToString();
        }

        private void RADIUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void RESULT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BACKBUTTON_Click(object sender, EventArgs e)
        {
            AREA aREA = new AREA();
            aREA.Show();
            this.Hide();
        }
    }
}
