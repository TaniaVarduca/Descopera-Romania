using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescoperaRomania
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(Width / 8 - pictureBox1.Width / 2, Height / 16);
            pictureBox2.Location = new Point(pictureBox1.Location.X, 5 * Height / 16);
            pictureBox3.Location = new Point(pictureBox1.Location.X, 9 * Height / 16);
            pictureBox4.Location = new Point(pictureBox1.Location.X, 13 * Height / 16);
            pictureBox5.Location = new Point(Width / 2 + pictureBox5.Width / 4, pictureBox1.Location.Y);
            pictureBox7.Location = new Point(pictureBox5.Location.X, pictureBox2.Location.Y);
            pictureBox8.Location = new Point(pictureBox5.Location.X, pictureBox3.Location.Y);
            pictureBox6.Location = new Point(pictureBox5.Location.X, pictureBox4.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Location = new Point(Width / 8 - pictureBox1.Width / 2 + pictureBox1.Width, Height / 16);
            label2.Show();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Location = new Point(pictureBox1.Location.X + pictureBox2.Width, 5 * Height / 16);
            label3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label4.Location = new Point(pictureBox1.Location.X + pictureBox3.Width, 9 * Height / 16);
            label4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label5.Location = new Point(pictureBox1.Location.X + pictureBox4.Width, 13 * Height / 16);
            label5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label6.Location = new Point(Width / 2 + pictureBox5.Width / 4 + pictureBox5.Width, pictureBox1.Location.Y);
            label6.Show();
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label7.Location = new Point(pictureBox5.Location.X + pictureBox6.Width, pictureBox4.Location.Y);
            label7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label9.Location = new Point(pictureBox5.Location.X + pictureBox7.Width, pictureBox2.Location.Y);
            label9.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label8.Location = new Point(pictureBox5.Location.X + pictureBox8.Width, pictureBox3.Location.Y);
            label8.Show();
        }
    }
}
