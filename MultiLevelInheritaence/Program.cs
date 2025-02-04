using System;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using SingleInheritance;


namespace MultiLevelInferitance
{
    class Program
    {
        public static void Main(string[]args)
        {
            BirthRegistration br=new BirthRegistration("john","doe","01/01/2022","01/01/2022","male");
            Console.WriteLine(br.DispalyBirthRegistration());
            AdhaarRegistration ar=new AdhaarRegistration(1234,"ravi","chandran","01/01/2022","01/01/2022","male","123 MainStreet");
            
            
        }
    }
}