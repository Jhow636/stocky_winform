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
    public partial class EntryForm : Form
    {
        private readonly User _user;
        public EntryForm(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = Program.ProductService.GetAll().ToList();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "Id";
            cmbProduct.DataSource = products;

            UpdateCurrentStockLabel();
        }

        private void UpdateCurrentStockLabel()
        {
            if (cmbProduct.SelectedValue == null)
            {
                lblCurrentStock.Text = "Estoque Atual: -";
                return;
            }
            int productId = (int)cmbProduct.SelectedValue;
            var product = Program.ProductService.GetById(productId);

            if (product == null)
            {
                lblCurrentStock.Text = "Estoque Atual: -";
                return;
            }

            lblCurrentStock.Text = $"Estoque Atual: {product.CurrentStock}";
            lblCurrentStock.ForeColor = Color.Blue;
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e) => UpdateCurrentStockLabel();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null) { MessageBox.Show("Selecione um produto.", "Atenção"); return; }
            var productId = (int)cmbProduct.SelectedValue;
            var qty = (int)numQuantity.Value;
            var desc = txtDescription.Text.Trim();

            try
            {
                Program.EntryService.Register(_user, productId, qty, desc);
                MessageBox.Show("Entrada registrada com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                numQuantity.Value = 1;
                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
