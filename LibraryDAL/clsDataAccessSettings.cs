using System;
using System.Data.SqlClient;
using System.Data;


namespace LibraryDataAccesse
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "server=.;Database=LibraryDB;User id =sa;Password=sa123456";

        

        public static int GetDefaultBorrowDays()
        {
            int DefaultBorrowDays = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select DefaultBorrowDays from Settings";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                int insert = -1;
                object result  = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out insert))
                {
                    DefaultBorrowDays = insert;
                }



            }
            catch (Exception ex)
            {
                DefaultBorrowDays = -1;
            }
            finally
            {
                connection.Close();
            }


            return DefaultBorrowDays;
        }


        public static int GetDefaultFinePerDay()
        {
            int DefaultFinePerDay = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select DefaultFinePerDay from Settings";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                int insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out insert))
                {
                    DefaultFinePerDay = insert;
                }



            }
            catch (Exception ex)
            {
                DefaultFinePerDay = -1;
            }
            finally
            {
                connection.Close();
            }


            return DefaultFinePerDay;
        }



    }
}
