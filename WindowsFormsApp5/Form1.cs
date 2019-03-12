using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double force = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox2.Text);

            double Fx = force * cos(angle);
            double Fy = force * sin(angle);

            MessageBox.Show("Fx=" + Fx + "N");
             MessageBox.Show("Fy=" + Fx + "N");
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
