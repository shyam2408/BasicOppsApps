using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CollegeAdmissionLibrary;

namespace Application;

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


        /*Get students 2  deatails
        //Create copy or object for that bluebrint student 2 details
        StudentDetails student2=new StudentDetails();
        Console.WriteLine("Enter your name: ");
        student2.Name=Console.ReadLine();
        Console.WriteLine("Enter your Father name: ");
        string fatherName2=Console.ReadLine();
        Console.WriteLine("Enter gender: ");
        string gender2=Console.ReadLine();
        Console.WriteLine("Enter you Date of birth:");
        DateTime dob2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine("Enter your physics mark: ");
        int physics2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your chemistry marks: ");
        int chemistry2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your maths marks: ");
        int maths2=Convert.ToInt32(Console.ReadLine());






        // Console.WriteLine($"Student details : \n Name:{student1.Name}\nFather Name:{student1.FatherName}\nGender:{student1.Gender}\nDob:{student1.DOB}\nPhysics mark:{student1.Chemistry}\nChemistry mark:{student1.Chemistry}\nMaths mark:{student1.Maths}");
        /*Console.WriteLine($"Student details : \n Name:{name2}\nFather Name:{fatherName2}\nGender:{gender2}\nDob:{dob2}\nPhysics mark:{physics2}\nChemistry mark:{chemistry2}\nMaths mark:{maths2}");
        Console.WriteLine($"Student details : \n Name:{name3}\nFather Name:{fatherName3}\nGender:{gender3}\nDob:{dob3}\nPhysics mark:{physics3}\nChemistry mark:{chemistry3}\nMaths mark:{maths3}");*/
    




