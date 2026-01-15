using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace project_front
{
    public partial class book : Form
    {
        // ✅ CLASS LEVEL CONNECTION (VERY IMPORTANT)
        SqlConnection con = new SqlConnection(
            @"Data Source=DESKTOP-0EVM83E\SQLEXPRESS;Initial Catalog=BookStoreDB;Integrated Security=True;");

        int selectedRowIndex = -1;

        public book()
        {
            InitializeComponent();
        }

        // ✅ FORM LOAD
        private void book_Load(object sender, EventArgs e)
        {
            dataGridViewBook.AutoGenerateColumns = true; 
            LoadBooks();
        }

        // ✅ LOAD BOOKS FROM DATABASE
        private void LoadBooks()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBook.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e, string v)
        {
           
            
        }   

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void CatCbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            BTitleTb.Text = "";
            BautTb.Text = "";
            BCatCb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            selectedRowIndex = -1;
        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dataGridViewBook.Rows.RemoveAt(selectedRowIndex);
                ResetForm();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[selectedRowIndex];
                row.Cells[0].Value = BTitleTb.Text;
                row.Cells[1].Value = BautTb.Text;
                row.Cells[2].Value = BCatCb.Text;
                row.Cells[3].Value = QtyTb.Text;
                row.Cells[4].Value = PriceTb.Text;
                ResetForm();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0EVM83E\SQLEXPRESS;Initial Catalog=BookStoreDB;Integrated Security=True;");
            {
                if (BTitleTb.Text == "" || BautTb.Text == "" ||
                    BCatCb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Books (Title, Author, Category, Quantity, Price) " +
                        "VALUES (@t, @a, @c, @q, @p)", con);

                    cmd.Parameters.AddWithValue("@t", BTitleTb.Text);
                    cmd.Parameters.AddWithValue("@a", BautTb.Text);
                    cmd.Parameters.AddWithValue("@c", BCatCb.Text);
                    cmd.Parameters.AddWithValue("@q", int.Parse(QtyTb.Text));
                    cmd.Parameters.AddWithValue("@p", decimal.Parse(PriceTb.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Added Successfully");
                    LoadBooks();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }


        }



        private void PriceTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BCatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BautTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTitleTb_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*user use = new user();
            use.Show();
            this.Hide();*/
        }
    }
}
