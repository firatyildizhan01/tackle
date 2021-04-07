using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            Random mrt = new Random();

            int s1, s2;
            s1 = mrt.Next(0, 100);
            s2 = mrt.Next(0, 100);

            
            konum.X = s1;
            konum.Y = s2;
            pictureBox1.Location = konum;
        }
    }
}
