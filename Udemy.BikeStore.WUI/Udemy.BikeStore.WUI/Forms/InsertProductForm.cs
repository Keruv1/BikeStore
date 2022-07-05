using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.BikeStore.WUI.Models.StoreProcedure;
using Udemy.BikeStore.WUI.Repositories;

namespace Udemy.BikeStore.WUI.Forms
{
    public partial class InsertProductForm : Form
    {
        public InsertProductForm()
        {
            InitializeComponent(); ;
        }

        private void InsertProductForm_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
        }

        void GetBrands()
        {
            using (BrandRepository brandRepository = new BrandRepository())
            {
                cmb_marka.DisplayMember = "brand_name";
                cmb_marka.ValueMember = "brand_id";
                cmb_marka.DataSource = brandRepository.GetAllData();
            }
        }

        void GetCategories()
        {
            using (CategoryRepository categoryRepository = new CategoryRepository())
            {
                cmb_category.DisplayMember = "category_name";
                cmb_category.ValueMember = "category_id";
                cmb_category.DataSource = categoryRepository.GetAllData();
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSP updateProductSP = new UpdateProductSP();
                updateProductSP.product_name = txt_product.Text;
                updateProductSP.model_year = Convert.ToInt32(txt_model.Text);
                updateProductSP.list_price = Convert.ToDecimal(txt_price);
                updateProductSP.category_id = (int)cmb_category.SelectedValue;
                updateProductSP.brand_id = (int)cmb_marka.SelectedValue;

                int returnValue = productRepository.InsertData(updateProductSP);
                if (returnValue >0)
                {
                    MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
