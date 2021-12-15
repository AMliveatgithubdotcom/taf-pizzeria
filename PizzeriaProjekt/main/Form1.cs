using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzeriaProjekt.main;

namespace PizzeriaProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Pizza pizza = new Pizza();
                    listBox2.Items.Add(pizza.ReturnName());
                        //.ObjectCollection.Add(Pizza());
                    return;
            }
        }
    }
}
