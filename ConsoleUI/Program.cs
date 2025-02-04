using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName;
            int i;
            double hoursWorked, totalHours;
            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();
            Console.Write("Enter your company name: ");
            companyName = Console.ReadLine();
            Console.Write("Enter hours worked: ");
            hoursWorked = double.Parse(Console.ReadLine());
            TimeSheetEntry entry = new ();
            entry.HoursWorked = hoursWorked;
            entry.WorkDone = companyName;
            entries.Add(entry);
            Console.Write("Do you want to enter more time:");
            string option = Console.ReadLine();
            while (option == "yes")
            {
                Console.Write("Enter your company name: ");
                companyName = Console.ReadLine();
                Console.Write("Enter hours worked: ");
                hoursWorked = double.Parse(Console.ReadLine());
                entry = new ();
                entry.HoursWorked = hoursWorked;
                entry.WorkDone = companyName;
                entries.Add(entry);
                Console.Write("Do you want to enter more time:");
                option = Console.ReadLine().ToLower();
            }
            totalHours = 0;
            for (i = 0; i < entries.Count; i++)
            {
                if (entries[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalHours += entries[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalHours * 150 + " for the hours worked.");
            totalHours=0;
            for (i = 0; i < entries.Count; i++)
            {
                if (entries[i].WorkDone.ToLower().Contains("abc"))
                {
                    totalHours += i;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalHours * 125 + " for the hours worked.");
            totalHours=0;
            for (i = 0; i < entries.Count; i++)
            {
                totalHours += entries[i].HoursWorked;
            }
            if (totalHours > 40)
            {
                Console.WriteLine("You will get paid $" + (totalHours * 15)+400+ "for your time");
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalHours * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
