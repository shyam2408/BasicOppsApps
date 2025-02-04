using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CollegeAdmission;

namespace StudentAdmissionforCollege
{
    public class Operations
    {
        //adding default values to the list
        List<StudentDetails> students = new List<StudentDetails>();
        List<DepartmentDetails> departments = new List<DepartmentDetails>();
        List<AdmissionDetails> admissions = new List<AdmissionDetails>();
        StudentDetails currentLoggedInStudent;
        public void DefaultData()
        {
            Console.WriteLine("Default data");


            StudentDetails student1 = new StudentDetails("Ravi E", "Ettapparajan", new DateTime(1999, 11, 16), GenderDetails.Male, "9870893412", "ravi@gmail.com", 92, 98, 91);
            StudentDetails student2 = new StudentDetails("Baskaran S", "Sethurajan", new DateTime(1999, 11, 17), GenderDetails.Male, "234564323", "boss@gmail.com", 91, 97, 90);
            students.AddRange(new List<StudentDetails>() { student1, student2 });


            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            DepartmentDetails department5 = new DepartmentDetails("AE", 30);
            departments.AddRange(new List<DepartmentDetails>() { department1, department2, department3, department4, department5 });




            AdmissionDetails admission1 = new AdmissionDetails("SF3001", "DID101", new DateTime(2024, 05, 11), AdmissionStatus.Admitted);
            AdmissionDetails admission2 = new AdmissionDetails("SF3002", "DID102", new DateTime(2024, 05, 12), AdmissionStatus.Cancelled);
            admissions.AddRange(new List<AdmissionDetails>() { admission1, admission2 });


        }

        public void MainMenu()
        {

            while (true)
            {
                //showing main menu to the user 
                Console.WriteLine("Welcome Student Admission for College (SyncCET)");
                Console.WriteLine("Main menu:\n1.	Student Registration\n2.	Student Login\n3.	Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }

                    case 3:
                        {
                            System.Console.WriteLine("Exit the application");
                            return;
                        }
                }
            }
        }

        public void Registration()
        {
            //getting inputs from the user 
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your FatherName:");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter Your DATE OF BIRTH:");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter Gender :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine("enter your phone number :");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("enter your EmailId:");
            string eMailID = Console.ReadLine();
            Console.WriteLine("Enter your physics marks: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your chemistry marks: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your maths marks: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            StudentDetails student = new StudentDetails(name, fatherName, doj, gender, phoneNumber, eMailID, physics, chemistry, maths);
            Console.WriteLine("Registration Successfull your StudentID is" + student.StudentID);
            Console.WriteLine("THANK YOU");
            students.Add(student);

        }

        public void Login()
        {
            Console.WriteLine("****User Login*****");
            Console.WriteLine("Enter your StudentID:");
            string studentID = Console.ReadLine().ToUpper();
            //traverse student list and find student is present or not
            bool flag = true;
            foreach (StudentDetails student in students)
            {
                if (studentID.Equals(student.StudentID))
                {
                    //LOGIN SUCCESSFULL
                    Console.WriteLine("Login Successful");
                    flag = false;
                    currentLoggedInStudent = student;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User....");
            }

        }

        public void SubMenu()
        {
            bool flag = true;
            do
            {
                //showing sub menu to the user 
                Console.WriteLine("***SubMenu****");
                Console.WriteLine("Enter the option :a.	Check Eligibility\nb.	Show Student Details \nc.	Take Admission \nd.	Cancel Admission \ne.	Show Admission History \nf.	Exit ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            CheckEligibility();
                            break;
                        }
                    case 2:
                        {
                            ShowDetails();
                            break;
                        }
                    case 3:
                        {
                            TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            ShowAdmissionHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Exit the menu");
                            break;
                        }
                }

            } while (flag);

        }


        public void CheckEligibility()
        {
            //ckecking eligiblity for the student
            Console.WriteLine(currentLoggedInStudent.IsEligible(75) ? "you are eligible" : "not eligible");
        }

