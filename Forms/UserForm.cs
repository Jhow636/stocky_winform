using Stocky.Models;
using Stocky.Services;
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
    public partial class UserForm : Form
    {
        private readonly User _currentUser;
        private readonly UserService _userService;
        public UserForm(User currentUser, UserService userService)
        {
            InitializeComponent();
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            if (!_currentUser.IsAdmin())
            {
                MessageBox.Show("Você não tem permissão para cadastrar novos usuários.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            comboRole.DataSource = Enum.GetValues(typeof(Role));
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboRole.SelectedItem == null || !Enum.TryParse<Role>(comboRole.SelectedItem.ToString(), out Role role))
            {
                MessageBox.Show("Selecione um papel válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _userService.Register(email, password, role);
            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEmail.Clear();
            txtPassword.Clear();
            comboRole.SelectedIndex = 0;
        }
    }
}
