using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Countries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet setCities = new DataSet();
            DataSet setPeople = new DataSet();
            DataSet setCapital = new DataSet();
            string Cities = null;
            SqlDataAdapter adapterCities = new SqlDataAdapter("SELECT * FROM ", Cities);
            string People = null;
            SqlDataAdapter adapterPeople = new SqlDataAdapter("SELECT * FROM ", People);
            string Capital = null;
            SqlDataAdapter adapterCapital = new SqlDataAdapter("SELECT * FROM ", Capital);

            adapterCities.Fill(setCities);
            adapterPeople.Fill(setPeople);
            adapterCapital.Fill(setPeople);
            SqlCommandBuilder builderCities = new SqlCommandBuilder(adapterCities);
            SqlCommandBuilder builderPeople = new SqlCommandBuilder(adapterPeople);
            SqlCommandBuilder builderCapital = new SqlCommandBuilder(adapterCapital);

            adapterCities.InsertCommand = builderCities.GetInsertCommand();
            adapterCities.DeleteCommand = builderCities.GetDeleteCommand();
            adapterCities.UpdateCommand = builderCities.GetUpdateCommand();

            adapterPeople.InsertCommand = builderPeople.GetInsertCommand();
            adapterPeople.DeleteCommand = builderPeople.GetDeleteCommand();
            adapterPeople.UpdateCommand = builderPeople.GetUpdateCommand();

            adapterCapital.InsertCommand = builderCapital.GetInsertCommand();
            adapterCapital.DeleteCommand = builderCapital.GetDeleteCommand();
            adapterCapital.UpdateCommand = builderCapital.GetUpdateCommand();
            Console.ReadLine();


        }
    }
}
