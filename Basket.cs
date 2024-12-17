using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kfc
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            Fileer();
        }
        public void Fileer()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int finalPrice = 0;
            foreach (var item in Buy.foodList)
            {
               
                listBox1.Items.Add(item);
            }
            foreach (var item in Buy.prices)
            {
                listBox2.Items.Add(item);
                finalPrice += item;
            }
           label1.Text = finalPrice.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox2.SelectedItem = listBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Buy.foodList.Remove(listBox1.SelectedItem.ToString());
                 Buy.prices.Remove(int.Parse(listBox2.SelectedItem.ToString()));
                Fileer();
            }
            catch { MessageBox.Show("товар для удаления не выбран"); }
        }
    }
}
