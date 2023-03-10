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
using System.Configuration;

namespace Games
{
    //CREATE TABLE[dbo].[Games]
    //(
    //[Id] INT NOT NULL,
    //[Name] VARCHAR(100) NOT NULL,
    //[Studio] VARCHAR(50)  NOT NULL,
    //[Style]  VARCHAR(50)  NOT NULL,
    //[Date]   INT NOT NULL,
    //PRIMARY KEY CLUSTERED([Id] ASC)
    //);
    public partial class Form1 : Form
    {
        SqlDataAdapter adapterGames = null;
        SqlConnection connection = new SqlConnection();
        SqlConnection connectionAsync = new SqlConnection();
        SqlCommandBuilder builder = null;
        SqlCommandBuilder builder2 = null;
        SqlDataReader reader = null;
        DataSet dataSetGames = new DataSet();
        //private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString);
            //sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Games", connection);
            dataAdapter.Fill(dataSetGames);
            dataGridView1.DataSource = dataSetGames.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name Like '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Style Like '%{textBox2.Text}%'";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Stydio Like '%{textBox3.Text}%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Date Like '%{textBox4.Text}%'";
        }
    }
}
