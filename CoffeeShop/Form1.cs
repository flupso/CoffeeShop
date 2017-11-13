using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Accessoires_Click(object sender, EventArgs e)
        {
            Accessoires newform = new Accessoires();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }

        private void button_Drinken_Click(object sender, EventArgs e)
        {
            Drinken newform = new Drinken();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }

        private void button_Eten_Click(object sender, EventArgs e)
        {
            Eten newform = new Eten();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }

        private void button_Hasj_Click(object sender, EventArgs e)
        {
            Hasj newform = new Hasj();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }

        private void button_Wiet_Click(object sender, EventArgs e)
        {
            wiet newform = new wiet();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }
    }
}
