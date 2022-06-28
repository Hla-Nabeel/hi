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
    public partial class reportForm3 : Form
    {
        public reportForm3()
        {
            InitializeComponent();
        }

        private void reportForm3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dspayment.Payment' table. You can move, or remove it, as needed.
            this.PaymentTableAdapter.Fill(this.Dspayment.Payment);

            this.reportViewer1.RefreshReport();
        }
    }
}
