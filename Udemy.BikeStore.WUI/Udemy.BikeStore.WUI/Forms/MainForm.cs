using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.BikeStore.WUI.Repositories;

namespace Udemy.BikeStore.WUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void GetAllProducts()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                grd_products.DataSource = productRepository.GetAllData2();
            }
        }

        private void grd_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int product_id = (int)grd_products.SelectedRows[0].Cells[0].Value;
            Forms.UpdateProductForm updateProductForm = new UpdateProductForm(product_id);
            updateProductForm.ShowDialog(this);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            InsertProductForm insertProductForm = new InsertProductForm();
            insertProductForm.ShowDialog(this);
        }
    }
}
