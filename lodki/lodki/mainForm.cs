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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            if (!MainClass.localuser.isAdmin)
            {
                but_uprUsers.Visible = false;
                but_accs.Visible = false;
                but_boats.Visible = false;
                but_contracts.Visible = false;
                but_customers.Visible = false;
                but_fits.Visible = false;
                but_invoices.Visible = false;
                but_orderdetails.Visible = false;
                but_orders.Visible = false;
                but_partners.Visible = false;
                but_salespersons.Visible = false;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void but_uprUsers_Click(object sender, EventArgs e)
        {
            usersForm form = new usersForm();
            form.Show();
        }

        private void but_accs_Click(object sender, EventArgs e)
        {
            accessories_form form = new accessories_form();
            form.Show();
        }

        private void but_boats_Click(object sender, EventArgs e)
        {
            boats_form form = new boats_form();
            form.Show();
        }

        private void but_contracts_Click(object sender, EventArgs e)
        {
            contracts_form form = new contracts_form();
            form.Show();
        }

        private void but_customers_Click(object sender, EventArgs e)
        {
            customers_form form = new customers_form();
            form.Show();
        }

        private void but_fits_Click(object sender, EventArgs e)
        {
            fits_form form = new fits_form();
            form.Show();
        }

        private void but_invoices_Click(object sender, EventArgs e)
        {
            invoices_form form = new invoices_form();
            form.Show();
        }

        private void but_orderdetails_Click(object sender, EventArgs e)
        {
            orderdetails_form form = new orderdetails_form();
            form.Show();
        }

        private void but_orders_Click(object sender, EventArgs e)
        {
            orders_form form = new orders_form();
            form.Show();
        }

        private void but_partners_Click(object sender, EventArgs e)
        {
            partners_form form = new partners_form();
            form.Show();
        }

        private void but_salespersons_Click(object sender, EventArgs e)
        {
            salespersons_form form = new salespersons_form();
            form.Show();
        }
    }
}
