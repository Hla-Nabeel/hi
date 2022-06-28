using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_project.Forms
{
    public partial class Formpayment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-697A2GP;Initial Catalog=HotelF;Integrated Security=True");
        public Formpayment()
        {
            InitializeComponent();
            BindGridView();
        }
       
       
        private void Formpayment_Load(object sender, EventArgs e)
        {
            combooking();
        }

        private void combooking()
        {
            con.Open();
            string q = "select booking_id from Booking";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxbid.Items.Add(dr["booking_id"].ToString());
                comboBoxbid.DisplayMember = (dr["booking_id"].ToString());

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Payment values(@Payment_cost,@booking_id)", con);
                cmd1.Parameters.AddWithValue("@Payment_cost",textBoxpaycost.Text);
                cmd1.Parameters.AddWithValue("@booking_id", int.Parse(comboBoxbid.Text));
                cmd1.ExecuteNonQuery();

                
            
                MessageBox.Show("successfully inserted");
                BindGridView();
                con.Close();

                textBoxpaycost.Text = "";
                comboBoxbid.Text = "";
                textBoxpayid.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            con.Close();
        }


        //
        void BindGridView()
        {
            string query = "select * from Payment";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxpayid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxpaycost.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           comboBoxbid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("update  Payment set  Payment_cost=@Payment_cost,booking_id=@booking_id where payment_id=@payment_id", con);
                cmd1.Parameters.AddWithValue("@payment_id", int.Parse(textBoxpayid.Text));
                cmd1.Parameters.AddWithValue("@Payment_cost", textBoxpaycost.Text);
                cmd1.Parameters.AddWithValue("@booking_id", int.Parse(comboBoxbid.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("successfully update");
                BindGridView();
                con.Close();

                textBoxpayid.Text = "";
                textBoxpaycost.Text = "";
                comboBoxbid.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }




            con.Close();
        }

        private void textBoxserach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Payment where booking_id like '" + textBoxserach.Text.ToString() + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportForm3 form3 = new reportForm3();
            form3.Show();
        }
        
    }
}
