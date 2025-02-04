using System;
using System.Reflection.Metadata.Ecma335;
using Static_Elements;

namespace StaticElements;
class Program
{
    public static void Main(string[]args)
    {
        StudentDetails student=new StudentDetails();
        {
            Name="shyam"
        };

        TrainerDetails.Showdata();

    }
}