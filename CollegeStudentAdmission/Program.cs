using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using StudentAdmissionforCollege;

namespace CollegeAdmission;

class Program
{
    public static void Main(string[] args)
    {
        Operations op=new Operations();
        op.DefaultData();
        op.MainMenu();
    }
}