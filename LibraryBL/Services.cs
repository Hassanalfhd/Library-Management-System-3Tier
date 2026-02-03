using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LibraryDataAccesse;

namespace LibraryBusinessLaryer
{
  
    abstract public class clsPerson
    {

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public char Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        protected enum enMode { AddMode = 0, UpdateMode = 1 }
        protected enMode _Mode;
        public string FullName 
        {
            get
            {
                return  FirstName + " " + LastName;
                
            }
        }

        public clsPerson(int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            _Mode = enMode.UpdateMode;
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = ' ';
            this.Email = "";
            this.Phone = "";
            _Mode = enMode.AddMode;
        
        }


       // protected static clsPerson Find(int AuotherID)
       //{
       // string FirstName = "", LastName = "", Email = "" , Phone = "" ;
       //    char Gender = ' ' ;
       //    int PersonID = -1 ;

       //    if (clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone))
       //    {
       //        return new clsPerson(PersonID, FirstName, LastName, Gender, Email, Phone);
       //    }
       //    else
       //        return null;


       //}

       // protected static clsPerson Find(string FirstName)
       //{
       //    string  LastName = "", Email = "", Phone = "";
       //    char Gender = ' ';
       //    int PersonID = -1, AuotherID = -1;

       //    if (clsPersonDataAccess.GetPersonInfoByName(ref PersonID, FirstName, ref LastName, ref Gender, ref Email, ref Phone))
       //    {
       //        return new clsPerson(PersonID, FirstName, LastName, Gender, Email, Phone);
       //    }
       //    else
       //        return null;


       //}



    }


   public class clsAuother : clsPerson
   {

       public int AuotherID { set; get; }


       private clsAuother(int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone, int AuotherID)
        : base(PersonID, FirstName, LastName, Gender, Email, Phone)
       {
           this.AuotherID = AuotherID;
       }


       public clsAuother() 
       {
           this.AuotherID = -1;
       }


       public static clsAuother Find(int  AuotherID)
       {
        string FirstName = "", LastName = "", Email = "" , Phone = "" ;
           char Gender = ' ' ;
           int PersonID = -1 ;

           if (clsAuotherDataAccess.GetAuotherInfoByID(AuotherID, ref PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone))
           {
               return new clsAuother(PersonID, FirstName, LastName, Gender, Email, Phone, AuotherID);
           }
           else
               return null;


       }

       public static clsAuother Find(string FirstName)
       {
           string  LastName = "", Email = "", Phone = "";
           char Gender = ' ';
           int PersonID = -1, AuotherID = -1;

           if (clsAuotherDataAccess.GetAuotherInfoByName(ref AuotherID, ref PersonID,  FirstName, ref LastName, ref Gender, ref Email, ref Phone))
           {
               return new clsAuother(PersonID, FirstName, LastName, Gender, Email, Phone, AuotherID);
           }
           else
               return null;


       }




       private bool _AddNewAuother()
       {
           this.AuotherID = clsAuotherDataAccess.AddNewAuother(this.FirstName, this.LastName, this.Gender, this.Email, this.Phone);

           return (this.AuotherID != -1);
       }

       private bool _UpdateAuother()
       {
           return clsAuotherDataAccess.UpdateAuother(this.AuotherID, this.PersonID, this.FirstName, this.LastName, this.Gender, this.Email, this.Phone);
       }

       public bool Save()
       {

           switch (_Mode)
           { 
               case enMode.AddMode:
                   if (_AddNewAuother())
                   {
                       _Mode = enMode.UpdateMode;
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateAuother();
           }

           return false;
       }


       public static  bool DeleteAuother(int ID)
       {
           return clsAuotherDataAccess.DeleteAuother(ID);
       }

       public static bool IsAuotherExist(int ID)
       {
           return clsAuotherDataAccess.IsAuotherExist(ID);
       }

       public static DataTable GetAllAuothers()
       {
           return clsAuotherDataAccess.GetAllAuothers();
       }


     }


   public class clsUser : clsPerson
   {

       public int UserID { set; get; }
       public string Password {set;get;}
       public string LibraryCard {set;get;}

