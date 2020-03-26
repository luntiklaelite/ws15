using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lodki.usersForms
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            if (fie_login.Text == "" || fie_pass.Text == "" || fie_role.SelectedIndex < 0 || fie_role.SelectedIndex > 1)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            bool role;
            if(fie_role.SelectedIndex == 1)
                role = true;
            else
                role = false;
            User user = new User { login = fie_login.Text, pass = fie_pass.Text, isAdmin = role, lastLogin = DateTime.Now, lastPass = DateTime.Now };
            DbModel.init().users.Add(user);
            DbModel.init().SaveChanges();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void fie_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fie_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fie_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
