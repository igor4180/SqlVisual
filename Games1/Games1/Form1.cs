using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games1
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapterGames = null;
        SqlConnection connection = new SqlConnection();
        SqlConnection connectionAsync = new SqlConnection();
        SqlCommandBuilder builder = null;
        SqlCommandBuilder builder2 = null;
        SqlDataReader reader = null;
        DataSet dataSetGames = new DataSet();
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Games1", connection.ConnectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name Like '%{textBox1.Text}%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Stydio Like '%{textBox1.Text}%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Countries Like '%{textBox1.Text}%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Cities Like '%{textBox1.Text}%'";
        }
    }
}
