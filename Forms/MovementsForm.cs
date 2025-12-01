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
    public partial class MovementsForm : Form
    {
        private readonly User _user;
        public MovementsForm(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            InitializeComponent();
        }

        private void MovementsForm_Load(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void RefreshLists()
        {
            try
            {
                var entries = Program.EntryService.GetAll(_user)
                    .Select(en => new { en.Id, en.ProductId, en.Quantity, Date = en.Date.ToString("g"), en.RegisteredByUserEmail, en.Description })
                    .ToList();
                dgvEntries.DataSource = entries;
            }
            catch (UnauthorizedAccessException)
            {
                dgvEntries.DataSource = null;
            }

            try
            {
                var exits = Program.ExitService.GetAll(_user)
                    .Select(ex => new { ex.Id, ex.ProductId, ex.Quantity, Date = ex.Date.ToString("g"), ex.RegisteredByUserEmail, ex.Description })
                    .ToList();
                dgvExits.DataSource = exits;
            }
            catch (UnauthorizedAccessException)
            {
                dgvExits.DataSource = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
