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
        SqlConnection Connection;


        public Database()
        {
            Connection = new SqlConnection(ConnectionString);
        }



        public DataTable LoadBt()
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

           
            return CustomersTable;
        }

        public DataTable RentalBt()
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("RMID");
            CustomersTable.Columns.Add("MovieIDFK");
            CustomersTable.Columns.Add("CustIDFK");
            CustomersTable.Columns.Add("DateRented");
            CustomersTable.Columns.Add("DateReturned");

            string query = "SELECT * FROM RentedMovies";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["RMID"],
                    reader["MovieIDFK"],
                    reader["CustIDFK"],
                    reader["DateRented"],
                    reader["DateReturned"]
                    );
            }

            Connection.Close();

            return CustomersTable;
        }

        public DataTable MovieBt()
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

           
            return MoviesTable;
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

       

        public void IssueMovie(string movieIDFK, string custIDFK)
        {
            Connection.Open();

            string query = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented)" +
                    "VALUES(@MovieIDFK, @CustIDFK, @DateRented)";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@MovieIDFK", movieIDFK);
                command.Parameters.AddWithValue("@CustIDFK", custIDFK);
                command.Parameters.AddWithValue("@DateRented", DateTime.Now);

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

       

        public string PopularCustomer()
        {
            Connection.Open();

            string query = "SELECT CustIDFK, COUNT(*) AS Rep FROM RentedMovies GROUP BY CustIDFK ORDER BY Rep DESC";

            SqlCommand command = new SqlCommand(query, Connection);

            var result = command.ExecuteScalar().ToString();

            Connection.Close();

            Connection.Open();

            Console.WriteLine(result);

            query = "SELECT FirstName, LastName FROM Customer WHERE CustID = " + result;

            command = new SqlCommand(query, Connection);

            SqlDataReader reader = command.ExecuteReader();

            string output = "";

            while (reader.Read())
            {
                output = reader["FirstName"].ToString();
                output += " ";
                output += reader["LastName"].ToString();
            }

            Connection.Close();

            return output;
        }

        public string PopularMovie()
        {
            Connection.Open();

            string query = "SELECT MovieIDFK, COUNT(*) AS Rep FROM RentedMovies GROUP BY MovieIDFK ORDER BY Rep DESC";

            SqlCommand command = new SqlCommand(query, Connection);

            var result = command.ExecuteScalar().ToString();

            Connection.Close();

            return result;
        }

        public void ReturnMovie(string rMID)
        {
            Connection.Open();

            string query = "UPDATE RentedMovies set DateReturned=@DateReturned Where RMID = @RMID";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@RMID", SqlDbType.NVarChar).Value = rMID;
                command.Parameters.Add("@DateReturned", SqlDbType.DateTime).Value = DateTime.Now;

                command.ExecuteNonQuery();
            }

            Connection.Close();
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

       
        public ConnectionState DBStatus()
        {
            return Connection.State;
        }
    }
}
