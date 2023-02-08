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

namespace BooksShop
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapterBooks = null;
        SqlDataAdapter adapterAuthor = null;
        SqlConnection connection = new SqlConnection();
        SqlCommandBuilder builder = null;
        SqlCommandBuilder builder2 = null;
        SqlDataReader reader = null;
        DataSet dataSetBooks = new DataSet();
        DataSet dataSetAuthor = new DataSet();
        DataSet dataSetType = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьmenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                int lastid = 1;
                if (dataSetBooks.Tables[0].Rows.Count > 0)
                {
                    lastid = (int)dataSetBooks.Tables[0].Rows[dataSetBooks.Tables[0].Rows.Count - 1][0] + 1;
                }
                AddBooks ac = new AddBooks(lastid);
                if (ac.ShowDialog() == DialogResult.OK)
                {
                    dataSetBooks.Tables[0].Rows.Add(Int32.Parse(ac.tb_id.Text), ac.tb_name.Text);
                }
                ac.Dispose();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                int lastid = 1;
                if (dataSetBooks.Tables[0].Rows.Count > 0)
                {
                    lastid = (int)dataSetBooks.Tables[0].Rows[dataSetBooks.Tables[0].Rows.Count - 1][0] + 1;
                }
                AddBooks ag = new AddBooks(lastid);
                if (ag.ShowDialog() == DialogResult.OK)
                {
                    dataSetBooks.Tables[0].Rows.Add(Int32.Parse(ag.tb_id.Text), ag.tb_name.Text);
                }
                ag.Dispose();
            }
        }

        private void удалить_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    dataSetBooks.Tables[0].Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {

            }
        }
    }
}
