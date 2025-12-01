using Stocky.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stocky.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly User _user;
        public CategoryForm(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lstCategories.DataSource = null;
            lstCategories.DataSource = Program.CategoryService.GetAll().ToList();
            lstCategories.DisplayMember = "CategoryName";
        }

        private void LstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem is Category c)
            {
                txtCategoryName.Text = c.CategoryName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name)) { MessageBox.Show("Nome da categoria obrigatório."); return; }
            Program.CategoryService.Register(name);
            txtCategoryName.Clear();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem is Category c)
            {
                var name = txtCategoryName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name)) { MessageBox.Show("Nome da categoria obrigatório."); return; }
                Program.CategoryService.Update(c.Id, name);
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem is Category c)
            {
                if (MessageBox.Show("Confirma exclusão?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.CategoryService.Delete(c.Id);
                    RefreshList();
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
