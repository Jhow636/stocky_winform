using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stocky.Models;


namespace Stocky.Forms
{
    public partial class ProductForm : Form
    {

        private readonly User _user;
        public ProductForm(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            InitializeComponent();
        }

        private void LoadCategories()
        {
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = Program.CategoryService.GetAll();
        }

        private void RefreshGrid()
        {
            if (dgvProducts == null) return;

            dgvProducts.DataSource = null;
            dgvProducts.Columns.Clear();

            dgvProducts.AutoGenerateColumns = true;


            var list = Program.ProductService.GetAll()
                 .Select(p => new
                 {
                     p.Id,
                     p.ProductName,
                     p.Description,
                     p.CurrentStock,
                     p.Location,
                     Price = p.Price.ToString("F2"),
                     CategoryId = p.CategoryId,
                     CategoryName = Program.CategoryService.GetById(p.CategoryId)?.CategoryName ?? "-"
                 }).ToList();

            var bs = new BindingSource { DataSource = list };
            dgvProducts.DataSource = bs;
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int id;
            var idCell = dgvProducts.CurrentRow.Cells["Id"];
            if (idCell == null || idCell.Value == null) return;

            id = Convert.ToInt32(idCell.Value);

            var p = Program.ProductService.GetById(id);
            if (p == null) return;

            txtName.Text = p.ProductName;
            txtDescription.Text = p.Description;
            txtLocation.Text = p.Location;
            numMinStock.Value = Math.Max(numMinStock.Minimum, Math.Min(numMinStock.Maximum, p.MinStock));
            numMaxStock.Value = Math.Max(numMaxStock.Minimum, Math.Min(numMaxStock.Maximum, p.MaxStock));
            numCurrentStock.Value = Math.Max(numCurrentStock.Minimum, Math.Min(numCurrentStock.Maximum, p.CurrentStock));
            numPrice.Value = Convert.ToDecimal(p.Price);

            if (cmbCategory.Items.Count > 0)
            {
                try { cmbCategory.SelectedValue = p.CategoryId; }
                catch { }
            }
        }

        private void txtLocation_Load(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            var id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            try
            {
                var name = txtName.Text.Trim();
                var desc = txtDescription.Text.Trim();
                var min = (int)numMinStock.Value;
                var max = (int)numMaxStock.Value;
                var cur = (int)numCurrentStock.Value;
                var loc = txtLocation.Text.Trim();
                var price = numPrice.Value;
                var catId = (int?)cmbCategory.SelectedValue;

                Program.ProductService.Update(_user, id, productName: name, description: desc, minStock: min, maxStock: max, currentStock: cur, location: loc, price: price, categoryId: catId);
                MessageBox.Show("Produto atualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name)) { MessageBox.Show("Nome obrigatório.", "Atenção"); return; }
                var desc = txtDescription.Text.Trim();
                var min = (int)numMinStock.Value;
                var max = (int)numMaxStock.Value;
                var cur = (int)numCurrentStock.Value;
                var loc = txtLocation.Text.Trim();
                var price = numPrice.Value;
                var catId = (int?)cmbCategory.SelectedValue ?? 0;

                var prod = Program.ProductService.Register(_user, name, desc, min, max, cur, loc, price, catId);
                MessageBox.Show("Produto adicionado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            var id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            if (MessageBox.Show("Confirma exclusão do produto?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                Program.ProductService.Delete(_user, id);
                MessageBox.Show("Produto excluído.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            var id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            try
            {
                var name = txtName.Text.Trim();
                var desc = txtDescription.Text.Trim();
                var min = (int)numMinStock.Value;
                var max = (int)numMaxStock.Value;
                var cur = (int)numCurrentStock.Value;
                var loc = txtLocation.Text.Trim();
                var price = numPrice.Value;
                var catId = (int?)cmbCategory.SelectedValue;

                Program.ProductService.Update(_user, id, productName: name, description: desc, minStock: min, maxStock: max, currentStock: cur, location: loc, price: price, categoryId: catId);
                MessageBox.Show("Produto atualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            LoadCategories();
            RefreshGrid();
        }
    }
}
