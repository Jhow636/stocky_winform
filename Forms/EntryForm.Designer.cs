namespace Stocky.Forms
{
    partial class EntryForm
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
            btnClose = new Button();
            lblDescription = new Label();
            lblProduct = new Label();
            lblCurrentStock = new Label();
            txtDescription = new TextBox();
            btnRegister = new Button();
            lblTitle = new Label();
            cmbProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(285, 271);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 23);
            btnClose.TabIndex = 43;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(68, 169);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(58, 15);
            lblDescription.TabIndex = 25;
            lblDescription.Text = "Descrição";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(68, 92);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(50, 15);
            lblProduct.TabIndex = 26;
            lblProduct.Text = "Produto";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Location = new Point(285, 122);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(67, 15);
            lblCurrentStock.TabIndex = 29;
            lblCurrentStock.Text = "Stock Atual";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(68, 197);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(171, 23);
            txtDescription.TabIndex = 35;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(60, 271);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(171, 23);
            btnRegister.TabIndex = 41;
            btnRegister.Text = "Registrar Entrada";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(153, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 25);
            lblTitle.TabIndex = 44;
            lblTitle.Text = "ENTRADA DE ESTOQUE";
            // 
            // cmbProduct
            // 
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(68, 122);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(171, 23);
            cmbProduct.TabIndex = 45;
            cmbProduct.ValueMember = "Id";
            cmbProduct.SelectedIndexChanged += CmbProduct_SelectedIndexChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(285, 197);
            numQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(147, 23);
            numQuantity.TabIndex = 47;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(285, 167);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(147, 15);
            lblQuantity.TabIndex = 46;
            lblQuantity.Text = "Quantidade para adicionar";
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(545, 352);
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
            Name = "EntryForm";
            Text = "Entrada de Estoque";
            Load += EntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblDescription;
        private Label lblProduct;
        private Label lblCurrentStock;
        private TextBox txtDescription;
        private Button btnRegister;
        private Label lblTitle;
        private ComboBox cmbProduct;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
    }
}