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
using System.Xml.Linq;

namespace Stocky.Forms
{
    public partial class MainForm : Form
    {

        private readonly User _currentUser;
        public MainForm(User currentUser)
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            InitializeComponent();

            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            if (_currentUser.Role == Role.User)
            {
                btnProducts.Enabled = false;
                btnCategories.Enabled = false;
                btnMovements.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem-vindo, {_currentUser.Email}";
            LoadProductsGrid();
        }

        private void LoadProductsGrid()
        {
            var list = Program.ProductService.GetAll()
                .Select(p => new
                {
                    p.Id,
                    p.ProductName,
                    p.Description,
                    p.CurrentStock,
                    p.Location,
                    Price = p.Price.ToString("F2"),
                    p.CategoryId
                }).ToList();
            dgvProducts.DataSource = list;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            using var f = new EntryForm(_currentUser);
            f.ShowDialog();
            LoadProductsGrid();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            using var f = new ProductForm(_currentUser);
            f.ShowDialog();
            LoadProductsGrid();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            using var f = new CategoryForm(_currentUser);
            f.ShowDialog();
            LoadProductsGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            using var f = new ExitForm(_currentUser);
            f.ShowDialog();
            LoadProductsGrid();
        }

        private void btnMovements_Click(object sender, EventArgs e)
        {
            using var f = new MovementsForm(_currentUser);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            using var login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close(); 
        }
    }
}
