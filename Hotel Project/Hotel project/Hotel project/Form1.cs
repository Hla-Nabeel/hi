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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       

       

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            picuser.BackgroundImage = Properties.Resources.hoel2;
            panel1.BackColor = Color.FromArgb(51, 199, 225);
            textBox1.ForeColor = Color.FromArgb(51, 199, 225);

            picpass.BackgroundImage = Properties.Resources.download;
            panel2.BackColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            picpass.BackgroundImage = Properties.Resources.hoel2;
            panel2.BackColor = Color.FromArgb(51, 199, 225);
            textBox2.ForeColor = Color.FromArgb(51, 199, 225);

            picuser.BackgroundImage = Properties.Resources.download;
            panel1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Black;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "hla")
            {
                if (textBox2.Text == "123Hla")
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error : please enter the correct information");
                }

            }
            else
            {
                MessageBox.Show("Error : please enter the correct information");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
       
       

        
    }
}
