using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hotel_project
{
    public partial class Form2 : Form
    {
        private Button currentButton;
        private Form activeForm;
        //constructor
        public Form2()
        {
            InitializeComponent();
            btnclosedchildform.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL",EntryPoint="ReleaseCapture")]
        private extern static void ReleaseCapture();

         [DllImport("user32.DLL",EntryPoint="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wParam,int Iparam);
        private void ActiveButton(object btnsender) {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender) {
                    DisableButton();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = Color.FromArgb(51, 199, 225);
                    currentButton.ForeColor = Color.FromArgb(99, 98, 100);
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panellogo.BackColor = Color.FromArgb(51, 199, 225);
                    btnclosedchildform.Visible = true;
                }
            }

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(234, 233, 232);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender) {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktoppanel.Controls.Add(childForm);
            this.panelDesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lbtitle.Text = childForm.Text;
           




            
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormCustomer(), sender);
           }

        


        private void btnpayment_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formpayment(), sender);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formreports(), sender);
        }

        private void btnclosedchildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            Lbtitle.Text = "Hotel Booking Systme";
            panelTitleBar.BackColor = Color.FromArgb(51, 199, 225);
            panellogo.BackColor = Color.FromArgb(225, 223, 221);
            currentButton = null;
            btnclosedchildform.Visible = false;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formrooms(), sender);
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formbooking(), sender);
        }

        private void Lbtitle_Click(object sender, EventArgs e)
        {

        }
       

            


        }

        
    }

