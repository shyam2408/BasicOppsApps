using System;
using System.ComponentModel;

namespace LibraryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operations operations = new Operations();
            operations.DefaultValue();
            operations.MainMenu();

        }
    }
}