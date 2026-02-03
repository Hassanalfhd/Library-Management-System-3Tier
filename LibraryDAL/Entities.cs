using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;



namespace LibraryDataAccesse
{

    // Persons Table
    abstract public class clsPersonDataAccess
    {

        protected static int AddDataToPerson(string FirstName, string LastName, char Gender, string Email, string Phone)
        {
            int PersonID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Person]
           ([FirstName]
           ,[LastName]
           ,[Gender]
           ,[Email]
           ,[Phone])
     VALUES
           (@FirstName
           ,@LastName
           ,@Gender
           ,@Email
           ,@Phone);
select SCOPE_IDENTITY();";

            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);


            try
            {
                connection.Open();

                int Insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    PersonID = Insert;
                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        protected static bool UpdatePerson(int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone)
        {

            int rowAffacte = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);



            string query = @"UPDATE [dbo].[Person]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Gender] = @Gender
      ,[Email] = @Email
      ,[Phone] = @Phone
 WHERE Person.ID = @PersonoID";

            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();


                rowAffacte = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacte = 0;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacte > 0);

        }

        protected static bool DeletePersonByID(int PersonID)
        {

            int rowAffacte = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Person where ID = @PersonID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowAffacte = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacte = 0;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacte > 0);

        }

    }


    // Auothers Table
    public class clsAuotherDataAccess : clsPersonDataAccess
    {

        public static bool GetAuotherInfoByID(int AuotherID, ref int PersonID, ref string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Auothers.AuotherID, Person.ID, Person.FirstName, Person.LastName, Person.Gender, Person.Email, Person.Phone   
                    FROM  Auothers INNER JOIN
                         Person ON Auothers.PersonID = Person.ID 
                  WHERE Auothers.AuotherID = @AuotherID  ";
            

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AuotherID", AuotherID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar (reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }

        public static bool GetAuotherInfoByName(ref int AuotherID, ref int PersonID, string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Auothers.AuotherID, Person.ID, Person.FirstName, Person.LastName, Person.Gender, Person.Email, Person.Phone   
                    FROM  Auothers INNER JOIN
                         Person ON Auothers.PersonID = Person.ID 
                  WHERE Person.FirstName  Like  '%'+ @FirstName +'%'  ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    AuotherID = (int)reader["AuotherID"];
                    PersonID = (int)reader["ID"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


   
        public static int AddNewAuother(string FirstName,  string LastName,  char Gender,  string Email,  string Phone)
        {
            int AuotherID = -1;

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            PersonID = AddDataToPerson(FirstName , LastName , Gender, Email, Phone);


            string query = @"INSERT INTO [dbo].[Auothers]
           ([PersonID])
     VALUES
           (@PersonID);
        select SCOPE_IDENTITY();";

            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
    
            try
            {
                connection.Open();


                int Insert = -1 ;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    AuotherID = Insert;
                }


             }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return AuotherID;
        }

        public static bool UpdateAuother(int AuotherID, int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone)
        {

            int rowAffacte = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);



            string query = @"UPDATE [dbo].[Person]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Gender] = @Gender
      ,[Email] = @Email
      ,[Phone] = @Phone
 WHERE Person.ID = (select PersonID from Auothers where AuotherID = @AuotherID)";


            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AuotherID", AuotherID);

            try
            {
                connection.Open();


                rowAffacte = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacte = 0;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacte > 0);
            
        }


        public static bool DeleteAuother(int AuotherID)
        {


            int PersonIDInAuothersTable = 0;
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select PersonID from Auothers where AuotherID = @AuotherID ;
                Delete Auothers where AuotherID = @AuotherID;";


           



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuotherID", AuotherID);


            

            try
            {
                connection.Open();
                int PersonID = -1 ;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                    PersonIDInAuothersTable = PersonID;   

                    DeletePersonByID(PersonIDInAuothersTable);
                    IsDeleted =true ;
                }

            }
            catch (Exception ex)
            {
                    IsDeleted  = false ;
                
            }
            finally
            {
                connection.Close();
            }

            return IsDeleted ;
            
        }


        public static bool IsAuotherExist(int AuotherID)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Found = 1   
                    FROM  Auothers INNER JOIN
                         Person ON Auothers.PersonID = Person.ID 
                  WHERE Auothers.AuotherID = @AuotherID  ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AuotherID", AuotherID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static DataTable GetAllAuothers ()
        {


            DataTable AuothersDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Auothers.AuotherID,Person.FirstName, Person.LastName, Person.Gender, Person.Email, Person.Phone   
                    FROM  Auothers INNER JOIN
                         Person ON Auothers.PersonID = Person.ID; ";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AuothersDataTable.Load(reader);
                }
                

                reader.Close();

            }
            catch (Exception ex)
            {
                AuothersDataTable = null;

            }
            finally
            {
                connection.Close();
            }


            return AuothersDataTable;

        }


    }

    // Users Table
    public class clsUserDataAccess : clsPersonDataAccess
    {

        public static bool GetUserInfoByID(int UserID  , ref int PersonID, ref string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone,
                ref string Password, ref string LibraryCardNumber)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Users.UserID, Users.Password, Users.LibraryCardNumber, Person.ID, Person.FirstName, Person.LastName, 
        Person.Gender, Person.Email, Person.Phone
                FROM  Person INNER JOIN  Users ON Person.ID = Users.PersonID  
                    WHERE Users.UserID = @UserID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Password = (string)reader["Password"];
                    LibraryCardNumber = (string)reader["LibraryCardNumber"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }

        public static bool GetUserInfoByName(ref int UserID, ref int PersonID, string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone,
             ref string Password, ref string LibraryCardNumber)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Users.UserID, Users.Password, Users.LibraryCardNumber, Person.ID, Person.FirstName, Person.LastName, 
        Person.Gender, Person.Email, Person.Phone
                FROM  Person INNER JOIN  Users ON Person.ID = Users.PersonID  
                    WHERE Person.FirstName = @FirstName";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    UserID = (int)reader["UserID"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Password = (string)reader["Password"];
                    LibraryCardNumber = (string)reader["LibraryCardNumber"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static int AddNewUser(string FirstName,  string LastName,  char Gender,  string Email,  string Phone,
                 string Password, string LibraryCardNumber)
        {

            int UserID = -1;

            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            PersonID = AddDataToPerson(FirstName, LastName, Gender, Email, Phone);


            string query = @"INSERT INTO [dbo].[Users]
           ([Password]
           ,[LibraryCardNumber]
           ,[PersonID])
     VALUES
           (@Password
           ,@LibraryCardNumber
           ,@PersonID);
select SCOPE_IDENTITY();";

            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                int Insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    UserID = Insert;
                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone, string Password, string LibraryCardNumber)
        {

            int rowAffacte = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);



            string query = @"UPDATE [dbo].[Person]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Gender] = @Gender
      ,[Email] = @Email
      ,[Phone] = @Phone
 WHERE Person.ID = (select PersonID from Users where UserID = @UserID);

   UPDATE [dbo].[Users]
   SET [Password] = @Password
      ,[LibraryCardNumber] = @LibraryCardNumber
 WHERE UserID = @UserID ;";



            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);


            try
            {
                connection.Open();


                rowAffacte = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacte = 0;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacte > 0);

        }


        public static bool DeleteUser(int UserID)
        {


            int PersonIDInAuothersTable = 0;
            int rowAffact = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select PersonID from Users where UserID = @UserID ;
                Delete Users where UserID = @UserID;";






            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);




            try
            {
                connection.Open();
                int PersonID = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                    PersonIDInAuothersTable = PersonID;

                    DeletePersonByID(PersonIDInAuothersTable);
                    rowAffact = 1;
                }

            }
            catch (Exception ex)
            {
                rowAffact = 0;

            }
            finally
            {
                connection.Close();
            }

            return (rowAffact > 0);

        }


        public static bool IsUserExist(int UserID)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Found = 1   
                    FROM  Users INNER JOIN
                         Person ON Users.PersonID = Person.ID 
                  WHERE Users.UserID = @UserID  ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static DataTable GetAllUsers()
        {


            DataTable AuothersDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   Users.UserID,  Person.FirstName, Person.LastName, Person.Gender, Person.Email, Person.Phone, Users.Password, Users.LibraryCardNumber
FROM            Users INNER JOIN
                         Person ON Users.PersonID = Person.ID";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AuothersDataTable.Load(reader);
                }


                reader.Close();

            }
            catch (Exception ex)
            {
                AuothersDataTable = null;

            }
            finally
            {
                connection.Close();
            }


            return AuothersDataTable;

        }

    }

    // Books Table
    public class Entities
    {

        public static bool GetBookInfoByID(int ID, ref string Title, ref string ISBN, ref DateTime PublictionDate, ref string Genre, ref string AdditionalDetalis, ref int AuotherID, ref string ImagePath)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Books Where ID  = @ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Title = (string)reader["Title"];
                    ISBN = (string)reader["ISBN"];
                    PublictionDate = (DateTime)reader["PublictionDate"];
                    Genre = (string)reader["Genre"];

                    if (reader["AdditionalDetalis"] != DBNull.Value)
                        AdditionalDetalis = (string)reader["AdditionalDetalis"];
                    else
                        AdditionalDetalis = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";


                    AuotherID = (int)reader["AuotherID"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static bool GetBookInfoByTitle(ref int ID, string Title, ref string ISBN, ref DateTime PublictionDate, ref string Genre, ref string AdditionalDetalis, ref int AuotherID, ref string ImagePath)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Books Where Title =@Title ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    ISBN = (string)reader["ISBN"];
                    PublictionDate = (DateTime)reader["PublictionDate"];
                    Genre = (string)reader["Genre"];

                    if (reader["AdditionalDetalis"] != DBNull.Value)
                        AdditionalDetalis = (string)reader["AdditionalDetalis"];
                    else
                        AdditionalDetalis = "";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";


                    AuotherID = (int)reader["AuotherID"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static bool GetBookInfoByISBN(ref int ID, ref string Title, string ISBN, ref DateTime PublictionDate, ref string Genre, ref string AdditionalDetalis, ref int AuotherID, ref string ImagePath)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Books Where ISBN =@ISBN ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ISBN", ISBN);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    Title = (string)reader["Title"];
                    PublictionDate = (DateTime)reader["PublictionDate"];
                    Genre = (string)reader["Genre"];

                    if (reader["AdditionalDetalis"] != DBNull.Value)
                        AdditionalDetalis = (string)reader["AdditionalDetalis"];
                    else
                        AdditionalDetalis = "";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";


                    AuotherID = (int)reader["AuotherID"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }


        public static int AddNewBook(string Title, string ISBN, DateTime PublictionDate, string Genre, string AdditionalDetalis, int AuotherID, string ImagePath)
        {
            int BookID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Books]
           ([Title]
           ,[ISBN]
           ,[PublictionDate]
           ,[Genre]
           ,[AdditionalDetalis]
           ,[AuotherID]
            ,[ImagePath])
     VALUES
           (@Title
           ,@ISBN
           ,@PublictionDate
           ,@Genre
           ,@AdditionalDetalis
           ,@AuotherID
           ,@ImagePath);
		   Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublictionDate", PublictionDate);
            command.Parameters.AddWithValue("@Genre", Genre);

            if (AdditionalDetalis != "")
                command.Parameters.AddWithValue("@AdditionalDetalis", AdditionalDetalis);
            else
                command.Parameters.AddWithValue("@AdditionalDetalis", DBNull.Value);

            command.Parameters.AddWithValue("@AuotherID", AuotherID);


            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);




            try
            {
                connection.Open();
                int insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out insert))
                {
                    BookID = insert;
                }



            }
            catch (Exception ex)
            {
                BookID = -1;
                Console.WriteLine(ex.Message);
               
                
            }
            finally
            {
                connection.Close();
            }

            return BookID;
        }


        public static bool UpdateBook(int ID, string Title, string ISBN, DateTime PublictionDate, string Genre, string AdditionalDetalis, int AuotherID, string ImagePath)
        {

            int rowAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Books]
   SET [Title] = @Title
      ,[ISBN] = @ISBN
      ,[PublictionDate] = @PublictionDate
      ,[Genre] = @Genre
      ,[AdditionalDetalis] = @AdditionalDetalis
      ,[AuotherID] = @AuotherID
      ,[ImagePath] = @ImagePath
 WHERE ID = @BookID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublictionDate", PublictionDate);
            command.Parameters.AddWithValue("@Genre", Genre);

            if (AdditionalDetalis != "")
                command.Parameters.AddWithValue("@AdditionalDetalis", AdditionalDetalis);
            else
                command.Parameters.AddWithValue("@AdditionalDetalis", DBNull.Value);

            command.Parameters.AddWithValue("@AuotherID", AuotherID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                connection.Open();

                rowAffect = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                rowAffect = 0;
            }
            finally
            {
                connection.Close();
            }


            return (rowAffect > 0);
        }


        public static bool DeleteBook(int BookID)
        {
            int rowAffect = 0;
         
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM [dbo].[Books]
      WHERE ID = @BookID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                rowAffect = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                rowAffect = 0;
            }
            finally
            {
                connection.Close();
            }


            return (rowAffect > 0);
        }


        public static bool IsBookExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from Books Where ID  = @ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static DataTable GetAllBook()
        {
            DataTable BookTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     Books.ID,Books.Title, Books.ISBN, Books.Genre, Person.FirstName + ' '+ Person.LastName as AuotherName , Books.PublictionDate, Books.AdditionalDetalis, Books.ImagePath
FROM            Auothers INNER JOIN
                         Books ON Auothers.AuotherID = Books.AuotherID INNER JOIN
                         Person ON Auothers.PersonID = Person.ID";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    BookTable.Load(reader);
                }


                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return BookTable;
        }

        
    }

    // Books Copies Table
    public class clsBookCopiesDataAccess
    {

        public static bool GetBookCopiesInfoByID(int CopyID, ref int BookID, ref bool AvailabilityStauts)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BookCopies where CopyID = @CopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    BookID = (int)reader["BookID"];
                    AvailabilityStauts = (bool)reader["AvailabilityStauts"];
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }

        public static bool GetBookCopiesInfoByAvailabilityStauts(ref int CopyID, ref int BookID,  bool AvailabilityStauts)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BookCopies where AvailabilityStauts = @AvailabilityStauts";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AvailabilityStauts", AvailabilityStauts);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    BookID = (int)reader["BookID"];
                    CopyID = (byte)reader["CopyID"];
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }
        
        public static  int AddNewBookCopy( int BookID,  bool AvailabilityStauts)
        {
            int CopyID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[BookCopies]
           ([BookID]
           ,[AvailabilityStauts])
     VALUES
           (@BookID
           ,@AvailabilityStauts);
		   select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@AvailabilityStauts", AvailabilityStauts);

            try
            {
                connection.Open();

                int Insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    CopyID = Insert;
                }
            }
            catch (Exception ex)
            {
                CopyID = -1;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return CopyID;
        }


        public static bool UpdateBookCopy(int CopyID, int BookID, bool AvailabilityStauts)
        {
            int rowAffacet = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[BookCopies]
   SET [BookID] = @BookID
      ,[AvailabilityStauts] = @AvailabilityStauts
        WHERE CopyID = @CopyID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@AvailabilityStauts", AvailabilityStauts);

            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacet = 0;
            }
            finally
            {
                connection.Close();
            }
        
            return (rowAffacet > 0);
        }


        public static bool DeleteBookCopy(int CopyID)
        {
            int rowAffacet = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete BookCopies WHERE CopyID = @CopyID;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);

            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacet = 0;
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacet > 0);
        }


        public static bool IsBookCopyExist(int CopyID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Foun = 1 from BookCopies where CopyID = @CopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
              
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }



        public static DataTable GetAllBookCopies()
        {
            DataTable BookCopiesDataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BookCopies ;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    BookCopiesDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                BookCopiesDataTable = null;
            }
            finally
            {
                connection.Close();
            }

            return BookCopiesDataTable;
        }


        public static DataTable GetAllBookCopiesByBookID(int BookID)
        {
            DataTable BookCopiesDataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BookCopies Where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    BookCopiesDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                BookCopiesDataTable = null;
            }
            finally
            {
                connection.Close();
            }

            return BookCopiesDataTable;
        }

        public static DataTable GetAllBookCopiesWithDistinct()
        {
            DataTable BookCopiesDataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Distinct * from BookCopies ;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    BookCopiesDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                BookCopiesDataTable = null;
            }
            finally
            {
                connection.Close();
            }

            return BookCopiesDataTable;
        }

    }

    // Borrowing Records Table
    public class clsBorrowingRecordDataAccess
    {


        public static bool GetBorrowingRecordInfoByBorrowingRecordsID(int BorrowingRecordsID, ref int CopyID, ref int UserID, ref DateTime BorrowingDate, ref DateTime DueDate, ref Nullable< DateTime >ActualReturnDate)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BorrowingRecords where BorrowingRecordsID = @BorrowingRecordsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingRecordsID", BorrowingRecordsID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CopyID = (int)reader["CopyID"];
                    UserID = (int)reader["UserID"];
                    BorrowingDate = (DateTime)reader["BorrowingDate"];
                    DueDate = (DateTime)reader["DueDate"];

                    if (reader["ActualReturnDate"] != DBNull.Value)
                        ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    else
                      ActualReturnDate = null ;

                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;


        }


        public static bool GetBorrowingRecordInfoByCopyID(ref int BorrowingRecordsID, int CopyID, ref int UserID, ref DateTime BorrowingDate, ref DateTime DueDate, ref Nullable<DateTime> ActualReturnDate)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BorrowingRecords where CopyID = @CopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    BorrowingRecordsID = (int)reader["BorrowingRecordsID"];
                    UserID = (int)reader["UserID"];
                    BorrowingDate = (DateTime)reader["BorrowingDate"];
                    DueDate = (DateTime)reader["DueDate"];

                    if (reader["ActualReturnDate"] != DBNull.Value)
                        ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    else
                        ActualReturnDate = null;

                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;


        }


        public static bool GetBorrowingRecordInfoByUserID(ref int BorrowingRecordsID, ref int CopyID, int UserID, ref DateTime BorrowingDate, ref DateTime DueDate, ref Nullable<DateTime> ActualReturnDate)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BorrowingRecords where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    BorrowingRecordsID = (int)reader["BorrowingRecordsID"];
                    CopyID = (int)reader["CopyID"];
                    BorrowingDate = (DateTime)reader["BorrowingDate"];
                    DueDate = (DateTime)reader["DueDate"];
                   
                    if (reader["ActualReturnDate"] != DBNull.Value)
                        ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    else
                        ActualReturnDate = null;

                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;


        }


        public static int AddNewBorrowingRecord(int CopyID,  int UserID,  DateTime BorrowingDate,  DateTime DueDate, Nullable< DateTime >ActualReturnDate)
        {
            int BorrowingRecordsID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[BorrowingRecords]
           ([CopyID]
           ,[UserID]
           ,[BorrowingDate]
           ,[DueDate]
           ,[ActualReturnDate])
     VALUES
           (@CopyID
           ,@UserID
           ,@BorrowingDate
           ,@DueDate
           ,@ActualReturnDate);
		   select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);

            if (ActualReturnDate != null)
                command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            else
                command.Parameters.AddWithValue("@ActualReturnDate", DBNull.Value);


            try
            {
                connection.Open();

                int insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out insert))
                {
                    BorrowingRecordsID = insert;
                }
            }
            catch (Exception ex)
            {
                BorrowingRecordsID = -1;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return BorrowingRecordsID;
        }


        public static bool UpdateBorrowingRecord(int BorrowingRecordsID, int CopyID, int UserID, DateTime BorrowingDate, DateTime DueDate, Nullable<DateTime> ActualReturnDate)
        {
            int rowAffect = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[BorrowingRecords]
   SET [CopyID] = @CopyID
      ,[UserID] = @UserID
      ,[BorrowingDate] = @BorrowingDate
      ,[DueDate] = @DueDate
      ,[ActualReturnDate] = @ActualReturnDate
 WHERE BorrowingRecordsID = @BorrowingRecordsID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingRecordsID", BorrowingRecordsID);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);

            if (ActualReturnDate != null)
                command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            else
                command.Parameters.AddWithValue("@ActualReturnDate", DBNull.Value);


            try
            {
                connection.Open();

                rowAffect = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffect = 0;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffect > 0);
        }


        public static bool DeleteBorrowingRecord(int BorrowingRecordsID)
        {

            int rowAffect = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete BorrowingRecords
                        WHERE BorrowingRecordsID = @BorrowingRecordsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingRecordsID", BorrowingRecordsID);
         

            try
            {
                connection.Open();

                rowAffect = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffect = 0;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffect > 0);
        }



        public static bool IsBorrowingRecordExist(int BorrowingRecordsID)
        {

            bool IsFound = false ;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from BorrowingRecords ";

            SqlCommand command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                 IsFound = false;

                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (IsFound);
        }


        public static DataTable GetAllBorrowingRecords()
        {
            DataTable BorrowingRecordDataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from BorrowingRecords";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    BorrowingRecordDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                BorrowingRecordDataTable = null;
            }
            finally
            {
                connection.Close();
            }


            return BorrowingRecordDataTable;

        }


     }

    // Fine Table
    public class clsFinesDataAccess
    {

        public static bool GetFineInfoByID(int FineID, ref int UserID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref decimal FineAmount, ref bool PaymentSatauts)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Fines Where FineID = @FineID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FineID", FineID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    BorrowingRecordID = (int)reader["BorrowingRecordID"];
                    NumberOfLateDays = (short)reader["NumberOfLateDays"];
                    FineAmount = (decimal)reader["FineAmount"];
                    PaymentSatauts = (bool)reader["PaymentSatauts"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }


        public static int AddNewFine(int UserID, int BorrowingRecordID, short NumberOfLateDays, decimal FineAmount, bool PaymentSatauts)
        {
            int FineID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Fines]
           ([UserID]
           ,[BorrowingRecordID]
           ,[NumberOfLateDays]
           ,[FineAmount]
           ,[PaymentSatauts])
     VALUES
           (@UserID
           ,@BorrowingRecordID
           ,@NumberOfLateDays
           ,@FineAmount
           ,@PaymentSatauts);
		   select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@FineAmount", FineAmount);
            command.Parameters.AddWithValue("@PaymentSatauts", PaymentSatauts);


            try
            {
                connection.Open();

                int Insert = -1;

                object result = command.ExecuteNonQuery();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    FineID = Insert;
                }
                

            }
            catch (Exception ex)
            {
                FineID = -1;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return FineID;
        }

        public static bool UpdateFine(int FineID, int UserID, int BorrowingRecordID, short NumberOfLateDays, decimal FineAmount, bool PaymentSatauts)
        {

            int rowAffacet = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Fines]
   SET [UserID] = @UserID
      ,[BorrowingRecordID] = @BorrowingRecordID
      ,[NumberOfLateDays] = @NumberOfLateDays
      ,[FineAmount] = @FineAmount
      ,[PaymentSatauts] = @PaymentSatauts
 WHERE FineID = @FineID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FineID", FineID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@FineAmount", FineAmount);
            command.Parameters.AddWithValue("@PaymentSatauts", PaymentSatauts);



            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                rowAffacet = 0;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffacet  > 0);
        }


        public static bool DeleteFine(int FineID)
        {

            int rowAffacet = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Fines WHERE FineID = @FineID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FineID", FineID);


            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                rowAffacet = 0;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffacet > 0);
        }


        public static bool IsFineExist(int FineID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select  Fount = 1 from Fines Where FineID = @FineID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FineID", FineID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }


        public static DataTable GetAllFines()
        {
            DataTable FinesDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select  * from Fines;";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    FinesDataTable.Load(reader);

                }

                reader.Close();

            }
            catch (Exception ex)
            {
                FinesDataTable = null;
            }
            finally
            {
                connection.Close();
            }

            return FinesDataTable;
        }

        public static DataTable GetAllFinesJoinData()
        {
            DataTable FinesDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Fines.FineID, Person.FirstName + ' ' + Person.LastName  as MemberName, Users.LibraryCardNumber, Fines.BorrowingRecordID, Fines.NumberOfLateDays, Fines.FineAmount, Fines.PaymentSatauts
FROM            Users INNER JOIN
                         Person ON Users.PersonID = Person.ID INNER JOIN
                         Fines ON Users.UserID = Fines.UserID";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    FinesDataTable.Load(reader);

                }

                reader.Close();

            }
            catch (Exception ex)
            {
                FinesDataTable = null;
            }
            finally
            {
                connection.Close();
            }

            return FinesDataTable;
        }

        
    }

    // Reservations Table

    public class clsReservationDataAccess
    {

        public static bool GetReservationInfoById(int ReservationID, ref int UserID, ref int CopyID , ref DateTime ReservationDate)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Reservations Where ReservationID = @ReservationID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    CopyID = (int)reader["CopyID"];
                    ReservationDate = (DateTime)reader["ReservationDate"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static int AddNewReservation(int UserID, int CopyID, DateTime ReservationDate)
        {
            int ReservationID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Reservations]
           ([CopyID]
           ,[UserID]
           ,[ReservationDate])
     VALUES
           (@CopyID
           ,@UserID
           ,@ReservationDate)
		   select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);


            try
            {
                connection.Open();

                int Insert;

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    ReservationID = Insert;
                }


            }
            catch (Exception ex)
            {
                ReservationID = -1;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return ReservationID;
        }

        public static bool UpdateReservation(int ReservationID, int UserID, int CopyID, DateTime ReservationDate)
        {
            int rowAffacet = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Reservations]
   SET [CopyID] = @CopyID
      ,[UserID] = @UserID
      ,[ReservationDate] = @ReservationDate
 WHERE ReservationID = @ReservationID ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);


            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacet = 0;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffacet >0);
        }

        public static bool DeleteReservation(int ReservationID)
        {
            int rowAffacet = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" Delete Reservations WHERE ReservationID = @ReservationID ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);


            try
            {
                connection.Open();

                rowAffacet = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacet = 0;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowAffacet > 0);
        }


        public static bool IsReservationExist(int ReservationID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Foound = 1 from Reservations Where ReservationID = @ReservationID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static DataTable  GetAllReservations()
        {
            DataTable ReservationsDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Reservations ;";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ReservationsDataTable.Load(reader);
                }
                
                reader.Close();

            }
            catch (Exception ex)
            {
                ReservationsDataTable = null;
            }
            finally
            {
                connection.Close();
            }


            return ReservationsDataTable;
        }

        public static DataTable GetAllReservationsTextData()
        {
            DataTable ReservationsDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Reservations.ReservationID, Person.FirstName +' ' +  Person.LastName as MemberName, Users.LibraryCardNumber, Reservations.ReservationDate, Person.Phone
FROM            Users INNER JOIN
                         Person ON Users.PersonID = Person.ID INNER JOIN
                         Reservations ON Users.UserID = Reservations.UserID join 
						 BookCopies oN BookCopies.CopyID = Reservations.CopyID;";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ReservationsDataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                ReservationsDataTable = null;
            }
            finally
            {
                connection.Close();
            }


            return ReservationsDataTable;
        }


    }


    // Setting Table
    public class clsSettingDataAccess
    {

        public static int GetDefaultBorrowDays()
        {
            return clsDataAccessSettings.GetDefaultBorrowDays();
        }


        public static int GetDefaultFinePerDay()
        {
            return clsDataAccessSettings.GetDefaultFinePerDay();
        }
    }



    // Employees Table
    public class clsEmployeeDataAccess : clsPersonDataAccess
    {

        public static bool GetEmployeeInfoByID(int EmployeeID, ref int PersonID, ref string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone,
                ref string Password, ref int Permissions, ref string UserName, ref decimal Salary, ref string ImagePath)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     Employees.EmployeeID, Employees.Passsword, Employees.Permissions, Person.ID, Person.FirstName, Person.LastName,Employees.UserName, 
        Person.Gender, Person.Email, Person.Phone, Employees.Salary , Employees.ImagePath
                FROM  Person INNER JOIN  Employees ON Person.ID = Employees.PersonID  
                    WHERE Employees.EmployeeID = @EmployeeID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Passsword"];
                    Permissions = (int)reader["Permissions"];
                
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static bool GetEmployeeInfoByUserNameAndPassword(ref int EmployeeID, ref int PersonID,  ref string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone,
           string Password, ref int Permissions,  string UserName, ref decimal Salary)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     Employees.EmployeeID, Employees.Passsword, Employees.Permissions, Person.ID, Person.FirstName, Person.LastName,Employees.UserName, 
        Person.Gender, Person.Email, Person.Phone , Employees.Salary
                FROM  Person INNER JOIN  Employees ON Person.ID = Employees.PersonID  
                    WHERE Employees.Passsword = @Password and Employees.UserName = @UserName";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Permissions = (int)reader["Permissions"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static bool GetEmployeeInfoByUserNameAndPassword(ref int EmployeeID, ref int PersonID, ref string FirstName, ref string LastName, ref char Gender, ref string Email, ref string Phone,
      string Password, ref int Permissions, string UserName, ref decimal Salary, ref string ImagePath)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     Employees.EmployeeID, Employees.Passsword, Employees.Permissions, Person.ID, Person.FirstName, Person.LastName,Employees.UserName, 
        Person.Gender, Person.Email, Person.Phone , Employees.Salary , Employees.ImagePath
                FROM  Person INNER JOIN  Employees ON Person.ID = Employees.PersonID  
                    WHERE Employees.Passsword = @Password and Employees.UserName = @UserName";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Permissions = (int)reader["Permissions"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = null;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static int AddNewEmployee(string FirstName, string LastName, char Gender, string Email, string Phone,
                 string Passsword, int Permissions, string UserName, decimal Salary, string ImagePath)
        {

            int UserID = -1;

            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            PersonID = AddDataToPerson(FirstName, LastName, Gender, Email, Phone);


            string query = @"INSERT INTO [dbo].[Employees]
           ([Permissions]
           ,[UserName]
           ,[Passsword]
           ,[Salary]
           ,[ImagePath]
           ,[PersonID])
     VALUES
           (@Permissions
           ,@UserName
           ,@Passsword
           ,@Salary
           ,@ImagePath
           ,@PersonID);
select SCOPE_IDENTITY();";

            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Passsword", Passsword);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (ImagePath !="")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                connection.Open();

                int Insert = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out Insert))
                {
                    UserID = Insert;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return UserID;
        }


        public static bool UpdateEmployee(int EmployeeID, string FirstName, string LastName, char Gender, string Email, string Phone, string Password,
           int Permissions, string UserName, decimal Salary, string ImagePath)
        {

            int rowAffacte = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);



            string query = @"UPDATE [dbo].[Person]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Gender] = @Gender
      ,[Email] = @Email
      ,[Phone] = @Phone
 WHERE Person.ID = (select PersonID from Employees where EmployeeID = @EmployeeID);

 UPDATE [dbo].[Employees]
   SET [Permissions] = @Permissions
      ,[UserName] = @UserName
      ,[Passsword] = @Passsword
      ,[Salary] = @Salary
      ,[ImagePath] = @ImagePath
 WHERE EmployeeID = @EmployeeID";



            //string query2 = @"";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@Passsword", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Salary", Salary);

            if (ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                connection.Open();


                rowAffacte = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowAffacte = 0;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowAffacte > 0);

        }


        public static bool DeleteEmployee(int EmployeeID)
        {


            int PersonIDInAuothersTable = 0;
            int rowAffact = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select PersonID from Employees where EmployeeID = @EmployeeID ;
                Delete Employees where EmployeeID = @EmployeeID;";






            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);




            try
            {
                connection.Open();
                int PersonID = -1;
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                    PersonIDInAuothersTable = PersonID;

                    DeletePersonByID(PersonIDInAuothersTable);
                    rowAffact = 1;
                }

            }
            catch (Exception ex)
            {
                rowAffact = 0;

            }
            finally
            {
                connection.Close();
            }

            return (rowAffact > 0);

        }


        public static bool IsEmployeeExist(int EmployeeID)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Found = 1   
                    FROM  Employees INNER JOIN
                         Person ON Employees.PersonID = Person.ID 
                  WHERE Employees.EmployeeID = @EmployeeID  ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static bool IsEmployeeExistByUserNameAndPassword(string UserName, string Password)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Found = 1   
                    FROM  Employees INNER JOIN
                         Person ON Employees.PersonID = Person.ID 
                  WHERE Employees.UserName = @UserName  and Employees.Passsword = @Password ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }



        public static DataTable GetAllEmployees()
        {

            DataTable EmployeesDataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Employees.EmployeeID, Person.FirstName, Person.LastName, Person.Gender, Employees.UserName, Employees.Passsword, Employees.Salary, Person.Email, Person.Phone, Employees.Permissions , Employees.ImagePath
FROM            Employees INNER JOIN
                         Person ON Employees.PersonID = Person.ID";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    EmployeesDataTable.Load(reader);
                }


                reader.Close();

            }
            catch (Exception ex)
            {
                EmployeesDataTable = null;

            }
            finally
            {
                connection.Close();
            }


            return EmployeesDataTable;

        }



    }



}
