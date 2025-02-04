using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class UserDetails"/> for the oreder details
    /// </summary>

    public class UserDetails
    {
         /// <summary>
        /// /used to provide field private static field
        /// </summary>
        private double _balance=0;
        /// <summary>
        /// /used to provide field 
        /// </summary>
        private static int s_userID=3000;
        /// <summary>
        /// /UserID is the string for this class
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string UserID { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string UserName { get; set; }
         /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string Gender { get; set; }
         /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public DepartmentDetails Department { get; set; }
         /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string MobileNumber { get; set; }
         /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string MailID { get; set; }
         /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public double Wallet { get{return _balance;} }
        /// <summary>
        /// default constructor for this class 
        /// </summary>
        /// <param name="userName">reuturns the string to the corresponding value</param>
        /// <param name="gender">reuturns the string to the corresponding value</param>
        /// <param name="department">reuturns the string to the corresponding value</param>
        /// <param name="mobileNumber">reuturns the string to the corresponding value</param>
        /// <param name="mailID">reuturns the string to the corresponding value</param>
        /// <param name="walletBalance">reuturns the string to the corresponding value</param>
        public UserDetails(string userName,string gender,DepartmentDetails department,string mobileNumber,string mailID,double walletBalance)
        {
            UserID=$"SF{++s_userID}";
            UserName=userName;
            Gender=gender;
            Department=Department;
            MobileNumber=mobileNumber;
            MailID=mailID;
            _balance=walletBalance;
        }
        /// <summary>
        /// method used to find balance for the field
        /// </summary>
        /// <param name="amount">reuturns the string to the corresponding value</param>

        public void Recharge(double amount)
        {
            _balance+=amount;
        }
        ///method useed to find the deuduction
        /// </summary>
        /// <param name="amount">reuturns the string to the corresponding value</param>

        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
}