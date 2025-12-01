namespace Stocky.Forms
{
    partial class ExitForm
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
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbProduct = new ComboBox();
            lblTitle = new Label();
            btnClose = new Button();
            btnRegister = new Button();
            txtDescription = new TextBox();
            lblCurrentStock = new Label();
            lblProduct = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(315, 210);
            numQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(147, 23);
            numQuantity.TabIndex = 58;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(315, 180);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(147, 15);
            lblQuantity.TabIndex = 57;
            lblQuantity.Text = "Quantidade para adicionar";
            // 
            // cmbProduct
            // 
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(98, 135);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(171, 23);
            cmbProduct.TabIndex = 56;
            cmbProduct.ValueMember = "Id";
            cmbProduct.SelectedIndexChanged += CmbProduct_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(221, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 25);
            lblTitle.TabIndex = 55;
            lblTitle.Text = "SAÍDA DE ESTOQUE";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(315, 284);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 23);
            btnClose.TabIndex = 54;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(90, 284);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(171, 23);
            btnRegister.TabIndex = 53;
            btnRegister.Text = "Registrar Saída";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(98, 210);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(171, 23);
            txtDescription.TabIndex = 51;
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Location = new Point(315, 105);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(67, 15);
            lblCurrentStock.TabIndex = 50;
            lblCurrentStock.Text = "Stock Atual";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(98, 105);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(50, 15);
            lblProduct.TabIndex = 49;
            lblProduct.Text = "Produto";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(98, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(58, 15);
            lblDescription.TabIndex = 48;
            lblDescription.Text = "Descrição";
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 386);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtDescription);
            Controls.Add(lblCurrentStock);
            Controls.Add(lblProduct);
            Controls.Add(lblDescription);
            Name = "ExitForm";
            Text = "ExitForm";
            Load += ExitForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private ComboBox cmbProduct;
        private Label lblTitle;
        private Button btnClose;
        private Button btnRegister;
        private TextBox txtDescription;
        private Label lblCurrentStock;
        private Label lblProduct;
        private Label lblDescription;
    }
}