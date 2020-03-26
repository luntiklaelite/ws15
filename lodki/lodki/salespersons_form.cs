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
    public partial class salespersons_form : Form
    {
        DbModel mod;
        public salespersons_form()
        {
            InitializeComponent();
            mod = DbModel.init();
            reloadGrid();
        }
        private void reloadGrid()
        {
            grid_users.Rows.Clear();
            foreach (SalePerson us in mod.salePersons)
            {
                int d = grid_users.Rows.Add(us.saleperson_id, us.firstName, us.familyName);
                grid_users.Rows[d].Tag = us;
            }
        }
    }
}
