﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GameHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog='C:\Users\Danish Nisar\OneDrive\Documents\Gamedb.mdf';Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserOrder uorder =new UserOrder();
            //uorder.Show();
            //this.Hide();

            if(UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Username Or Password Missing!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTb1 where Uname='"+UnameTb.Text+"' and Upassword='"+PasswordTb.Text+"'", Con);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    UserOrder uorder = new UserOrder();
                    uorder.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }
    }
}
