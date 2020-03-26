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
    public partial class partners_form : Form
    {
        DbModel mod;
        public partners_form()
        {
            InitializeComponent();
            mod = DbModel.init();
            reloadGrid();
        } 
        private void reloadGrid()
        {
            grid_users.Rows.Clear();
            foreach (Partner us in mod.partners)
            {
                int d = grid_users.Rows.Add(us.partner_id, us.name, us.address, us.city);
                grid_users.Rows[d].Tag = us;
            }
        }
    }
}
