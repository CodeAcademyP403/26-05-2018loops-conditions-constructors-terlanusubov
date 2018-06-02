using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Add_Product_Form;

namespace Add_Product_Form
{
    public partial class Form1 : Form
    {
        Stock stock = new Stock(10);
        int ProductCount = 0;

        public Form1()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Product product = new Product();
            product.category = new Category();
            product.category.Name = goods_box.SelectedItem.ToString();
            product.Name = name_box.Text;
            product.Weight = Convert.ToDouble(weight_box.Text);
            product.Price = Convert.ToDouble(price_box.Text);
            product.Date = date_box.Text;
            stock.AddProduct(product);

            ProductCount++;
            if(ProductCount > stock.products.Length)
            {
                MessageBox.Show("There is not place in Stock");
            }
            else
            {
                count_of_product.Text = ProductCount.ToString();
            }


        }

    }
}
