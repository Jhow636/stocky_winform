namespace Stocky.Forms
{
    partial class MovementsForm
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            dgvEntries = new DataGridView();
            tabPage2 = new TabPage();
            dgvExits = new DataGridView();
            btnClose = new Button();
            button1 = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntries).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExits).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 426);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvEntries);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Entradas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEntries
            // 
            dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntries.Dock = DockStyle.Fill;
            dgvEntries.Location = new Point(3, 3);
            dgvEntries.Name = "dgvEntries";
            dgvEntries.ReadOnly = true;
            dgvEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntries.Size = new Size(762, 392);
            dgvEntries.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvExits);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Saídas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExits
            // 
            dgvExits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExits.Dock = DockStyle.Fill;
            dgvExits.Location = new Point(3, 3);
            dgvExits.Name = "dgvExits";
            dgvExits.ReadOnly = true;
            dgvExits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExits.Size = new Size(762, 392);
            dgvExits.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(303, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 23);
            btnClose.TabIndex = 55;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.Location = new Point(569, 452);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 56;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MovementsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(tabControl);
            Name = "MovementsForm";
            Text = "MovementsForm";
            Load += MovementsForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntries).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView dgvEntries;
        private TabPage tabPage2;
        private DataGridView dgvExits;
        private Button btnClose;
        private Button button1;
    }
}