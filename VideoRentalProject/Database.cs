using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalProject
{
    public class Database
    {
        string ConnectionString = @"Data Source=LAPTOP-AUOD8AI9\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ConnectionState DBStatus()
        {
            throw new NotImplementedException();
        }

        public Testing.DBTestClass.ConnectionState GetDBStatus()
        {
            throw new NotImplementedException();
        }

        SqlConnection Connection;

        public string ID;

        public Database CustomerTable { get; private set; }
        public Database MovieTable { get; private set; }

        public Database()
        {
            Connection = new SqlConnection(ConnectionString);
        }



        public Database LoadBt()
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("CustID");
            CustomersTable.Columns.Add("FirstName");
            CustomersTable.Columns.Add("LastName");
            CustomersTable.Columns.Add("Address");
            CustomersTable.Columns.Add("Phone");

            string query = "SELECT * FROM Customer";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["CustID"],
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Address"],
                    reader["Phone"]
                    );
            }

            Connection.Close();

            return CustomerTable;
        }

        public Database MovieBt()
        {
            Connection.Open();

            DataTable MoviesTable = new DataTable();

            MoviesTable.Clear();

            MoviesTable.Columns.Add("MovieID");
            MoviesTable.Columns.Add("Rating");
            MoviesTable.Columns.Add("Title");
            MoviesTable.Columns.Add("Year");
            MoviesTable.Columns.Add("Rental_Cost");
            MoviesTable.Columns.Add("Copies");
            MoviesTable.Columns.Add("Plot");
            MoviesTable.Columns.Add("Genre");

            string query = "SELECT * FROM Movies";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MoviesTable.Rows.Add(
                    reader["MovieID"],
                    reader["Rating"],
                    reader["Title"],
                    reader["Year"],
                    reader["Rental_Cost"],
                    reader["Copies"],
                    reader["Plot"],
                    reader["Genre"]
                    );
            }

            Connection.Close();

            return MovieTable;
        }

       

        public void AddCustomer(string fname, string lname, string phone, string address)
        {
            Connection.Open();

            string query = "INSERT INTO Customer (FirstName, LastName, Phone, Address) " +
                    "VALUES(@FirstName, @LastName, @Phone, @Address);";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void UpdateCustomer(string id, string fname, string lname, string phone, string address)
        {
            Connection.Open();

            string query = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address WHERE CustID = " + id + "; ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        internal void ADDBt(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        internal void IssueMovie(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        public void ADDBt(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            Connection.Open();

            string query = "INSERT INTO Movies (Rating, Title,  Year, Rental_Cost,Copies, Plot, Genre) " +
                    "VALUES(@Rating, @Title,  @Year, @Rental_Cost, @Copies, @Plot, @Genre);";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = Rating;
                command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@Year", SqlDbType.NVarChar).Value = Year;
                command.Parameters.Add("@Rental_Cost", SqlDbType.NVarChar).Value = Rental_Cost;
                command.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = Copies;
                command.Parameters.Add("@Plot", SqlDbType.NVarChar).Value = Plot;
                command.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = Genre;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        internal string PopularCustomer()
        {
            throw new NotImplementedException();
        }

        internal string PopularMovie()
        {
            throw new NotImplementedException();
        }

        internal void ReturnMovie(string rMID)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(string ID, string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            Connection.Open();

            string query = "UPDATE Movie SET Rating = @Rating, Title = @Title, Year = @Year, Rental_Cost = @Rental_Cost, Copies = @Copies,  Plot = @Plot, Genre = @Genre WHERE MovieID = " + ID + "; ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = Rating;
                command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@Year", SqlDbType.NVarChar).Value = Year;
                command.Parameters.Add("@Rental_Cost", SqlDbType.NVarChar).Value = Rental_Cost;
                command.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = Copies;
                command.Parameters.Add("@Plot", SqlDbType.NVarChar).Value = Plot;
                command.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = Genre;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void DeleteMovie(object ID)
        {
            Connection.Open();

            string query = "DELETE Movie WHERE MovieID = " + ID;

            SqlCommand command = new SqlCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public void DeleteCustomer(string id)
        {
            Connection.Open();

            string query = "DELETE Customer WHERE CustID = " + id;

            SqlCommand command = new SqlCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public ConnectionState DatabaseStatus()
        {
            return Connection.State;
        }
    }
}
