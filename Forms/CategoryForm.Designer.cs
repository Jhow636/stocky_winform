namespace Stocky.Forms
{
    partial class CategoryForm
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtCategoryName = new TextBox();
            lblName = new Label();
            lstCategories = new ListBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(607, 177);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 23);
            btnClose.TabIndex = 43;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(607, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 23);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(404, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 23);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(404, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 23);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(404, 54);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(171, 23);
            txtCategoryName.TabIndex = 33;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(404, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 24;
            lblName.Text = "Nome";
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 15;
            lstCategories.Location = new Point(12, 12);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(374, 274);
            lstCategories.TabIndex = 44;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 320);
            Controls.Add(lstCategories);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Controls.Add(lblName);
            Name = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtCategoryName;
        private Label lblName;
        private ListBox lstCategories;
    }
}