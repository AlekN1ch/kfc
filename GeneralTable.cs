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
    public partial class GeneralTable : Form
    {
        public GeneralTable()
        {
            InitializeComponent();
        }

        private void GeneralTable_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
