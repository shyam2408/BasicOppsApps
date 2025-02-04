using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissionforCollege
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class AdmissionDetails"/> for the oreder details
    /// </summary>
    public class AdmissionDetails
    {
        /// <summary>
        /// private static field for order ID
        /// </summary>
        private static int s_admissionID = 1001;
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string AdmissionID { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string StudentID { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string DepartmentID { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public DateTime AdmissionDate { get; set; }
        /// <summary>
        /// orderID will be stored in the form of string
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public AdmissionStatus Status { get; set; }
        /// <summary>
        /// parametered constructor for this class
        /// </summary>
        /// <param name="studentID">rerturns a string to coresbonding value</param>
        /// <param name="departmentID">rerturns a string to coresbonding value</param>
        /// <param name="admissionDate">rerturns a string to coresbonding value</param>
        /// <param name="status">rerturns a string to coresbonding value</param>
        public AdmissionDetails(string studentID, string departmentID, DateTime admissionDate, AdmissionStatus status)
        {
            AdmissionID = $"AID{++s_admissionID}";
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            Status = status;
        }
    }
}