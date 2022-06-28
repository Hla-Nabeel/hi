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
    public partial class Formbooking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-697A2GP;Initial Catalog=HotelF;Integrated Security=True");
        public Formbooking()
        {
            InitializeComponent();
            BindGridView();
        }
        //combox customer
        private void comcustomer()
        {
            con.Open();
            string q = "select customer_id from Customer";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxcustomer.Items.Add(dr["customer_id"].ToString());
                comboBoxcustomer.DisplayMember = (dr["customer_id"].ToString());

            }
            con.Close();
        }
        //combox room
        private void comroom()
        {
            con.Open();
            string q = "select room_id from Room";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxroom.Items.Add(dr["room_id"].ToString());
                comboBoxroom.DisplayMember = (dr["room_id"].ToString());

            }
            con.Close();
        }
        //
        void BindGridView()
        {
            string query = "select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //
        private void Formbooking_Load(object sender, EventArgs e)
        {
            comcustomer();
            comroom();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Date values(@date_id,@date_from,@date_to)", con);
                cmd1.Parameters.AddWithValue("@date_id", int.Parse(textBoxdateid.Text));
                cmd1.Parameters.AddWithValue("@date_from", textBoxdatefrom.Text);
                cmd1.Parameters.AddWithValue("@date_to", textBoxdateto.Text);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("insert into Booking values(@booking_status,@date_id,@customer_id,@room_id)", con);
                if (radioButtondefinite.Checked == true)
                {
                    cmd2.Parameters.AddWithValue("@booking_status", radioButtondefinite.Text);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@booking_status", radioButtoncanceled.Text);
                }
              
                cmd2.Parameters.AddWithValue("@date_id", int.Parse(textBoxdateid.Text));
                cmd2.Parameters.AddWithValue("@customer_id",int.Parse(comboBoxcustomer.Text));
                cmd2.Parameters.AddWithValue("@room_id", int.Parse(comboBoxroom.Text)); 
                cmd2.ExecuteNonQuery();
                MessageBox.Show("successfully inserted");
                BindGridView();
                con.Close();

                textBoxdateid.Text = "";
                textBoxdatefrom.Text = "";
                textBoxdateto.Text = "";
                radioButtondefinite.Checked = false;
                radioButtoncanceled.Checked = false;
                comboBoxcustomer.Text = "";
                comboBoxroom.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("update  Date set  date_from=@date_from,date_to=@date_to where date_id=@date_id", con);
                cmd1.Parameters.AddWithValue("@date_id", int.Parse(textBoxdateid.Text));
                cmd1.Parameters.AddWithValue("@date_from", textBoxdatefrom.Text);
                cmd1.Parameters.AddWithValue("@date_to", textBoxdateto.Text);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("UPDATE Booking SET booking_status = @booking_status WHERE booking_id=@booking_id", con);
                if (radioButtondefinite.Checked == true)
                {
                    cmd2.Parameters.AddWithValue("@booking_status", radioButtondefinite.Text);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@booking_status", radioButtoncanceled.Text);
                }
               
                cmd2.Parameters.AddWithValue("@booking_id", textbooking_id.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("successfully update");
                BindGridView();
                con.Close();

                textbooking_id.Text = "";
                textBoxdateid.Text = "";
                textBoxdatefrom.Text = "";
                textBoxdateto.Text = "";
                radioButtondefinite.Checked = false;
                radioButtoncanceled.Checked = false;
                comboBoxcustomer.Text = "";
                comboBoxroom.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            

            

            con.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textbooking_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "Definite")
            {
                
                radioButtondefinite.Checked = true;
            }
        
            
            else
            {
                dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                radioButtoncanceled.Checked = true;
            }
            textBoxdateid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxcustomer.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxroom.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Booking where booking_status like '" + textBoxsearch.Text.ToString() + "%'", con);
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

        private void comboBoxcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
