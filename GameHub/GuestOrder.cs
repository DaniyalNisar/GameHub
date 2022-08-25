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
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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

        void filterbycategory()
        {
            Con.Open();
            string query = "select * from Itemtb1 where Itemcat = '" + categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {   timer1.Start(); 
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Genre", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
         //   Datelbl.Text = DateTime.Now.ToString();
        }

        int num = 0;
        int price, total;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OrderNumTb.Text == "")
            {
                MessageBox.Show("Order Number Missing");
                return;
            }
            Con.Open();
            string query = "insert into OrdersTb1 values(" + OrderNumTb.Text + ",'" + Datelbl.Text + "','" + SellerNameTb.Text + "',"+LabelAmnt.Text+")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created");
            Con.Close();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter Quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Game to be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            LabelAmnt.Text =""+sum;
        }

        private void categorycb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
