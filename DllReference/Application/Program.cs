using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CollegeAdmission;

namespace CollegeAdmission;

class Program
{
    public static void Main(string[] args)
    {
        //Get students 1  deatails
        //Create folder for putting copies of student form
        List<StudentDetails> students = new List<StudentDetails>();
        string Option = " ";
        do
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your Father name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
        ///enums
            /// enum with 
            GenderDetails gender=Enum.Parse<GenderDetails>(Console.ReadLine(),true);
            //string gender2 = Console.ReadLine();
            Console.WriteLine("Enter you Date of birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter your physics mark: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your chemistry marks: ");
            int chemistry= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your maths marks: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            StudentDetails student1=new StudentDetails(name,fatherName,gender,dob,physics,chemistry,maths);
            students.Add(student1);
            Console.WriteLine($"your registration is successful .Regestration Id{student1.StudentID}");
            //termination condition
            Console.WriteLine("Do you want to add another user?");
            Option = Console.ReadLine();
        } while (Option.ToLower() == "yes");
        Console.WriteLine("Enter your ID");
        string studentID=Console.ReadLine().ToUpper();

        foreach (StudentDetails student in students)
        {
            if(studentID.Equals(student.StudentID))
            {
                Console.WriteLine($"Student details : \n Name:{student.Name}\nFather Name:{student.FatherName}\nGender:{student.Gender}\nDob:{student.DOB}\nPhysics mark:{student.Chemistry}\nChemistry mark:{student.Chemistry}\nMaths mark:{student.Maths}");
                if(student.IsEligible(75))
                {
                    Console.WriteLine("you are eligible for admission");
                }
                else
                {
                    Console.WriteLine("you are not eligible for admission");
                }
            }
        }
    }
}







