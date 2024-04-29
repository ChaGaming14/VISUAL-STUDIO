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
    public partial class AREA : Form
    {
        public AREA()
        {
            InitializeComponent();
        }

        private void BACKBUTTON_Click(object sender, EventArgs e)
        {
            MAINFORM mAINFORM = new MAINFORM();
            mAINFORM.Show();
            this.Hide();
        }

        private void SQUAREBUTTON_Click(object sender, EventArgs e)
        {
            SQUARE sQUARE = new SQUARE();
            sQUARE.Show();
            this.Hide();
        }

        private void RECTANGLEBUTTON_Click(object sender, EventArgs e)
        {
            RECTANGLE rRECTANGLE = new RECTANGLE();
            rRECTANGLE.Show();
            this.Hide();
        }

        private void TRIANGLEBUTTON_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.Show();
            this.Hide();
        }

        private void CIRCLEBUTTON_Click(object sender, EventArgs e)
        {
            CIRCLE cIRCLE = new CIRCLE();
            cIRCLE.Show();
            this.Hide();
        }
    }
}