        public void ShowDetails()
        {
            //showing details for the current logged student 
            foreach (StudentDetails currentLoggedInStudent in students)
            {
                Console.WriteLine($"|{currentLoggedInStudent.StudentID,-15} | {currentLoggedInStudent.Name,-15} | {currentLoggedInStudent.FatherName,-15} | {currentLoggedInStudent.DOB,-15} |{currentLoggedInStudent.PhoneNumber,-15} | {currentLoggedInStudent.Physics,-15} | {currentLoggedInStudent.Chemistry,-15} | {currentLoggedInStudent.Maths,-15}");
            }
        }

        public void TakeAdmission()
        {
            // Ask and get the DepartmentID from the student.   
            Console.WriteLine("Enter your DepartmentID:");
            string departmentID = Console.ReadLine().ToUpper();

            bool flag = true;
            //Display departments details by the departments list.
            foreach (DepartmentDetails department in departments)
            {
                ///  Check if the DepartmentID is present in the departments list.
                if (departmentID.Equals(department.DepartmentID))
                {
                    flag = false;
                    // student is not eligible display:” You are not eligible”.
                    if (currentLoggedInStudent.IsEligible(75))
                    {
                        bool admisiionTakenFlag = true;
                        // DepartmentID is present, then check if the student is eligible using the Check Eligibility method.
                        foreach (AdmissionDetails admission in admissions)
                        {
                            /// DepartmentID is not present, then shows “Invalid DepartmentID”.
                            if (admission.StudentID.Equals(currentLoggedInStudent.StudentID) && admission.Status.Equals(AdmissionStatus.Admitted))
                            {
                                admisiionTakenFlag = true;
                                break;
                            }
                        }
                        if (admisiionTakenFlag)
                        {
                            //checkin eligiblity for taking admissions
                            System.Console.WriteLine("you have already taken admission");
                        }
                        else
                        {
                            department.NumberOfSeats--;
                            AdmissionDetails admission = new(currentLoggedInStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted);
                            admissions.Add(admission);
                            //  eats are not available, display: "Sorry, the seat count is filled".
                            System.Console.WriteLine("Admission Taken Successfully " + admission.AdmissionID);
                        }
                    }
                    else
                    {
                        //student has already taken admission, show:*/
                        System.Console.WriteLine("you are not eligible for taking admission");
                    }
                }
                else
                {
                    // If seats are available, verify if the student has already taken admission by traversing the Admissions list.
                    System.Console.WriteLine("all seats are already filled");
                }
                flag = false;
                break;
            }
            // student is eligible check if seats are available in the chosen department.
            System.Console.WriteLine(flag ? "Invalid Department ID" : " ");
        }
        public void CancelAdmission()
        {
            Console.WriteLine("Do you want to Cancel");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                bool flag = true;
                foreach (AdmissionDetails admission in admissions)
                {
                    if (admission.StudentID.Equals(currentLoggedInStudent.StudentID) && admission.Status.Equals(AdmissionStatus.Admitted))
                    {
                        //If the admissions list is not emptyIf found, Change the AdmissionStatus is Cancelled.
                        foreach (DepartmentDetails department in departments)
                        {
                            if (department.DepartmentID.Equals(admission.DepartmentID))
                            {
                                //Finally, display: "Admission cancelled successfully"
                                System.Console.WriteLine("Admission cancelled successfully");
                                //Return the seat count to the departments list by adding the departments seat count.
                                department.NumberOfSeats++;
                                break;
                            }
                        }
                        admission.Status = AdmissionStatus.Cancelled;
                        flag = false;
                        break;
                    }
                }
                System.Console.WriteLine(flag ? "No admission history found!" : "");
            }
        }

        public void ShowAdmissionHistory()
        {
            bool flag = true;
            foreach (AdmissionDetails admission in admissions)
            {
                //Traverse the admission details list to display the admission information of the currently logged-in user
                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID))
                {
                    Console.WriteLine($"{admission.AdmissionID}");
                    flag = false;
                }
            }
            if (flag)
            {
                //If the history is empty, display: “Admission detail is not found".
                System.Console.WriteLine("No history found");
            }
        }

    }
}