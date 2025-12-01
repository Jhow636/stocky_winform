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
            btnMovements = new Button();
            btnLogout = new Button();
            dgvProducts = new DataGridView();
            panel1 = new Panel();
            btnRegister_User = new Button();
            label1 = new Label();
            btnEntry = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(34, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(171, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bem-vindo, {usuário}";
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(16, 67);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(166, 58);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Gerenciar Produtos";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(188, 67);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(166, 58);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Gerenciar Categorias";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnMovements
            // 
            btnMovements.Location = new Point(16, 150);
            btnMovements.Name = "btnMovements";
            btnMovements.Size = new Size(166, 58);
            btnMovements.TabIndex = 5;
            btnMovements.Text = "Ver Movimentações";
            btnMovements.UseVisualStyleBackColor = true;
            btnMovements.Click += btnMovements_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(16, 228);
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
            dgvProducts.Location = new Point(34, 147);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(321, 205);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnRegister_User);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnMovements);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProducts);
            panel1.Location = new Point(415, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 306);
            panel1.TabIndex = 8;
            // 
            // btnRegister_User
            // 
            btnRegister_User.Location = new Point(188, 150);
            btnRegister_User.Name = "btnRegister_User";
            btnRegister_User.Size = new Size(166, 58);
            btnRegister_User.TabIndex = 9;
            btnRegister_User.Text = "Registrar usuário";
            btnRegister_User.UseVisualStyleBackColor = true;
            btnRegister_User.Click += btnRegister_User_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(103, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 9;
            label1.Text = "Ferramentas";
            // 
            // btnEntry
            // 
            btnEntry.BackColor = Color.FromArgb(0, 192, 0);
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.ForeColor = SystemColors.ControlLightLight;
            btnEntry.Location = new Point(34, 80);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(151, 37);
            btnEntry.TabIndex = 3;
            btnEntry.Text = "Registrar Entrada";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(199, 80);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 37);
            btnExit.TabIndex = 4;
            btnExit.Text = "Registrar Saída";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(793, 371);
            Controls.Add(btnExit);
            Controls.Add(btnEntry);
            Controls.Add(dgvProducts);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnMovements;
        private Button btnLogout;
        private DataGridView dgvProducts;
        private Panel panel1;
        private Button btnEntry;
        private Button btnExit;
        private Label label1;
        private Button btnRegister_User;
    }
}