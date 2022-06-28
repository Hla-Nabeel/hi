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
    public partial class Formreports : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-697A2GP;Initial Catalog=HotelF;Integrated Security=True");
        public Formreports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Floor.floor_name,Room.room_name, Customer.customer_name, Booking.booking_id, Booking.booking_status, Payment.payment_cost FROM Room INNER JOIN Booking ON Room.room_id = Booking.room_id INNER JOIN Payment ON Booking.booking_id = Payment.booking_id INNER JOIN Customer ON Booking.customer_id = Customer.customer_id INNER JOIN Floor ON Room.floor_id = Floor.floor_id where Booking.booking_status='Definite' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Floor.floor_name,Room.room_name, Customer.customer_name, Booking.booking_id, Booking.booking_status, Payment.payment_cost FROM Room INNER JOIN Booking ON Room.room_id = Booking.room_id INNER JOIN Payment ON Booking.booking_id = Payment.booking_id INNER JOIN Customer ON Booking.customer_id = Customer.customer_id INNER JOIN Floor ON Room.floor_id = Floor.floor_id where   Customer.customer_name like '" + textBoxsearch.Text.ToString() + "%' or Floor.floor_name like '" +textBoxsearch.Text.ToString()+"%'", con);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Customer.customer_name, Nationality.national_type, Phone.phone_number, Verification.ve_type FROM Customer INNER JOIN Nationality ON Customer.national_id = Nationality.national_id INNER JOIN Phone ON Customer.phon_id = Phone.phon_id INNER JOIN Verification ON Customer.ver_id = Verification.ver_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Room.room_name, Room.room_type, Room.number_bed, Type.type_name, Floor.floor_name FROM Room INNER JOIN Type ON Room.type_id = Type.type_id INNER JOIN Floor ON Room.floor_id = Floor.floor_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Floor.floor_name,Room.room_name, Customer.customer_name, Booking.booking_id, Booking.booking_status, Payment.payment_cost FROM Room INNER JOIN Booking ON Room.room_id = Booking.room_id INNER JOIN Payment ON Booking.booking_id = Payment.booking_id INNER JOIN Customer ON Booking.customer_id = Customer.customer_id INNER JOIN Floor ON Room.floor_id = Floor.floor_id where Booking.booking_status='Canceled' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            room_report room = new room_report();
            room.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form3customer customer = new form3customer();
            customer.Show();
        }
    }
}
