using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissionforCollege
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class DepartmentDetails"/> for the oreder details
    /// </summary>
    public class DepartmentDetails
    {
        /// <summary>
        /// private static field for order ID
        /// </summary>
        private static int s_departmentID = 100;
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string DepartmentID { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string DepartmentName { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public int NumberOfSeats { get; set; }
        /// <summary>
        /// default constructor for this class
        /// </summary>
        /// <param name="departmentName">rerturns a string to coresbonding value</param>
        /// <param name="numberOfSeats">rerturns a integer to coresbonding value</param>
        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            DepartmentID = $"DID{++s_departmentID}";
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;

        }
    }
}