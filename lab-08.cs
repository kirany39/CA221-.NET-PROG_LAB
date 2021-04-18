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

namespace lab-8
{
    public partial class Form1 : Form
    {
        sqlConnection1 connection = new sqlConnection1();

        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.table_emp' table. You can move, or remove it, as needed.
            this.table_empTableAdapter.Fill(this.masterDataSet.table_emp);
           
            DataSet ds = new DataSet();
            connection = new SqlConnection1("Data Source=HT1-45;Initial Catalog=master;User ID=sa;Password=rvr");
            connection.Open();
            sqlDataAdapter1 da = new sqlDataAdapter1("select * from table_emp", connection);
            da.Fill(ds, "table_emp");
            textBox1.DataBindings.Add("text", ds, "table_emp.eno");
            textBox2.DataBindings.Add("text", ds, "table_emp.ename");
            textBox3.DataBindings.Add("text", ds, "table_emp.esal");
            textBox4.DataBindings.Add("text", ds, "table_emp.edep");
            textBox5.DataBindings.Add("text", ds, "table_emp.dno");


        }
    }
    \*

    internal class SqlConnection1
    {
        private string v;

        public SqlConnection1(string v)
        {
            this.v = v;
        }
    }

    internal class sqlDataAdapter1
    {
    }
    *\
    private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdinsert = new SqlCommand("insert into table_emp values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox5.Text + ")", connection);
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupdate = new SqlCommand("Update emp SET ename='" + textBox2.Text + "' where eno='" + textBox1.Text + "'", connection);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            MessageBox.Show("Data Upadated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmddel = new SqlCommand("Delete emp where eno=" + textBox1.Text + "", connection);
                cmddel.CommandType = CommandType.Text;
                cmddel.ExecuteNonQuery();
                MessageBox.Show("Data deleted");
            }

        }
    }
}