       private clsUser(int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone, int UserID , string Password, string LibraryCard)
           : base(PersonID, FirstName, LastName, Gender, Email, Phone)
       {
           this.UserID = UserID;
           this.Password = Password;
           this.LibraryCard = LibraryCard;
       }



       public clsUser()
       {
           this.UserID = -1;
           this.Password = "";
           this.LibraryCard = "";

       }


       public static clsUser Find(int UserID)
       {
           string FirstName = "", LastName = "", Email = "", Phone = "", Password = "" ,LibraryCard = "";
           char Gender = ' ';
           int PersonID = -1;

           if (clsUserDataAccess.GetUserInfoByID(UserID, ref PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone, ref Password, ref LibraryCard))
           {
               return new clsUser(PersonID, FirstName, LastName, Gender, Email, Phone, UserID, Password, LibraryCard);
           }
           else
               return null;

       }


       public static clsUser Find(string FirstName)
       {
           string  LastName = "", Email = "", Phone = "", Password = "", LibraryCard = "";
           char Gender = ' ';
           int PersonID = -1 , UserID = -1;

           if (clsUserDataAccess.GetUserInfoByName(ref UserID, ref PersonID,  FirstName, ref LastName, ref Gender, ref Email, ref Phone, ref Password, ref LibraryCard))
           {
               return new clsUser(PersonID, FirstName, LastName, Gender, Email, Phone, UserID, Password, LibraryCard);
           }
           else
               return null;

       }



       private bool _AddNewUser()
       {
           this.UserID = clsUserDataAccess.AddNewUser(this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.Password, this.LibraryCard);

           return (this.UserID != -1);
       }


       private bool _UpdateUser()
       {
           return clsUserDataAccess.UpdateUser(this.UserID,this.PersonID, this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.Password, this.LibraryCard);
       }
   

       public bool Save()
       {

           switch (_Mode)
           {
               case enMode.AddMode:
                   if (_AddNewUser())
                   {
                       _Mode = enMode.UpdateMode;
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateUser();
           }

           return false;
       }


       public static  bool DeleteUser(int UserID)
       {
           return clsUserDataAccess.DeleteUser(UserID);
       }

       public static bool IsUserExist(int ID)
       {
           return clsUserDataAccess.IsUserExist(ID);
       }

       public static DataTable GetAllUsers()
       {
           return clsUserDataAccess.GetAllUsers();
       }



   }


   public class clsBook
   {
       private enum enMode { AddMode = 0, UpdateMode = 1 }
       private enMode _Mode;
       public int ID { set; get; }
       public string Title { set; get; }
       public string ISBN { set; get; }
       public DateTime PublictionDate { set; get; }
       public string Genre { set; get; }
       public string AdditionalDetalis { set; get; }
       public string ImagePath { set; get; }
       public int AuotherID { set; get; }

       private clsBook(int ID, string Title, string ISBN, DateTime PublictionDate, string Genre, string AdditionalDetalis, int AuotherID, string ImagePath)
       {
           this.ID = ID;
           this.Title = Title;
           this.ISBN = ISBN;
           this.PublictionDate = PublictionDate;
           this.Genre = Genre;
           this.AdditionalDetalis = AdditionalDetalis;
           this.AuotherID = AuotherID;
           this.ImagePath = ImagePath;
           _Mode = enMode.UpdateMode;
       }

       public clsBook()
       {
           this.ID = -1;
           this.Title = "";
           this.ISBN = "";
           this.PublictionDate = DateTime.Now;
           this.Genre = "";
           this.AdditionalDetalis = "";
           this.AuotherID = -1;
           this.ImagePath = "";

           _Mode = enMode.AddMode;
       }

       public static clsBook Find(int ID)
       {
           string Title = "", ISBN = "", Genre = "", AdditionalDetalis = "", ImagePath = "";
           int AuotherID = -1;
           DateTime PublictionDate = DateTime.Now;

           if (Entities.GetBookInfoByID(ID, ref Title, ref ISBN, ref PublictionDate, ref Genre, ref AdditionalDetalis, ref AuotherID, ref  ImagePath))
           {
               return new clsBook(ID, Title, ISBN, PublictionDate, Genre, AdditionalDetalis, AuotherID, ImagePath);
           }
           else
               return null;
       }

