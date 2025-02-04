using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    /// <summary>
    /// Class StudentDetails <see cref="StudentDetails"/> <see cref="www.SyncFusion.com"/> used for  creating instance for each student 
    /// </summary>
    public class StudentDetails
    {
        /*properties
        //name,fathername,gender,dob,physics,chemistry,maths

        private string _firstName;////feild*/

        private static int s_studentID = 4000;//icrementing purposes
        /// <summary>
        ///Feild StudentID used to provide  student id for an instance of <see cref="StudentDetails"/>
        /// </summary>
        /// <value> SF01 to SF1000 </value

        public String StudentID { get; set; }//to store student id
        /// <summary>
        /// property usedm to provide name for an instance of <see cref="StudentDetails"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }//auto implemented properties----accessors --read only
        /// <summary>
        /// property fathername used to provide fathername for an instance of <see cref="StudentDetails"/>
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// property gender used to provide gender for an instance of <see cref="StudentDetails"/>
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>

        /// <summary>
        /// property DOB used to provide Date for an instance of <see cref="StudentDetails"
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        //Constructors--behaviours/methods --used to assign values to its attributes
        //default

        /// <summary>
        /// used to initialize properties using parameter value for an instance of <see cref="StudentDetails"/>
        /// </summary>
        /// <param name="name"></param>parameter name is a string. It used to assign values to property Name <param>
        /// <param name="fathername">Parameter Father name is a string. It used to assign property Name </param>
        /// <param name="gender">Parameter Father name is a string. It used to assign property Name <param>
        /// <param name="dob">Parameter Father name is a string. It used to assign property Name </param>
        /// <param name="physics">Parameter Father name is a string. It used to assign property Name <param>
        /// <param name="chemistry">Parameter Chemistrt is a INT. It used to assign property Name </param
        /// <param name="maths"> <summary>parameter Maths is a Int . It used to assign propertu name</param>


        //Parameters Constructor
        public StudentDetails(string name, string fathername, DateTime dob, GenderDetails gender, string phoneNumber, string eMailID, int physics, int chemistry, int maths)
        {
            //assign parameter values to properties
            StudentID = $"SF{++s_studentID}";
            Name = name;
            FatherName = fathername;
            DOB = dob;
            Gender = gender;
            PhoneNumber = phoneNumber;
            EmailId = eMailID;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">parameter name is a string. It used to assign values to property Name <param>
        /// <param name="fathername">Parameter Father name is a string. It used to assign property Name </param>
        /// <param name="gender">Parameter Father name is a string. It used to assign property Name </param>
        /// <param name="dob">Parameter Father name is a string. It used to assign property Name </param>

        /// <summary>
        /// Total()  method will find sum of physics,Chemistry and Maths property values
        /// </summary>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <returns> Returns the average of physiics and chemidtry and maths </returns>
        public int Total()
        {
            return Physics + Chemistry + Maths;
        }
        /// <summary>
        /// Mehtod Average() used to find the student is eligible for admission or not 
        /// </summary>
        /// <returns>Returns the average of marks</returns>
        public double Average()
        {
            return (double)Total() / 3;
        }
        /// <summary>
        /// Mehtod Average() used to find the student is eligible for admission or not 
        /// </summary>
        /// <param name="cutoff">used for finding cuttoff marks for the student</param>
        /// <returns>either true or false based on the cutff percentage</returns>
        public bool IsEligible(double cutoff)
        {
            if (Average() >= cutoff)
            {
                return true;
            }
            return false;
        }
    }
}