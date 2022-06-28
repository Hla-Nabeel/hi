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
    public partial class room_report : Form
    {
        public room_report()
        {
            InitializeComponent();
        }

        private void room_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dsroom.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Dsroom.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
