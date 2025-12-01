namespace Stocky.Forms
{
    partial class UserForm
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblTitle = new Label();
            label1 = new Label();
            comboRole = new ComboBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Azure;
            btnRegister.FlatStyle = FlatStyle.System;
            btnRegister.ForeColor = SystemColors.Desktop;
            btnRegister.Location = new Point(279, 266);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(98, 28);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveBorder;
            txtPassword.Location = new Point(108, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(412, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.Location = new Point(108, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(412, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(108, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(108, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(210, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Registrar novo usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 200);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "Senha:";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(108, 218);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(172, 23);
            comboRole.TabIndex = 13;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 322);
            Controls.Add(comboRole);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblTitle);
            Name = "UserForm";
            Text = "Cadastrar novo usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblTitle;
        private Label label1;
        private ComboBox comboRole;
    }
}