       public static clsBook Find(string Title)
       {
           string ISBN = "", Genre = "", AdditionalDetalis = "", ImagePath = "";
           int AuotherID = -1, ID = -1;
           DateTime PublictionDate = DateTime.Now;

           if (Entities.GetBookInfoByTitle(ref ID, Title, ref ISBN, ref PublictionDate, ref Genre, ref AdditionalDetalis, ref AuotherID, ref ImagePath))
           {
               return new clsBook(ID, Title, ISBN, PublictionDate, Genre, AdditionalDetalis, AuotherID, ImagePath);
           }
           else
               return null;
       }

       public static clsBook FindByISBN(string ISBN)
       {
           string Title = "", Genre = "", AdditionalDetalis = "", ImagePath = "";
           int AuotherID = -1, ID = -1;
           DateTime PublictionDate = DateTime.Now;

           if (Entities.GetBookInfoByISBN(ref ID, ref Title, ISBN, ref PublictionDate, ref Genre, ref AdditionalDetalis, ref AuotherID, ref ImagePath))
           {
               return new clsBook(ID, Title, ISBN, PublictionDate, Genre, AdditionalDetalis, AuotherID, ImagePath);
           }
           else
               return null;
       }

       


       private bool _AddNewBook()
       {

           this.ID = Entities.AddNewBook(this.Title, this.ISBN, this.PublictionDate, this.Genre, this.AdditionalDetalis, this.AuotherID, this.ImagePath);

           return (this.ID != -1);

       }

       private bool _UpdateBook()
       {
           return Entities.UpdateBook(this.ID, this.Title, this.ISBN, this.PublictionDate, this.Genre, this.AdditionalDetalis, this.AuotherID, this.ImagePath);
       }

       public bool Save()
       {

           switch (_Mode)
           {
               case enMode.AddMode:
                   if (_AddNewBook())
                   {
                       _Mode = enMode.UpdateMode;
                       return true;
                   }
                   else
                   {
                       return false;
                   }

               case enMode.UpdateMode:
                   return _UpdateBook();
           }


           return false;
       }

       public static bool DeleteBook(int ID)
       {
           return Entities.DeleteBook(ID);
       }

       public static bool IsBookExist(int ID)
       {
           return Entities.IsBookExist(ID);
       }

       public static DataTable GetAllBook()
       {
           return Entities.GetAllBook();
       }


   }


   public class clsBookCopies
   {

      private enum enMode {AddMode = 0 , UpdateMode = 1 }

      private enMode _Mode;

       public int CopyID { set; get; }
       public int BookID { set; get; }
       public bool AvailabilityStauts { set; get; }


       private clsBookCopies(int CopyID, int BookID, bool AvailabilityStauts)
       {
           this.CopyID = CopyID;
           this.BookID = BookID;
           this.AvailabilityStauts = AvailabilityStauts;

           _Mode = enMode.UpdateMode;
        
       }

       public clsBookCopies()
       {
           this.CopyID = -1;
           this.BookID = -1;
           this.AvailabilityStauts = false;
           _Mode = enMode.AddMode;
       }

       public static clsBookCopies Find(int CopyID)
       {

           int BookID = -1;
           bool AvailabilityStauts = false;

           if (clsBookCopiesDataAccess.GetBookCopiesInfoByID(CopyID, ref BookID, ref AvailabilityStauts))
               return new clsBookCopies(CopyID, BookID, AvailabilityStauts);
           else
               return null;
       }


       public static clsBookCopies Find(bool AvailabilityStauts)
       {

           int BookID = -1 , CopyID = -1;

           if (clsBookCopiesDataAccess.GetBookCopiesInfoByAvailabilityStauts(ref CopyID, ref BookID, AvailabilityStauts))
               return new clsBookCopies(CopyID, BookID, AvailabilityStauts);
           else
               return null;
       }

       private bool _AddNewBookCopy()
       {
           this.CopyID = clsBookCopiesDataAccess.AddNewBookCopy(this.BookID, AvailabilityStauts);

             return (this.CopyID != -1);
       }

