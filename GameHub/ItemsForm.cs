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

namespace GameHub
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog='C:\Users\Danish Nisar\OneDrive\Documents\Gamedb.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from Itemtb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNameTb.Text == "" || ItemNumTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill All The Data");
            }
            else
            {
                Con.Open();
                string query = "insert into ItemTb1 values(" + ItemNumTb.Text + ",'" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() + "',"+PriceCb.Text+")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNumTb.Text = ItemsGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNameTb.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.SelectedItem = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceCb.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Select The Game to be Deleted");
            }

            else
            {
                Con.Open();
                string query = "delete from ItemTb1 where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                Con.Open();
                string query = "update ItemTb1 set ItemName='" + ItemNameTb.Text + "',Itemcat='" + CatCb.SelectedItem.ToString() + "' where ItemPrice=" + PriceCb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game Successfully Updated");
                Con.Close();
                populate();
            }
        }
    }
}
