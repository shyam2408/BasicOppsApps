using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class BookDetails"/> for the oreder details
    /// </summary>
    public class BookDetails
    {
        /// <summary>
        /// /used to provide field private static field
        /// </summary>
        private static int s_bookID=1000;
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string BookID { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string BookName { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>reuturns the string to the corresponding value</value>
        public string AuthorName { get; set; }
        /// <summary>
        /// Username is a string used to provide name to the user
        /// </summary>
        /// <value>returns the string to the corresponding value</value>
        public AvailablityDetails Availablity { get; set; }
        /// <summary>
        /// parameterized constructor for this class
        /// </summary>
        /// <param name="bookID">returns the string to the corresponding value</param>
        /// <param name="bookName">returns the string to the corresponding value</param>
        /// <param name="authorName">returns the string to the corresponding value</param>
        /// <param name="availablity">returns the string to the corresponding value</param>
        public BookDetails(string bookID,string bookName,string authorName,AvailablityDetails availablity)
        {
            BookID=$"BID{++s_bookID}";
            BookName=bookName;
            AuthorName=authorName;
            Availablity=availablity;
        }
    }
}