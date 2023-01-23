using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Program
    {
        SqlConnection conn = null;
        public Program()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Stock; Integrated Security=SSPI;";
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.InsertQuery();
        }
        public void InsertQuery()
        {
            try
            {
                //открыть соединение
                conn.Open();
                //подготовить запрос insert
                //в переменной типа string
                string insertString = @"insert into Name (Name, Type) values ('Roger', 'Zelazny')";
                //создать объект command, инициализировав оба свойства
                SqlCommand cmd = new SqlCommand(insertString, conn);
                //выполнить запрос, занесенный
                //в объект command
                cmd.ExecuteNonQuery();

            }
            finally
            {

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
   