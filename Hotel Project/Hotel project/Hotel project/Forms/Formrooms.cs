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
    public partial class Formrooms : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-697A2GP;Initial Catalog=HotelF;Integrated Security=True");

        public Formrooms()
        {
            InitializeComponent();
            BindGridView();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Floor values(@floor_id,@floor_name)", con);
                cmd1.Parameters.AddWithValue("@floor_id", int.Parse(textBoxfloorid.Text));
                cmd1.Parameters.AddWithValue("@floor_name", comboBoxflloon.Text);
                int a = cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("insert into Type values(@type_id,@type_name)", con);
                cmd2.Parameters.AddWithValue("@type_id", int.Parse(textBoxsrvid.Text));
                if (radioButtonNormal.Checked == true)
                {
                    cmd2.Parameters.AddWithValue("@type_name", radioButtonNormal.Text);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@type_name", radioButtonVIP.Text);
                }
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("insert into Room values(@room_name,@room_type,@number_bed,@floor_id,@type_id)", con);
                cmd3.Parameters.AddWithValue("@room_name", textroomnumber.Text);
                cmd3.Parameters.AddWithValue("@room_type", comboBoxroomtype.Text);
                cmd3.Parameters.AddWithValue("@number_bed", textBoxbednumber.Text);
                cmd3.Parameters.AddWithValue("@floor_id", int.Parse(textBoxfloorid.Text));
                cmd3.Parameters.AddWithValue("@type_id", int.Parse(textBoxsrvid.Text));
                cmd3.ExecuteNonQuery();
                MessageBox.Show("successfully inserted");
                BindGridView();
                con.Close();

                textBoxfloorid.Text = "";
                comboBoxflloon.Text = "";
                textBoxsrvid.Text = "";
                radioButtonNormal.Checked = false;
                radioButtonVIP.Checked = false;
                textroomnumber.Text = "";
                comboBoxroomtype.Text = "";
                textBoxbednumber.Text = "";
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
            string query = "select * from Room";
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
                SqlCommand cmd1 = new SqlCommand("update  Floor set  floor_name=@floor_name where floor_id=@floor_id", con);
                cmd1.Parameters.AddWithValue("@floor_id", int.Parse(textBoxfloorid.Text));
                cmd1.Parameters.AddWithValue("@floor_name", comboBoxflloon.Text);
                int a = cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update  Type set  type_name=@type_name where type_id=@type_id", con);
                cmd2.Parameters.AddWithValue("@type_id", int.Parse(textBoxsrvid.Text));
                if (radioButtonNormal.Checked == true)
                {
                    cmd2.Parameters.AddWithValue("@type_name", radioButtonNormal.Text);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@type_name", radioButtonVIP.Text);
                }
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("UPDATE Room SET room_name = @room_name,room_type= @room_type,number_bed=@number_bed WHERE room_id=@room_id", con);
                cmd3.Parameters.AddWithValue("@room_id", textBox1.Text);
                cmd3.Parameters.AddWithValue("@room_name", textroomnumber.Text);
                cmd3.Parameters.AddWithValue("@room_type", comboBoxroomtype.Text);
                cmd3.Parameters.AddWithValue("@number_bed", textBoxbednumber.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("successfully update");
                BindGridView();
                con.Close();

                textBox1.Text = "";
                textBoxfloorid.Text = "";
                comboBoxflloon.Text = "";
                textBoxsrvid.Text = "";
                radioButtonNormal.Checked = false;
                radioButtonVIP.Checked = false;
                textroomnumber.Text = "";
                comboBoxroomtype.Text = "";
                textBoxbednumber.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            con.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textroomnumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxroomtype.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxbednumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxfloorid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxsrvid.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Room where room_name like '" + textBoxsearch.Text.ToString() + "%'", con);
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
    }
}