       private bool _UpdateBookCopy()
       {
           return clsBookCopiesDataAccess.UpdateBookCopy(this.CopyID, this.BookID, this.AvailabilityStauts);
       }


       public bool Save()
       {
           switch (_Mode)
           { 
               case enMode.AddMode:
                   if (_AddNewBookCopy())
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateBookCopy();
           }

           return false;
       }


       public static bool DeleteBookCopy(int CopyID)
       {
           return clsBookCopiesDataAccess.DeleteBookCopy(CopyID);
       }

       public static bool IsBookCopyExist(int CopyID)
       {
           return clsBookCopiesDataAccess.IsBookCopyExist(CopyID);
       }

       public static DataTable GetAllBookCopies()
       {
           return clsBookCopiesDataAccess.GetAllBookCopies();
       }

       public static DataTable GetAllBookCopiesWithDistinct()
       {
           return clsBookCopiesDataAccess.GetAllBookCopiesWithDistinct();
       }

       public static DataTable GetAllBookCopies(int BookID)
       {
           return clsBookCopiesDataAccess.GetAllBookCopiesByBookID(BookID);
       }

   }


   public class clsBorrowingRecord
   {
      private enum enMode {AddMode = 0 , UpdateMode = 1 }
       private enMode _Mode;
       public int BorrowingRecordID { set; get; }
       public int CopyID { set; get; }
       public int UserID { set; get; }
       public  DateTime BorrowingDate { set; get; }
       public DateTime DueDate { set; get; }
       public Nullable< DateTime> ActualReturnDate { set; get; }


       private clsBorrowingRecord(int BorrowingRecordID, int CopyID, int UserID, DateTime BorrowingDate, DateTime DueDate, Nullable<DateTime> ActualReturnDate)
       {
           this.BorrowingRecordID = BorrowingRecordID;
           this.CopyID = CopyID;
           this.UserID = UserID;
           this.BorrowingDate = BorrowingDate;
           this.DueDate = DueDate;
           this.ActualReturnDate = ActualReturnDate;

           _Mode = enMode.UpdateMode;
       }


       public clsBorrowingRecord()
       {
           this.BorrowingRecordID = -1;
           this.CopyID = -1;
           this.UserID = -1;
           this.BorrowingDate = DateTime.Now;
           this.DueDate = this.BorrowingDate.AddDays(3) ;
           this.ActualReturnDate = null;
           _Mode = enMode.AddMode;
       }

       public static clsBorrowingRecord Find(int BorrowingRecordID)
       {
           int CopyID = -1, UserID = -1;
           DateTime BorrowingDate = DateTime.Now, DueDate = DateTime.Now;
           Nullable<DateTime> ActualReturnDate = null;

           if (clsBorrowingRecordDataAccess.GetBorrowingRecordInfoByBorrowingRecordsID(BorrowingRecordID, ref CopyID, ref UserID, ref BorrowingDate, ref DueDate, ref ActualReturnDate))
           {

               return new clsBorrowingRecord(BorrowingRecordID, CopyID, UserID, BorrowingDate, DueDate, ActualReturnDate);
           }
           else
               return null;
       }

       public static clsBorrowingRecord FindByCopyID(int CopyID)
       {
           int BorrowingRecordID = -1, UserID = -1;
           DateTime BorrowingDate = DateTime.Now, DueDate = DateTime.Now;
           Nullable<DateTime> ActualReturnDate = null;

           if (clsBorrowingRecordDataAccess.GetBorrowingRecordInfoByCopyID(ref BorrowingRecordID,  CopyID, ref UserID, ref BorrowingDate, ref DueDate, ref ActualReturnDate))
           {

               return new clsBorrowingRecord(BorrowingRecordID, CopyID, UserID, BorrowingDate, DueDate, ActualReturnDate);
           }
           else
               return null;
       }

