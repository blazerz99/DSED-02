using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_02_Movies
{
    //Data Source=LAPTOP-NF63K9NS\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False


    class Database
    {
        //Create a Connection Command Adapter
        private SqlConnection Connection = new SqlConnection(); // connect to DB
        private SqlCommand Command = new SqlCommand(); // give it a query
        private SqlDataAdapter dataAdapter = new SqlDataAdapter(); // hold the results
        
        public string connection = @"Data Source=LAPTOP-NF63K9NS\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;"; // using this for connection string for the CRUD


        public Database()
        {
            string connectionString = @"Data Source=LAPTOP-NF63K9NS\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;";

            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;

        }

        public DataTable FillDataGridViews(string TableName)
        {
            DataTable dt = new DataTable(); // temp table to hold data

            string query = "select * from " + TableName;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                // connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;



        }

        public DataTable FillOtherDataGridViews(string TableName, string ForeignKey, int ID)
        {
            DataTable dt = new DataTable(); // temp table to hold data

            string query = "select * from " + TableName + " where " + ForeignKey + "=" + ID;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                // connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;


        }

        public DataTable FillDGVRentedMovies(string TableName, string PrimaryKey, int IDFK)
        {
            DataTable dt = new DataTable(); // temp table to hold data

            string query = "select * from " + TableName + " where " + PrimaryKey + "=" + IDFK;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                // connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;


        }

        public DataTable FillPopularDGV(string TableName)
        {
            DataTable dt = new DataTable();

            string query = "select * from " + TableName;


            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                // connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;

        }




    }
}
