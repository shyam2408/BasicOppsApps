dusing System;
using System.Net.Mail;

namespace DateTimeAssignment;//FILE SCOPED NAMESPACE

class Program
{
    static void Main(string[]args)
    {//inserting datetime
        DateTime currentDate= new DateTime(2021,8,10,10,40,32);
        //printing year
        Console.WriteLine(currentDate.Year);
        //printing month
        Console.WriteLine(currentDate.Month);
        //printing day
        Console.WriteLine(currentDate.Day);
        //printing minutes
        Console.WriteLine(currentDate.Minute);
        //printing seconds
        Console.WriteLine(currentDate.Second);
        Console.WriteLine("Enter a date:dd/MM/yyyy");
        //gettting inputs from user
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        //converting date format to string
        string nowDate=date.ToString("yyyy/MM/dd hh:mm:ss:tt");
        //splittng string into array
        string[] words=nowDate.Split('/',':',' ');
        //iterate in reverse order
        for(int i=words.Length-1; i>0; i--)
        {
            Console.WriteLine(words[i]);
        }
        //getting inputs from the users
        Console.WriteLine("Enter your date of birth=");
        //getting inputs in yyyy/MM/dd hh:mm:ss tt format
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(dob.ToString("yyyy/MM/dd"));
    }
}
