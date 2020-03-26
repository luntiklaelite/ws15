using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lodki
{
    public partial class usersForm : Form
    {
        DbModel mod;
        public usersForm()
        {
            InitializeComponent();
            mod = DbModel.init();
            reloadGrid();
        }
        private void reloadGrid()
        {
            grid_users.Rows.Clear();
            foreach (User us in mod.users)
            {
                int d = grid_users.Rows.Add(us.login, us.isAdmin ? "Администратор" : "Пользователь", us.lastLogin, us.lastPass);
                grid_users.Rows[d].Tag = us;
            }
        }

        private void but_addUser_Click(object sender, EventArgs e)
        {
            usersForms.addForm form = new usersForms.addForm();
            form.ShowDialog();
            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Успешно!");
            reloadGrid();
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DbModel.init().users.Remove((User)grid_users.SelectedRows[0].Tag);
                DbModel.init().SaveChanges();
                reloadGrid();
            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if(grid_users.SelectedRows.Count < 1)
                return;
            usersForms.editForm form = new usersForms.editForm((User)grid_users.SelectedRows[0].Tag);
            form.ShowDialog();
            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Успешно!");
                reloadGrid();
                return;
            }
        }
    }
}
