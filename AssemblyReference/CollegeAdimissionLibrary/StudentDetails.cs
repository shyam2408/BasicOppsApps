using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionLibrary;
    public class StudentDetails
    {
        
        private static int s_studentID=4000;//icrementing purposes
        public String StudentID { get; set; }//to store student id
        public string Name { get; set; }//auto implemented properties----accessors --read only
        public string FatherName { get;set;}
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        //Constructors--behaviours/methods --used to assign values to its attributes
        //default
        public StudentDetails()//constructors
        {
            Name="";
            FatherName="";
            DOB=DateTime.Now;
            Gender=GenderDetails.unknown;
        }
        //Parameters Constructor
        public StudentDetails(string name,string fathername,GenderDetails gender,DateTime dob,int physics,int chemistry,int maths)
        {
            //assign parameter values to properties
            StudentID=$"SF{++s_studentID}";
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public StudentDetails(string name,string fathername,GenderDetails gender,DateTime dob)
        {
            //assign parameter values to properties
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
           
        }
        /*~StudentDetails()
        {

        }*/
        public int Total()
        {
            return Physics+Chemistry+Maths;
        }
        public double Average()
        {
            return (double)Total()/3;
        }
        public bool IsEligible(double cutoff)
        {
            if(Average()>=cutoff)
            {
                return true;
            }
            return false;
        }
    }
