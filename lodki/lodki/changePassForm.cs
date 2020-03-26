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
    public partial class changePassForm : Form
    {
        public User user;
        public changePassForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void but_smena_Click(object sender, EventArgs e)
        {
            if (fie_old.Text != user.pass)
            {
                MessageBox.Show("Текущий пароль введен не верно!");
                return;
            }
            if (fie_new.Text != fie_reap.Text)
            {
                MessageBox.Show("Новый пароль не совпадает с подтверждением!");
                return;
            }
            user.pass = fie_new.Text;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Hide();
        }
    }
}
