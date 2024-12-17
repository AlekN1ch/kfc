using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kfc
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int category;
        public void ChangeCategory()
        {
            switch (category)
            {
                case 0:
                    label7.Visible = true;
                    pictureBox1.Visible = true;
                    label2.Visible = true;
                    label22.Visible = true;

                    label6.Visible = true;
                    pictureBox4.Visible = true;
                    label1.Visible = true;
                    label25.Visible = true;

                    label8.Visible = true;
                    pictureBox3.Visible = true; 
                    label3.Visible = true;
                    label24.Visible = true;

                    label9.Visible = true;
                    pictureBox2.Visible = true;
                    label4.Visible = true;
                    label23.Visible = true;

                    label12.Visible = false;
                    pictureBox9.Visible = false;
                    label17.Visible = false;
                    label19.Visible = false;

                    label13.Visible = false;
                    pictureBox6.Visible = false;
                    label16.Visible = false;
                    label18.Visible = false;

                    label10.Visible = false;
                    pictureBox8.Visible = false;
                    label14.Visible = false;
                    label21.Visible = false;

                    label11.Visible = false;
                    pictureBox7.Visible = false;
                    label15.Visible = false;
                    label20.Visible = false;
                    break;
                    case 1:
                    label7.Visible = false;
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                    label22.Visible = false;

                    label6.Visible = false;
                    pictureBox4.Visible = false;
                    label1.Visible = false;
                    label25.Visible = false;

                    label8.Visible = false;
                    pictureBox3.Visible = false;
                    label3.Visible = false;
                    label24.Visible = false;

                    label9.Visible = false;
                    pictureBox2.Visible = false;
                    label4.Visible = false;
                    label23.Visible = false;

                    label12.Visible = true;
                    pictureBox9.Visible = true;
                    label17.Visible = true;
                    label19.Visible = true;

                    label13.Visible = true;
                    pictureBox6.Visible = true;
                    label16.Visible = true;
                    label18.Visible = true;

                    label10.Visible = true;
                    pictureBox8.Visible = true;
                    label14.Visible = true;
                    label21.Visible = true;

                    label11.Visible = true;
                    pictureBox7.Visible = true;
                    label15.Visible = true;
                    label20.Visible = true;
                    break;
            }
        }
        public static List  <string> foodList= new List <string> ();  
        private void Buy_Load(object sender, EventArgs e)
        {
            category = 0;
            ChangeCategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            category = 1;
            ChangeCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            category = 0;
            ChangeCategory();
        }
        public static List<int >prices= new List<int> ();   
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label12.Text);
            prices.Add(int.Parse(label19.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label13.Text);
            prices.Add(int.Parse(label18.Text));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label11.Text);
            prices.Add(int.Parse(label20.Text));
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label10.Text);
            prices.Add(int.Parse(label21.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label7.Text);
            prices.Add(int.Parse(label22.Text));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label8.Text);
            prices.Add(int.Parse(label24.Text));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label2.Text);
            prices.Add(int.Parse(label23.Text));
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label6.Text);
            prices.Add(int.Parse(label25.Text));
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                foodList.Add(item.ToString());
                
            }
            Basket basket = new Basket();
            basket.Show();
        }
    }
}