       public static clsBorrowingRecord FindByUserID(int UserID)
       {
           int BorrowingRecordID = -1, CopyID = -1;
           DateTime BorrowingDate = DateTime.Now, DueDate = DateTime.Now;
           Nullable<DateTime> ActualReturnDate = null;

           if (clsBorrowingRecordDataAccess.GetBorrowingRecordInfoByUserID(ref BorrowingRecordID, ref CopyID,  UserID, ref BorrowingDate, ref DueDate, ref ActualReturnDate))
           {

               return new clsBorrowingRecord(BorrowingRecordID, CopyID, UserID, BorrowingDate, DueDate, ActualReturnDate);
           }
           else
               return null;
       }

       private bool _AddNewBorrowingRecord()
       {
           this.BorrowingRecordID = clsBorrowingRecordDataAccess.AddNewBorrowingRecord(this.CopyID, this.UserID, this.BorrowingDate, this.DueDate, this.ActualReturnDate);

           return (this.BorrowingRecordID != -1);
       }

       private bool _UpdateBorrowingRecords()
       {
           return clsBorrowingRecordDataAccess.UpdateBorrowingRecord(this.BorrowingRecordID, this.CopyID, this.UserID, this.BorrowingDate, this.DueDate, this.ActualReturnDate);
       }

       public bool Save()
       {
           switch (_Mode)
           {
               case enMode.AddMode:
                   if (_AddNewBorrowingRecord())
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateBorrowingRecords();
           }

           return false;
       }


       public static bool DeleteBorrowingRecord(int BorrowingRecordID)
       {
           return clsBorrowingRecordDataAccess.DeleteBorrowingRecord(BorrowingRecordID);
       }

       public static bool IsBorrowingRecordExist(int BorrowingRecordID)
       {
           return clsBorrowingRecordDataAccess.IsBorrowingRecordExist(BorrowingRecordID);
       }


       public static DataTable GetAllBorrowingRecords()
       {
           return clsBorrowingRecordDataAccess.GetAllBorrowingRecords();
       }


   }


   public class clsFine
   {

       private enum enMode { AddMode = 0, UpdateMode = 1 }
       private enMode _Mode;
       public int FineID { set; get; }
       public int UserID { set; get; }
       public int BorrowingRecordsID { set; get; }
       public short NumberOfLateDays { set; get; }
       public decimal FineAmount { set; get; }
       public bool PaymentStauts { set; get; }


       private clsFine(int FineID, int UserID, int BorrowingRecordsID, short NumberOfLateDays, decimal FineAmount, bool PaymentStauts)
       {

           this.FineID = FineID;
           this.UserID = UserID;
           this.BorrowingRecordsID = BorrowingRecordsID;
           this.NumberOfLateDays = NumberOfLateDays;
           this.FineAmount = FineAmount;
           this.PaymentStauts = PaymentStauts;

           _Mode = enMode.UpdateMode;

       }

       public clsFine()
       {
           this.FineID = -1;
           this.UserID = -1;
           this.BorrowingRecordsID = -1;
           this.NumberOfLateDays = 0;
           this.FineAmount = 0;
           this.PaymentStauts = false;

           _Mode = enMode.AddMode;

       }

       public static clsFine Find(int FineID)
       {
           int UserID = -1, BorrowingRecordsID = -1; short NumberOfLateDays = 0;
           decimal FineAmount = 0;
           bool PaymentStauts = false;

           if (clsFinesDataAccess.GetFineInfoByID(FineID, ref UserID, ref BorrowingRecordsID, ref NumberOfLateDays, ref FineAmount, ref PaymentStauts))
           {
               return new clsFine(FineID, UserID, BorrowingRecordsID, NumberOfLateDays, FineAmount, PaymentStauts);
           }
           else
               return null;
       }

       private bool _AddNewFine()
       {
           this.FineID = clsFinesDataAccess.AddNewFine(this.UserID, this.BorrowingRecordsID, this.NumberOfLateDays, this.FineAmount, this.PaymentStauts);

           return (this.FineID != -1);
       }

       private bool _UpdateFine()
       {
           return clsFinesDataAccess.UpdateFine(this.FineID, this.UserID, this.BorrowingRecordsID, this.NumberOfLateDays, this.FineAmount, this.PaymentStauts);
       }

       public bool Save()
       {
           switch (_Mode)
           {
               case enMode.AddMode:
                   if (_AddNewFine())
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateFine();
           }

           return false;
       }

