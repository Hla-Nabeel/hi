namespace Hotel_project.Forms
{
    partial class Formbooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbooking_id = new System.Windows.Forms.TextBox();
            this.radioButtondefinite = new System.Windows.Forms.RadioButton();
            this.radioButtoncanceled = new System.Windows.Forms.RadioButton();
            this.comboBoxcustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxroom = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxdateid = new System.Windows.Forms.TextBox();
            this.textBoxdatefrom = new System.Windows.Forms.TextBox();
            this.textBoxdateto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking_status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room_id";
            // 
            // textbooking_id
            // 
            this.textbooking_id.Location = new System.Drawing.Point(151, 93);
            this.textbooking_id.Name = "textbooking_id";
            this.textbooking_id.ReadOnly = true;
            this.textbooking_id.Size = new System.Drawing.Size(140, 20);
            this.textbooking_id.TabIndex = 5;
            // 
            // radioButtondefinite
            // 
            this.radioButtondefinite.AutoSize = true;
            this.radioButtondefinite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtondefinite.Location = new System.Drawing.Point(151, 148);
            this.radioButtondefinite.Name = "radioButtondefinite";
            this.radioButtondefinite.Size = new System.Drawing.Size(73, 23);
            this.radioButtondefinite.TabIndex = 6;
            this.radioButtondefinite.TabStop = true;
            this.radioButtondefinite.Text = "Definite";
            this.radioButtondefinite.UseVisualStyleBackColor = true;
            // 
            // radioButtoncanceled
            // 
            this.radioButtoncanceled.AutoSize = true;
            this.radioButtoncanceled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtoncanceled.Location = new System.Drawing.Point(253, 148);
            this.radioButtoncanceled.Name = "radioButtoncanceled";
            this.radioButtoncanceled.Size = new System.Drawing.Size(84, 23);
            this.radioButtoncanceled.TabIndex = 7;
            this.radioButtoncanceled.TabStop = true;
            this.radioButtoncanceled.Text = "Canceled";
            this.radioButtoncanceled.UseVisualStyleBackColor = true;
            // 
            // comboBoxcustomer
            // 
            this.comboBoxcustomer.FormattingEnabled = true;
            this.comboBoxcustomer.Location = new System.Drawing.Point(151, 254);
            this.comboBoxcustomer.Name = "comboBoxcustomer";
            this.comboBoxcustomer.Size = new System.Drawing.Size(140, 21);
            this.comboBoxcustomer.TabIndex = 10;
            this.comboBoxcustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxcustomer_SelectedIndexChanged);
            // 
            // comboBoxroom
            // 
            this.comboBoxroom.FormattingEnabled = true;
            this.comboBoxroom.Location = new System.Drawing.Point(151, 312);
            this.comboBoxroom.Name = "comboBoxroom";
            this.comboBoxroom.Size = new System.Drawing.Size(140, 21);
            this.comboBoxroom.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 306);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(520, 29);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(240, 20);
            this.textBoxsearch.TabIndex = 13;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(100)))));
            this.button1.Location = new System.Drawing.Point(151, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(100)))));
            this.button2.Location = new System.Drawing.Point(324, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxdateid
            // 
            this.textBoxdateid.Location = new System.Drawing.Point(151, 203);
            this.textBoxdateid.Name = "textBoxdateid";
            this.textBoxdateid.Size = new System.Drawing.Size(62, 20);
            this.textBoxdateid.TabIndex = 17;
            // 
            // textBoxdatefrom
            // 
            this.textBoxdatefrom.Location = new System.Drawing.Point(234, 205);
            this.textBoxdatefrom.Name = "textBoxdatefrom";
            this.textBoxdatefrom.Size = new System.Drawing.Size(70, 20);
            this.textBoxdatefrom.TabIndex = 18;
            // 
            // textBoxdateto
            // 
            this.textBoxdateto.Location = new System.Drawing.Point(324, 204);
            this.textBoxdateto.Name = "textBoxdateto";
            this.textBoxdateto.Size = new System.Drawing.Size(71, 20);
            this.textBoxdateto.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "To";
            // 
            // Formbooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1082, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxdateto);
            this.Controls.Add(this.textBoxdatefrom);
            this.Controls.Add(this.textBoxdateid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxroom);
            this.Controls.Add(this.comboBoxcustomer);
            this.Controls.Add(this.radioButtoncanceled);
            this.Controls.Add(this.radioButtondefinite);
            this.Controls.Add(this.textbooking_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formbooking";
            this.Text = "Formbooking";
            this.Load += new System.EventHandler(this.Formbooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbooking_id;
        private System.Windows.Forms.RadioButton radioButtondefinite;
        private System.Windows.Forms.RadioButton radioButtoncanceled;
        private System.Windows.Forms.ComboBox comboBoxcustomer;
        private System.Windows.Forms.ComboBox comboBoxroom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxdateid;
        private System.Windows.Forms.TextBox textBoxdatefrom;
        private System.Windows.Forms.TextBox textBoxdateto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}