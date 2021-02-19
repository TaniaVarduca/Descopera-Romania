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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 3 - 350, this.Height / 3 - 200);
            label2.Location = new Point(this.Width / 3 + 80, this.Height / 3 - 30);
            button1.Location = new Point(this.Width / 2 - 400, this.Height / 2 + 30);
            button3.Location = new Point(this.Width / 2 - 100, this.Height / 2 + 30);
            button2.Location = new Point(this.Width / 2 + 200, this.Height / 2 + 30);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
