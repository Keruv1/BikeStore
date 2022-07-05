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
    public partial class UpdateProductForm : Form
    {
        int productId;
        public UpdateProductForm(int product_id)
        {
            InitializeComponent();
            productId = product_id;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
            GetProductById();
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

        void GetProductById()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                var dataItem = productRepository.GetById(productId);
                txt_product.Text = dataItem.product_name;
                txt_model.Text = dataItem.model_year.ToString();
                txt_price.Text = dataItem.list_price.ToString();
                cmb_marka.SelectedValue = dataItem.brand_id;
                cmb_category.SelectedValue = dataItem.category_id;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (ProductRepository product = new ProductRepository())
            {
                UpdateProductSP updateProductSP = new UpdateProductSP();
                updateProductSP.product_id = productId;
                updateProductSP.product_name = txt_product.Text;
                updateProductSP.brand_id = (int)cmb_marka.SelectedValue;
                updateProductSP.category_id = (int)cmb_category.SelectedValue;
                updateProductSP.model_year = int.Parse(txt_model.Text.ToString());
                updateProductSP.list_price = decimal.Parse(txt_price.Text);
                int returnValue = product.UpdateData(updateProductSP);

                if (returnValue == 0)
                {
                    MessageBox.Show("Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {

                int returnValue = productRepository.DeleteData(new UpdateProductSP { product_id = productId });
                if (returnValue > 0) this.Close();
                
            }
        }
    }
}
