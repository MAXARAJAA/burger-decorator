using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using burger_decorator;

namespace burger_decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Burger burger1 = new ItalianBurger();
            burger1 = new TomatoBurger(burger1); // итальянская пицца с томатами
            MessageBox.Show("Название: " + burger1.Name);
            MessageBox.Show("Цена: "+ burger1.GetCost());

            Burger burger2 = new ItalianBurger();
            burger2 = new CheeseBurger(burger2);// итальянская пиццы с сыром
            MessageBox.Show("Название: "+ burger2.Name);
            MessageBox.Show("Цена: "+ burger2.GetCost());

            Burger burger3 = new BulgerianBurger();
            burger3 = new TomatoBurger(burger3);
            burger3 = new CheeseBurger(burger3);// болгарская пиццы с томатами и сыром
            MessageBox.Show("Название: "+ burger3.Name);
            MessageBox.Show("Цена: "+ burger3.GetCost());

            
            
        }
    }
}
