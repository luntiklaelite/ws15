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
    public partial class editForm : Form
    {
        User user;
        public editForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            if (fie_login.Text != "")
                user.login = fie_login.Text;
            if (fie_pass.Text != "")
                user.pass = fie_pass.Text;
            bool role = user.isAdmin;
            if (fie_role.SelectedIndex == 1)
                role = true;
            else if(fie_role.SelectedIndex == 0)
                role = false;
            user.isAdmin = role;
            DbModel.init().SaveChanges();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