       public static bool DeleteFine(int FineID)
       {
           return clsFinesDataAccess.DeleteFine(FineID);
       }

       public static bool IsFineExist(int FineID)
       {
           return clsFinesDataAccess.IsFineExist(FineID);
       }

       public static DataTable GetAllFines()
       {
           return clsFinesDataAccess.GetAllFines();
       }


       public static DataTable GetAllFinesJoinData()
       {
           return clsFinesDataAccess.GetAllFinesJoinData();
       }




   }


   public class clsReservation
   {
       private enum enMode {AddMode = 0, UpdateMode = 1 }
       private enMode _Mode ;
       public int ReservationID { set; get; }
       public int UserID { set; get; }
       public int CopyID { set; get; }
       public DateTime ReservationDate { set; get; }


       private clsReservation(int ReservationID, int UserID, int CopyID, DateTime ReservationDate)
       {

           this.ReservationID = ReservationID;
           this.UserID = UserID;
           this.CopyID = CopyID;
           this.ReservationDate = ReservationDate;

           _Mode = enMode.UpdateMode;
       }

       public clsReservation()
       {
           this.ReservationID = -1;
           this.UserID = -1;
           this.CopyID = -1;
           this.ReservationDate = DateTime.Now;

           _Mode = enMode.AddMode;
       }


       public static clsReservation Find(int ReservationID)
       {
           int UserID = -1, CopyID = -1;
           DateTime ReservationDate = DateTime.Now;


           if (clsReservationDataAccess.GetReservationInfoById(ReservationID, ref UserID, ref CopyID, ref ReservationDate))
           {
               return new clsReservation(ReservationID, UserID, CopyID, ReservationDate);
           }
           else
               return null;
        }


       private bool _AddNewReservation()
       {
           this.ReservationID = clsReservationDataAccess.AddNewReservation(this.UserID, this.CopyID, this.ReservationDate);
       
        return (this.ReservationID != -1);
       
       }

       private bool _UpdateReservation()
       {
           return clsReservationDataAccess.UpdateReservation(this.ReservationID, this.UserID, this.CopyID, this.ReservationDate);
       }

       public bool Save()
       {

           switch (_Mode)
           {    
               case enMode.AddMode:
                   if (_AddNewReservation())
                   {
                       _Mode = enMode.UpdateMode;
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateReservation();
           }


           return false;
       }
   
        public static bool DeleteResrvation(int ReservationID)
        {
            return clsReservationDataAccess.DeleteReservation(ReservationID);
        }
     
        public static bool IsResrvationExist(int ReservationID)
        {
            return clsReservationDataAccess.IsReservationExist(ReservationID);
        }


        public static DataTable GetAllReservations()
        {
            return clsReservationDataAccess.GetAllReservations();
        }
        public static DataTable GetAllReservationsTextData()
        {
            return clsReservationDataAccess.GetAllReservationsTextData();
        }

       
   }

   public class clsSetting
   {

       public static int DefaultBorrowDays 
       {
           get
           {
               return clsSettingDataAccess.GetDefaultBorrowDays(); 
           }
           
        }

       public static int DefaultFinePerDay
       {
           get
           {
               return clsSettingDataAccess.GetDefaultFinePerDay();
           }

       }

   
        
   }


   public class clsEmployee : clsPerson
   {

       public  enum enPermissinos
       {
           pAll = -1, pBook = 1,
           pBorrowing = 2,
           pReservation = 4, pFines = 8, pMembers = 16, pEmployees = 32,pAuother = 64
       }





       public int EmployeeID { set; get; }
       public string UserName { set; get; }
       public int Permissions { set; get; }
       public decimal Salary { set; get; }
       public string Password { set; get; }
       public string ImagePath { set; get; }


       private clsEmployee(int PersonID, string FirstName, string LastName, char Gender, string Email, string Phone, int EmployeeID, string Password
           , int Permissions, string UserName, decimal Salary, string ImagePath = "")
           : base(PersonID, FirstName, LastName, Gender, Email, Phone)
       {

           this.EmployeeID = EmployeeID;
           this.Password = Password;
           this.UserName = UserName;
           this.Permissions = Permissions;
           this.Salary = Salary;
           this.ImagePath = ImagePath;
       }



