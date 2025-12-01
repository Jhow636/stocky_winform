namespace Stocky.Forms
{
    partial class ProductForm
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
            lblName = new Label();
            lblDescription = new Label();
            lblLocation = new Label();
            lblMinStock = new Label();
            lblMaxStock = new Label();
            lblCurrentStock = new Label();
            lblPrice = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtName = new TextBox();
            txtLocation = new TextBox();
            txtDescription = new TextBox();
            numMinStock = new NumericUpDown();
            numMaxStock = new NumericUpDown();
            numCurrentStock = new NumericUpDown();
            numPrice = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numMinStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(416, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nome";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(633, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(58, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Descrição";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(416, 99);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(68, 15);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Localização";
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(633, 99);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(63, 15);
            lblMinStock.TabIndex = 4;
            lblMinStock.Text = "Stock Min.";
            // 
            // lblMaxStock
            // 
            lblMaxStock.AutoSize = true;
            lblMaxStock.Location = new Point(416, 174);
            lblMaxStock.Name = "lblMaxStock";
            lblMaxStock.Size = new Size(64, 15);
            lblMaxStock.TabIndex = 5;
            lblMaxStock.Text = "Stock Max.";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Location = new Point(633, 174);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(67, 15);
            lblCurrentStock.TabIndex = 6;
            lblCurrentStock.Text = "Stock Atual";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(416, 241);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(37, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Preço";
            // 
            // cmbCategory
            // 
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(633, 272);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(171, 23);
            cmbCategory.TabIndex = 8;
            cmbCategory.ValueMember = "Id";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(633, 241);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Categoria";
            // 
            // txtName
            // 
            txtName.Location = new Point(416, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 23);
            txtName.TabIndex = 10;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(416, 129);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(171, 23);
            txtLocation.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(633, 58);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(171, 23);
            txtDescription.TabIndex = 14;
            // 
            // numMinStock
            // 
            numMinStock.Location = new Point(633, 130);
            numMinStock.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numMinStock.Name = "numMinStock";
            numMinStock.Size = new Size(120, 23);
            numMinStock.TabIndex = 15;
            // 
            // numMaxStock
            // 
            numMaxStock.Location = new Point(416, 204);
            numMaxStock.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numMaxStock.Name = "numMaxStock";
            numMaxStock.Size = new Size(120, 23);
            numMaxStock.TabIndex = 16;
            // 
            // numCurrentStock
            // 
            numCurrentStock.Location = new Point(633, 204);
            numCurrentStock.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCurrentStock.Name = "numCurrentStock";
            numCurrentStock.Size = new Size(120, 23);
            numCurrentStock.TabIndex = 17;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(416, 272);
            numPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(416, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(416, 382);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(633, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(633, 382);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 23);
            btnClose.TabIndex = 22;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(21, 30);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(376, 375);
            dgvProducts.TabIndex = 23;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(870, 450);
            Controls.Add(dgvProducts);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numPrice);
            Controls.Add(numCurrentStock);
            Controls.Add(numMaxStock);
            Controls.Add(numMinStock);
            Controls.Add(txtDescription);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblCurrentStock);
            Controls.Add(lblMaxStock);
            Controls.Add(lblMinStock);
            Controls.Add(lblLocation);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Name = "ProductForm";
            Text = "Produtos";
            Load += Location_Load;
            ((System.ComponentModel.ISupportInitialize)numMinStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblDescription;
        private Label lblLocation;
        private Label lblMinStock;
        private Label lblMaxStock;
        private Label lblCurrentStock;
        private Label lblPrice;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private TextBox txtName;
        private TextBox txtLocation;
        private TextBox txtDescription;
        private NumericUpDown numMinStock;
        private NumericUpDown numMaxStock;
        private NumericUpDown numCurrentStock;
        private NumericUpDown numPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvProducts;
    }
}