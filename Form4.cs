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
    public partial class Form4 : Form
    {
        int i = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(Width / 8 + button1.Width, Height / 8);
            groupBox2.Location = new Point(Width / 8 + button1.Width, Height / 8 + groupBox2.Height);
            groupBox3.Location = new Point(Width / 8 + button1.Width, Height / 8 + 2 * groupBox2.Height);
            groupBox4.Location = new Point(Width / 2, Height / 8);
            groupBox5.Location = new Point(Width / 2, Height / 8 + groupBox1.Height);
            groupBox6.Location = new Point(Width / 2, Height / 8 + 2 * groupBox2.Height);
            button1.Location = new Point(Width / 2 - button1.Width, Height / 8 + 3 * groupBox2.Height + button1.Height);
            button2.Location = new Point(Width / 2 + textBox1.Width / 2 + textBox1.Width, Height / 8 + 3 * groupBox1.Height + button1.Height);
            button3.Location = new Point(Width / 2 + textBox1.Width / 2 - button1.Width / 2, Height / 8 + 3 * groupBox2.Height + button1.Height + textBox1.Height + 5);
            textBox1.Location = new Point(Width / 2 + textBox1.Width / 2 - button1.Width / 2, Height / 8 + 3 * groupBox2.Height + button1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) i++;
            if (radioButton5.Checked == true) i++;
            if (radioButton7.Checked == true) i++;
            if (radioButton12.Checked == true) i++;
            if (radioButton13.Checked == true) i++;
            if (radioButton18.Checked == true) i++;
            textBox1.Text = "Ai avut: " + Convert.ToString(i) + " raspunsuri corecte";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raspunsurile corecte erau: Bujorului, Muza Adormita, Ateneul roman, Regele Carol I, Depozitele de gaze naturale de la mare adancime, Pestera Ursilor");
        }
    }
}
