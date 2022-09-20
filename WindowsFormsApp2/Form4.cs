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


namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int selectedRow;

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uFKDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.uFKDataSet.Delivery);
            string connectionString = @"Data Source=LAPTOP-K3DR5Q0N;Initial Catalog=UFK;Integrated Security=True";
            string sql = "SELECT * FROM Delivery";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            uFKDataSet.Delivery.Rows.Add(textBox7.Text, textBox1.Text, textBox3.Text, textBox6.Text, 
                textBox5.Text, textBox4.Text, textBox2.Text);
            dataGridView1.DataSource = uFKDataSet.Delivery;
            deliveryTableAdapter.Update(uFKDataSet.Delivery);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs    e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox7.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox6.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[5].Value.ToString();
            textBox2.Text = row.Cells[6].Value.ToString();

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deliveryTableAdapter.Update(uFKDataSet);
        }
    }
}
