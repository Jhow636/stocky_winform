using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocky.Models;
using System.Windows.Forms;
using System.Drawing;

namespace Stocky.Forms
{
    public partial class ExitForm : Form
    {
        private readonly User _user;
        public ExitForm(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e)
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

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e) => UpdateCurrentStockLabel();

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
            lblCurrentStock.ForeColor = Color.Red;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Selecione um produto.", "Atenção");
                return;
            }

            int productId = (int)cmbProduct.SelectedValue;
            int qty = (int)numQuantity.Value;
            string desc = txtDescription.Text.Trim();

            try
            {
                Program.ExitService.Register(_user, productId, qty, desc);
                MessageBox.Show("Saída registrada com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
