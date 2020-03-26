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
    public partial class orders_form : Form
    {
        DbModel mod;
        public orders_form()
        {
            InitializeComponent();
            mod = DbModel.init();
            reloadGrid();
        }
      
        private void reloadGrid()
        {
            grid_users.Rows.Clear();
            foreach (Order us in mod.orders)
            {
                int d = grid_users.Rows.Add(us.order_id,us.date, us.deliveryAddress, us.city, us.boat_id.BasePrice, us.customer_id, us.saleperson_);
                grid_users.Rows[d].Tag = us;
            }
        }
    }
}
