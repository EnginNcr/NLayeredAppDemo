namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.grbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddUnitStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddBirimFiyat = new System.Windows.Forms.Label();
            this.lblAddStok = new System.Windows.Forms.Label();
            this.lblAddFiyat = new System.Windows.Forms.Label();
            this.lblAddKategori = new System.Windows.Forms.Label();
            this.lblAddAdi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdatedProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.grbxAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(31, 173);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(853, 160);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(270, 17);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(322, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(270, 21);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(322, 22);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(40, 25);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(40, 24);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 16);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Ürün Adı";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxCategory.Location = new System.Drawing.Point(31, 23);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Size = new System.Drawing.Size(721, 62);
            this.gbxCategory.TabIndex = 4;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Arama";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.Location = new System.Drawing.Point(31, 91);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSearch.Size = new System.Drawing.Size(721, 61);
            this.gbxSearch.TabIndex = 4;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "İsime Göre Arama";
            // 
            // grbxAdd
            // 
            this.grbxAdd.Controls.Add(this.btnAdd);
            this.grbxAdd.Controls.Add(this.cbxAddCategoryId);
            this.grbxAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.grbxAdd.Controls.Add(this.tbxAddUnitStock);
            this.grbxAdd.Controls.Add(this.tbxAddUnitPrice);
            this.grbxAdd.Controls.Add(this.tbxAddProductName);
            this.grbxAdd.Controls.Add(this.lblAddBirimFiyat);
            this.grbxAdd.Controls.Add(this.lblAddStok);
            this.grbxAdd.Controls.Add(this.lblAddFiyat);
            this.grbxAdd.Controls.Add(this.lblAddKategori);
            this.grbxAdd.Controls.Add(this.lblAddAdi);
            this.grbxAdd.Location = new System.Drawing.Point(31, 352);
            this.grbxAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbxAdd.Name = "grbxAdd";
            this.grbxAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbxAdd.Size = new System.Drawing.Size(757, 131);
            this.grbxAdd.TabIndex = 5;
            this.grbxAdd.TabStop = false;
            this.grbxAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(527, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxAddCategoryId
            // 
            this.cbxAddCategoryId.FormattingEnabled = true;
            this.cbxAddCategoryId.Location = new System.Drawing.Point(131, 58);
            this.cbxAddCategoryId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxAddCategoryId.Name = "cbxAddCategoryId";
            this.cbxAddCategoryId.Size = new System.Drawing.Size(231, 21);
            this.cbxAddCategoryId.TabIndex = 18;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(527, 63);
            this.tbxAddQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(216, 20);
            this.tbxAddQuantityPerUnit.TabIndex = 14;
            // 
            // tbxAddUnitStock
            // 
            this.tbxAddUnitStock.Location = new System.Drawing.Point(527, 28);
            this.tbxAddUnitStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddUnitStock.Name = "tbxAddUnitStock";
            this.tbxAddUnitStock.Size = new System.Drawing.Size(216, 20);
            this.tbxAddUnitStock.TabIndex = 15;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(129, 91);
            this.tbxAddUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(231, 20);
            this.tbxAddUnitPrice.TabIndex = 16;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(129, 28);
            this.tbxAddProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(231, 20);
            this.tbxAddProductName.TabIndex = 17;
            // 
            // lblAddBirimFiyat
            // 
            this.lblAddBirimFiyat.AutoSize = true;
            this.lblAddBirimFiyat.Location = new System.Drawing.Point(427, 67);
            this.lblAddBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBirimFiyat.Name = "lblAddBirimFiyat";
            this.lblAddBirimFiyat.Size = new System.Drawing.Size(70, 13);
            this.lblAddBirimFiyat.TabIndex = 9;
            this.lblAddBirimFiyat.Text = "Birim Adedi";
            // 
            // lblAddStok
            // 
            this.lblAddStok.AutoSize = true;
            this.lblAddStok.Location = new System.Drawing.Point(427, 32);
            this.lblAddStok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStok.Name = "lblAddStok";
            this.lblAddStok.Size = new System.Drawing.Size(69, 13);
            this.lblAddStok.TabIndex = 10;
            this.lblAddStok.Text = "Stok Adedi";
            // 
            // lblAddFiyat
            // 
            this.lblAddFiyat.AutoSize = true;
            this.lblAddFiyat.Location = new System.Drawing.Point(20, 95);
            this.lblAddFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddFiyat.Name = "lblAddFiyat";
            this.lblAddFiyat.Size = new System.Drawing.Size(34, 13);
            this.lblAddFiyat.TabIndex = 11;
            this.lblAddFiyat.Text = "Fiyat";
            // 
            // lblAddKategori
            // 
            this.lblAddKategori.AutoSize = true;
            this.lblAddKategori.Location = new System.Drawing.Point(20, 67);
            this.lblAddKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddKategori.Name = "lblAddKategori";
            this.lblAddKategori.Size = new System.Drawing.Size(54, 13);
            this.lblAddKategori.TabIndex = 12;
            this.lblAddKategori.Text = "Kategori";
            // 
            // lblAddAdi
            // 
            this.lblAddAdi.AutoSize = true;
            this.lblAddAdi.Location = new System.Drawing.Point(20, 32);
            this.lblAddAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAdi.Name = "lblAddAdi";
            this.lblAddAdi.Size = new System.Drawing.Size(56, 13);
            this.lblAddAdi.TabIndex = 13;
            this.lblAddAdi.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cbxUpdateCategoryId);
            this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxUpdateUnitStock);
            this.groupBox1.Controls.Add(this.tbxUpdateUnitPrice);
            this.groupBox1.Controls.Add(this.tbxUpdatedProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(31, 500);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(757, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Ürün Güncelle";
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(131, 59);
            this.cbxUpdateCategoryId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(231, 21);
            this.cbxUpdateCategoryId.TabIndex = 18;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(527, 64);
            this.tbxUpdateQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(216, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 14;
            // 
            // tbxUpdateUnitStock
            // 
            this.tbxUpdateUnitStock.Location = new System.Drawing.Point(527, 29);
            this.tbxUpdateUnitStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUpdateUnitStock.Name = "tbxUpdateUnitStock";
            this.tbxUpdateUnitStock.Size = new System.Drawing.Size(216, 20);
            this.tbxUpdateUnitStock.TabIndex = 15;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(129, 92);
            this.tbxUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(231, 20);
            this.tbxUpdateUnitPrice.TabIndex = 16;
            // 
            // tbxUpdatedProductName
            // 
            this.tbxUpdatedProductName.Location = new System.Drawing.Point(129, 29);
            this.tbxUpdatedProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUpdatedProductName.Name = "tbxUpdatedProductName";
            this.tbxUpdatedProductName.Size = new System.Drawing.Size(231, 20);
            this.tbxUpdatedProductName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Adı";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(527, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(828, 352);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 131);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 647);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.grbxAdd.ResumeLayout(false);
            this.grbxAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox grbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxAddCategoryId;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddUnitStock;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Label lblAddBirimFiyat;
        private System.Windows.Forms.Label lblAddStok;
        private System.Windows.Forms.Label lblAddFiyat;
        private System.Windows.Forms.Label lblAddKategori;
        private System.Windows.Forms.Label lblAddAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitStock;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdatedProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

