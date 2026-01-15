using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_front
{
    public partial class user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0EVM83E\SQLEXPRESS;Initial Catalog=BookStoreDB;Integrated Security=True;");
        int selectedRowIndex = -1;

        double grandTotal = 0;
        public user()
        {
            InitializeComponent();
        }

        // ✅ Form Load - Load all books to display for user
        private void user_Load(object sender, EventArgs e)
        {
            LoadBooksForUser();
        }
        private void LoadBooksForUser()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT BookId, Title, Author, Category, Quantity, Price FROM Books", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBooks_CellContentClick.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBooks_CellContentClick.Rows[selectedRowIndex];
                CNTb.Text = row.Cells[0].Value.ToString();
                BTTb.Text = row.Cells[1].Value.ToString();
                QTb.Text = row.Cells[3].Value.ToString();
                PTb.Text = row.Cells[4].Value.ToString();

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            // Validation
            if (string.IsNullOrEmpty(CNTb.Text) || string.IsNullOrEmpty(BTTb.Text) || string.IsNullOrEmpty(QTb.Text))
            {
                MessageBox.Show("Please select a book and enter quantity!");
                return;
            }
            int qty = int.Parse(QTb.Text);
            decimal price = decimal.Parse(PTb.Text);
            decimal total = qty * price;

            // Add to Bill DataGridView
            dataGridViewBooks_CellContentClick.Rows.Add(CNTb.Text, BTTb.Text, qty, price, total);


            // Clear inputs
            CNTb.Clear();
            BTTb.Clear();
            QTb.Clear();
            PTb.Clear();

           

        }

           


    
       




        private void RBtn_Click(object sender, EventArgs e)
        {
            CNTb.Clear();
            BTTb.Clear();
            QTb.Clear();
            PTb.Clear();
            CNTb.Focus();

            if (selectedRowIndex >= 0)
            {
                dataGridViewBooks_CellContentClick.Rows.RemoveAt(selectedRowIndex);
                // ResetForm();
            }
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewBooks_CellContentClick.Rows[e.RowIndex];

            CNTb.Text = row.Cells["BookId"].Value.ToString();
            BTTb.Text = row.Cells["Title"].Value.ToString();
            QTb.Text = row.Cells["Quantity"].Value.ToString();
            PTb.Text = row.Cells["Price"].Value.ToString();

            selectedRowIndex = e.RowIndex;
        }

        private void CNTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CNTb.Text)) return;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Title, Price FROM Books WHERE BookId = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(CNTb.Text));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    BTTb.Text = reader["Title"].ToString();
                    PTb.Text = reader["Price"].ToString();
                    QTb.Text = "1";
                }
                else
                {
                    MessageBox.Show("Book ID not found!");
                    BTTb.Clear();
                    PTb.Clear();
                    QTb.Clear();
                }
                con.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void lblT_Click(object sender, EventArgs e)
        {
            /* decimal grandTotal = 0;

             foreach (DataGridViewRow row in dataGridViewBooks_CellContentClick.Rows)
             {
                 if (!row.IsNewRow)
                 {
                     grandTotal += Convert.ToDecimal(row.Cells["Total"].Value);
                 }
             }

             lblT.Text = "Total : " + grandTotal.ToString("0.00");*/
            grandTotal = 0;

            foreach (DataGridViewRow row in dataGridViewBooks_CellContentClick.Rows)
            {
                if (!row.IsNewRow)
                {
                    grandTotal += Convert.ToDouble(row.Cells["Total"].Value);
                }
            }

            lblT.Text = "Total : " + grandTotal.ToString("0.00");
        }

        private void PrBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks_CellContentClick.Rows.Count == 0)
            {
                MessageBox.Show("No items in the bill!");
                return;
            }

            try
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridViewBooks_CellContentClick.Rows)
                {
                    if (row.IsNewRow) continue;

                    int bookId = int.Parse(row.Cells["BookId"].Value.ToString());
                    string bookTitle = row.Cells["Title"].Value.ToString();
                    int qty = int.Parse(row.Cells["Quantity"].Value.ToString());
                    decimal price = decimal.Parse(row.Cells["Price"].Value.ToString());
                    decimal total = decimal.Parse(row.Cells["Total"].Value.ToString());

                    // 1️⃣ Save to Sales table
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Sales (CustomerName, BookTitle, Quantity, Price) VALUES (@c, @b, @q, @p)", con);

                    cmd.Parameters.AddWithValue("@c", "User"); // or actual customer name
                    cmd.Parameters.AddWithValue("@b", bookTitle);
                    cmd.Parameters.AddWithValue("@q", qty);
                    cmd.Parameters.AddWithValue("@p", total);

                    cmd.ExecuteNonQuery();

                    // 2️⃣ Reduce stock in Books table
                    SqlCommand cmd2 = new SqlCommand(
                        "UPDATE Books SET Quantity = Quantity - @q WHERE BookId = @id", con);

                    cmd2.Parameters.AddWithValue("@q", qty);
                    cmd2.Parameters.AddWithValue("@id", bookId);
                    cmd2.ExecuteNonQuery();
                }

                con.Close();

                // 3️⃣ Clear Bill and reset
                dataGridViewBooks_CellContentClick.Rows.Clear();
                lblT.Text = "Total : 0.00";
                MessageBox.Show("Bill printed successfully!");

                // 4️⃣ Refresh book list to show updated stock
                LoadBooksForUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
    }
    


       
    




