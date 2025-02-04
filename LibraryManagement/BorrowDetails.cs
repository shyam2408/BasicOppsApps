using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LibraryManagement
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class BorrowDetails"/> for the oreder details
    /// </summary>
    public class BorrowDetails
    {
        /// <summary>
        /// /used to provide field private static field
        /// </summary>
        private static int s_BorrowID=2000;
        /// <summary>
        /// /UserID is the string for this class
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string BorrowID { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string BookID { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string UserID { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public DateTime BorrowDate{ get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public BookingStatus Status{ get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public double PaidFineAmount { get; set; }
        /// <summary>
        /// default constructor for this class
        /// </summary>
        /// <param name="bookID">returns the string to the corresponding value</param>
        /// <param name="userID">returns the string to the corresponding value</param>
        /// <param name="borrowDate">returns the string to the corresponding value</param>
        /// <param name="status">returns the string to the corresponding value</param>
        /// <param name="paidFineAmount">returns the string to the corresponding value</param>
        public BorrowDetails(string bookID,string userID,DateTime borrowDate,BookingStatus status,double paidFineAmount)
        {
            BorrowID=$"LB{++s_BorrowID}";
            BookID=bookID;
            UserID=userID;
            BorrowDate=borrowDate;
            Status=status;
            PaidFineAmount=paidFineAmount;
        }
    }
}