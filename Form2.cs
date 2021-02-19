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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.Width / 3 - 120, this.Height / 3 + 220);
            pictureBox2.Location = new Point(this.Width / 3 + 290, this.Height / 3 + 150);
            pictureBox3.Location = new Point(this.Width / 3 - 90, this.Height / 3 - 10);
            pictureBox4.Location = new Point(this.Width / 3 + 300, this.Height / 3 - 150);
            pictureBox5.Location = new Point(this.Width / 3 + 660, this.Height / 3 + 160);
            pictureBox6.Location = new Point(this.Width / 3 + 50, this.Height / 3 - 150);
            pictureBox7.Location = new Point(this.Width / 3 + 100, this.Height / 3 + 10);
            pictureBox8.Location = new Point(this.Width / 3 + 80, this.Height / 3 + 200);
            pictureBox9.Location = new Point(this.Width / 3 + 470, this.Height / 3 + 110);
            pictureBox10.Location = new Point(this.Width / 3 + 350, this.Height / 3 + 280);
            pictureBox11.Location = new Point(this.Width / 3 + 160, this.Height / 3 + 340);
            pictureBox12.Location = new Point(this.Width / 3 + 330, this.Height / 3);
            richTextBox1.Location = new Point(pictureBox4.Location.X + pictureBox4.Width, pictureBox4.Location.Y);
            richTextBox2.Location = new Point(pictureBox6.Location.X + pictureBox6.Width, pictureBox6.Location.Y);
            richTextBox3.Location = new Point(pictureBox12.Location.X + pictureBox12.Width, pictureBox12.Location.Y);
            richTextBox4.Location = new Point(pictureBox7.Location.X + pictureBox7.Width, pictureBox7.Location.Y);
            richTextBox5.Location = new Point(pictureBox3.Location.X + pictureBox3.Width, pictureBox3.Location.Y);
            richTextBox6.Location = new Point(pictureBox5.Location.X - 4 * pictureBox5.Width + pictureBox5.Height, pictureBox5.Location.Y);
            richTextBox7.Location = new Point(pictureBox2.Location.X + pictureBox2.Width, pictureBox2.Location.Y - pictureBox1.Height);
            richTextBox8.Location = new Point(pictureBox9.Location.X - 4 * pictureBox1.Width - pictureBox1.Width / 2 + pictureBox9.Width, pictureBox9.Location.Y);
            richTextBox9.Location = new Point(pictureBox10.Location.X + pictureBox10.Width, pictureBox10.Location.Y - 2 * pictureBox1.Height);
            richTextBox10.Location = new Point(pictureBox8.Location.X + pictureBox8.Width, pictureBox8.Location.Y - pictureBox1.Height);
            richTextBox11.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y - pictureBox1.Height);
            richTextBox12.Location = new Point(pictureBox11.Location.X + pictureBox11.Width, pictureBox11.Location.Y - 3 * pictureBox1.Height + pictureBox1.Height / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //richTextBox11.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            //richTextBox5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        //    richTextBox2.Show();          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //richTextBox1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //richTextBox4.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //richTextBox3.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //richTextBox8.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //richTextBox6.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //richTextBox7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //richTextBox10.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //richTextBox12.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //richTextBox9.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox11.Visible = true;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox11.Visible = false;
        }
        
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox7.Visible = true;
        }       
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox7.Visible = false;
        }
        
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox5.Visible = true;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox5.Visible = false;
        }
        
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = true;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = false;
        }
        
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox6.Visible = true;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox6.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox2.Visible = true;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox2.Visible = false;
        }
        
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox4.Visible = true;
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox4.Visible = false;
        }
        
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox10.Visible = true;
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox10.Visible = false;
        }
        
        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox8.Visible = true;
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox8.Visible = false;
        }
        
        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox9.Visible = true;
        }
        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox9.Visible = false;
        }
        
        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox12.Visible = true;
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox12.Visible = false;
        }
                               
        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            this.richTextBox3.Visible = true;
        }
        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox3.Visible = false;
        }        
    }
}
