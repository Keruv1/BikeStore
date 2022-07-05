
namespace Udemy.BikeStore.WUI.Forms
{
    partial class InsertProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(72, 126);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(275, 20);
            this.txt_price.TabIndex = 11;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(72, 100);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(275, 20);
            this.txt_model.TabIndex = 12;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(72, 74);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(275, 20);
            this.txt_product.TabIndex = 13;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(72, 47);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(275, 21);
            this.cmb_category.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün";
            // 
            // cmb_marka
            // 
            this.cmb_marka.FormattingEnabled = true;
            this.cmb_marka.Location = new System.Drawing.Point(72, 20);
            this.cmb_marka.Name = "cmb_marka";
            this.cmb_marka.Size = new System.Drawing.Size(275, 21);
            this.cmb_marka.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marka";
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(72, 152);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(275, 23);
            this.btn_kayit.TabIndex = 14;
            this.btn_kayit.Text = "Kayıt Ekle";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // InsertProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 340);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_marka);
            this.Controls.Add(this.label1);
            this.Name = "InsertProductForm";
            this.Text = "Kayıt Ekle";
            this.Load += new System.EventHandler(this.InsertProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayit;
    }
}