namespace Stocky.Forms
{
    partial class MainForm
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
            lblWelcome = new Label();
            btnProducts = new Button();
            btnCategories = new Button();
            btnEntry = new Button();
            btnExit = new Button();
            btnMovements = new Button();
            btnLogout = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(303, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(171, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bem-vindo, {usuário}";
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(431, 132);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(166, 58);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Gerenciar Produtos";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(603, 132);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(166, 58);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Gerenciar Categorias";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnEntry
            // 
            btnEntry.Location = new Point(42, 94);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(159, 37);
            btnEntry.TabIndex = 3;
            btnEntry.Text = "Registrar Entrada";
            btnEntry.UseVisualStyleBackColor = true;
            btnEntry.Click += btnEntry_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(207, 94);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 37);
            btnExit.TabIndex = 4;
            btnExit.Text = "Registrar Saída";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMovements
            // 
            btnMovements.Location = new Point(431, 196);
            btnMovements.Name = "btnMovements";
            btnMovements.Size = new Size(166, 58);
            btnMovements.TabIndex = 5;
            btnMovements.Text = "Ver Movimentações";
            btnMovements.UseVisualStyleBackColor = true;
            btnMovements.Click += btnMovements_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(603, 196);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(166, 58);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Sair";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(42, 147);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(324, 151);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 331);
            Controls.Add(dgvProducts);
            Controls.Add(btnLogout);
            Controls.Add(btnMovements);
            Controls.Add(btnExit);
            Controls.Add(btnEntry);
            Controls.Add(btnCategories);
            Controls.Add(btnProducts);
            Controls.Add(lblWelcome);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnEntry;
        private Button btnExit;
        private Button btnMovements;
        private Button btnLogout;
        private DataGridView dgvProducts;
    }
}