       public clsEmployee()
       {
           this.EmployeeID = -1;
           this.UserName = "";
           this.Password = "";
           this.Permissions = -1;
           this.Salary = 0;

       }


       public static clsEmployee Find(int EmployeeID)
       {
           string FirstName = "", LastName = "", Email = "", Phone = "", Password = "", UserName = "", ImagePath = "";
           char Gender = ' ';
           int PersonID = -1, Permissions = -1;
           decimal Salary = 0;

           if (clsEmployeeDataAccess.GetEmployeeInfoByID(EmployeeID, ref PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone, ref Password, ref Permissions
               , ref UserName, ref Salary, ref ImagePath ))
           {
               return new clsEmployee(PersonID, FirstName, LastName, Gender, Email, Phone, EmployeeID, Password, Permissions, UserName, Salary, ImagePath);
           }
           else
               return null;

       }



       //public static clsEmployee Find(string UserName, string Password)
       //{
       //    string FirstName = "", LastName = "", Email = "", Phone = "";
       //    char Gender = ' ';
       //    int EmployeeID = -1, PersonID = -1, Permissions = -1;
       //    decimal Salary = 0;

       //    if (clsEmployeeDataAccess.GetEmployeeInfoByUserNameAndPassword(ref EmployeeID, ref PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone,  Password, ref Permissions,
       //        UserName, ref Salary))
       //    {
       //        return new clsEmployee(PersonID, FirstName, LastName, Gender, Email, Phone, EmployeeID, Password, Permissions, UserName, Salary);
       //    }
       //    else
       //        return null;

       //}


       public static clsEmployee Find(string UserName, string Password)
       {
           string FirstName = "", LastName = "", Email = "", Phone = "";
           char Gender = ' ';
           int EmployeeID = -1, PersonID = -1, Permissions = -1;
           decimal Salary = 0;
           string ImagePath = "";


           if (clsEmployeeDataAccess.GetEmployeeInfoByUserNameAndPassword(ref EmployeeID, ref PersonID, ref FirstName, ref LastName, ref Gender, ref Email, ref Phone, Password, ref Permissions,
               UserName, ref Salary, ref ImagePath))
           {
               return new clsEmployee(PersonID, FirstName, LastName, Gender, Email, Phone, EmployeeID, Password, Permissions, UserName, Salary, ImagePath);
           }
           else
               return null;

       }


       private bool _AddNewEmployee()
       {
           this.EmployeeID = clsEmployeeDataAccess.AddNewEmployee(this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.Password, this.Permissions, this.UserName, this.Salary, this.ImagePath);

           return (this.EmployeeID != -1);
       }


       private bool _UpdateEmployee()
       {
           return clsEmployeeDataAccess.UpdateEmployee(this.EmployeeID, this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.Password, this.Permissions, this.UserName, this.Salary, this.ImagePath);
       }


       public bool Save()
       {

           switch (_Mode)
           {
               case enMode.AddMode:
                   if (_AddNewEmployee())
                   {
                       _Mode = enMode.UpdateMode;
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enMode.UpdateMode:
                   return _UpdateEmployee();
           }

           return false;
       }


       public static bool DeleteEmployee(int EmployeeID)
       {
           return clsEmployeeDataAccess.DeleteEmployee(EmployeeID);
       }

       public static bool IsEmployeeExist(int EmployeeID)
       {
           return clsEmployeeDataAccess.IsEmployeeExist(EmployeeID);
       }

       public static bool IsEmployeeExist(string UserName, string Password)
       {
           return clsEmployeeDataAccess.IsEmployeeExistByUserNameAndPassword(UserName, Password);
       }


       public static DataTable GetAllEmployees()
       {
           return clsEmployeeDataAccess.GetAllEmployees();
       }


       public bool ChackAccessPermissinos(enPermissinos Permissinos)
       {
           if (this.Permissions == (int)enPermissinos.pAll)
               return true;

           if ((this.Permissions & (int)Permissinos) == (int)Permissinos)
               return true;
           else
               return false;
       }

   }



}
