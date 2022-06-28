using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_project
{
    public partial class form3customer : Form
    {
        public form3customer()
        {
            InitializeComponent();
        }

        private void form3customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dscustomer.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Dscustomer.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
