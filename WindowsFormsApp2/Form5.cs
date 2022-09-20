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

    public partial class Form5 : Form
    {
        public Form5()
        {
        
        InitializeComponent();

        }


        private void Form5_Load(object sender, EventArgs e)
        {
    }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

                Form2 form2 = this.Owner as Form2;
                if (form2 != null)
                {
                    DataRow nRow = form2.uFKDataSet.Clients.NewRow();
             //  int rc = form2.dataGridView1.RowCount + 1;

                    nRow[0] = textBox1.Text;
                    nRow[1] = textBox2.Text;
                    nRow[2] = textBox3.Text;
                    nRow[3] = textBox4.Text;
                    nRow[4] = textBox5.Text;
                    nRow[5] = textBox6.Text;

                form2.uFKDataSet.Clients.Rows.Add(nRow);
                form2.clientsTableAdapter.Update(form2.uFKDataSet.Clients);
                form2.uFKDataSet.Clients[0].AcceptChanges();
                form2.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
