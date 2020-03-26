using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using System.Windows.Forms;

namespace lodki
{
    public partial class loginForm : Form
    {
        DbModel mod;
        int popitki = 3;
        public loginForm()
        {
            InitializeComponent();
            mod = DbModel.init();
            
            mod.Database.CreateIfNotExists();
        }

        private void but_auth_Click(object sender, EventArgs e)
        {
            popitki--;
            if ((DateTime.Now - Properties.Settings.Default.dateBlock).TotalSeconds < Properties.Settings.Default.blockTime - 20 )
            {
                MessageBox.Show("Система заблокирована ещё на " + (int)(Properties.Settings.Default.blockTime - (DateTime.Now - Properties.Settings.Default.dateBlock).TotalSeconds - 20) + " секунд.");
                return;
            }
            if (fie_login.Text == "" || fie_pass.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            User user;
            try
            {
                user = mod.users.Where(u => u.login == fie_login.Text).Where(u => u.pass == fie_pass.Text).First();
            }
            catch (Exception)
            {
                if (popitki < 1)
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль!\nСистема авторизации заблокирована на " + Properties.Settings.Default.blockTime + " секунд");
                    Properties.Settings.Default.dateBlock = DateTime.Now;
                    Properties.Settings.Default.blockTime += 20;
                    Properties.Settings.Default.Save();
                    popitki = 3;
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль!\nСистема авторизации заблокирована на " + Properties.Settings.Default.blockTime + " секунд через " + popitki + " попытки.");
                }
                return;
            }
            popitki = 3;
            Properties.Settings.Default.blockTime = 15;
            Properties.Settings.Default.Save();
            if ((DateTime.Now - user.lastLogin).TotalDays > 30)
            {
                MessageBox.Show("Ваш аккаунт был заблокирован из-за того, что вы не заходили в него месяц!");
                return;
            }
            if ((DateTime.Now - user.lastPass).TotalDays >= 14)
            {
                changePassForm form = new changePassForm(user);
                form.ShowDialog();
                if (form.DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    user = form.user;
                    user.lastPass = DateTime.Now;
                }
                else
                    return;
            }
            user.lastLogin = DateTime.Now;
            mod.SaveChanges();
            MainClass.localuser = user;
            mainForm form1 = new mainForm();
            form1.Show();
            Hide();
        }

    }
}
