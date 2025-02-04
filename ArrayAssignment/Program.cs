using System;

namespace ArrayAssinment;//FILE SCOPED NAMESPACE

class Program
{
    public static void Main(string[]args)
    {
        string[] names =new string[5];
        //GIVING INPUTS
        names[0]="Mani";
        names[1]="Ganesh";
        names[2]="Venkat";
        names[3]="Suresh";
        names[4]="Shyam";
        //USING FOR EACH LOOP
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("Enter a name to search=");
        string searchName=Console.ReadLine();
        bool flag=false;
        for(int i=0;i<names.Length;i++)
        {    //CHECKING SEACH NAME
            if(names[i]==searchName)
            {
                Console.WriteLine($"The name is present in the arary and the index value is {i}");
                flag=true;
                break;
            }
    
        }
        if (!flag)
        {
            Console.WriteLine($"The name is not present in the arary");
        }

        //USING FOREACH LOOP
        flag=false;

        foreach(string name in names)
        {
                //CHECKING SEARCHNAME EQUALS TO ENTERED NAME
            if(name==searchName)
            {
                Console.WriteLine("The name is present in the aray");
                flag=true;
                break;
            }
        }
        if (!flag)
        {
            Console.WriteLine($"The name is not present in the arary");
        } 
    }
}
