using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace Hotel_project.Forms
{
    public partial class FormCustomer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-697A2GP;Initial Catalog=HotelF;Integrated Security=True");
        public FormCustomer()
        {
            InitializeComponent();
            BindGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Nationality values(@national_id,@national_type)", con);
                cmd1.Parameters.AddWithValue("@national_id", int.Parse(txtNaid.Text));
                cmd1.Parameters.AddWithValue("@national_type", txtNatype.Text);
                int a = cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("insert into Phone values(@phon_id,@phone_number)", con);
                cmd2.Parameters.AddWithValue("@phon_id", int.Parse(txtphoneid.Text));
                Regex r = new Regex(@"^[0-9]");
                if (r.IsMatch(txtnumber.Text))
                {
                    cmd2.Parameters.AddWithValue("@phone_number", txtnumber.Text);
                   
                }
                else {
                    MessageBox.Show("Invalid phone number");
                }
                cmd2.ExecuteNonQuery();


                SqlCommand cmd3 = new SqlCommand("insert into Verification values(@ver_id,@ve_type,@ve_serialnumber)", con);
                cmd3.Parameters.AddWithValue("@ver_id", int.Parse(txtvid.Text));
                cmd3.Parameters.AddWithValue("@ve_type", comvtype.Text);
                Regex rv = new Regex(@"^[0-8]");
                if (rv.IsMatch(txtvserial.Text))
                {
                    cmd3.Parameters.AddWithValue("@ve_serialnumber", txtvserial.Text);
                }
                else
                {
                    MessageBox.Show("Invalid serial number");
                }
                cmd3.ExecuteNonQuery();


                SqlCommand cmd4 = new SqlCommand("insert into Customer values(@customer_name,@national_id,@phon_id,@ver_id)", con);
                cmd4.Parameters.AddWithValue("@customer_name", txtname.Text);
                cmd4.Parameters.AddWithValue("@national_id", int.Parse(txtNaid.Text));
                cmd4.Parameters.AddWithValue("@phon_id", int.Parse(txtphoneid.Text));
                cmd4.Parameters.AddWithValue("@ver_id", int.Parse(txtvid.Text));
                cmd4.ExecuteNonQuery();
                MessageBox.Show("successfully inserted");
                BindGridView();
                con.Close();

                txtNaid.Text = "";
                txtNatype.Text = "";
                txtphoneid.Text = "";
                txtnumber.Text = "";
                txtvid.Text = "";
                comvtype.Text = "";
                txtvserial.Text = "";
                txtname.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            con.Close();
        }

        //data gridview
        void BindGridView()
        {
            string query = "select * from Customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update  Nationality set  national_type=@national_type where national_id=@national_id ", con);
                cmd1.Parameters.AddWithValue("@national_id", int.Parse(txtNaid.Text));
                cmd1.Parameters.AddWithValue("@national_type", txtNatype.Text);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update Phone set  phone_number=@phone_number where phon_id=@phon_id", con);
                cmd2.Parameters.AddWithValue("@phon_id", int.Parse(txtphoneid.Text));
                Regex r = new Regex(@"^[0-9]");
                if (r.IsMatch(txtnumber.Text))
                {
                    cmd2.Parameters.AddWithValue("@phone_number", txtnumber.Text);

                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
                cmd2.ExecuteNonQuery();


                SqlCommand cmd3 = new SqlCommand("update  Verification set ve_type=@ve_type, ve_serialnumber=@ve_serialnumber where  ver_id= @ver_id", con);
                cmd3.Parameters.AddWithValue("@ver_id", int.Parse(txtvid.Text));
                cmd3.Parameters.AddWithValue("@ve_type", comvtype.Text);
                Regex rv = new Regex(@"^[0-8]");
                if (rv.IsMatch(txtvserial.Text))
                {
                    cmd3.Parameters.AddWithValue("@ve_serialnumber", txtvserial.Text);
                }
                else
                {
                    MessageBox.Show("Invalid serial number");
                }
              
                cmd3.ExecuteNonQuery();


                SqlCommand cmd4 = new SqlCommand("UPDATE [dbo].[Customer] SET [customer_name] = @customer_name WHERE customer_id=@customer_id", con);
                cmd4.Parameters.AddWithValue("@customer_id", textBox1.Text);
                cmd4.Parameters.AddWithValue("@customer_name", txtname.Text);
                cmd4.ExecuteNonQuery();
               




                MessageBox.Show("update succesfully");
                BindGridView();
                textBox1.Text = "";
                txtNaid.Text = "";
                txtNatype.Text = "";
                txtphoneid.Text = "";
                txtnumber.Text = "";
                txtvid.Text = "";
                comvtype.Text = "";
                txtvserial.Text = "";
                txtname.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtNaid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtphoneid.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtvid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Customer where customer_name like '" + txtsearch.Text.ToString() + "%'", con);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
