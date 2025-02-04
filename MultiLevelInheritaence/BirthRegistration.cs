using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInferitance
{
    public class BirthRegistration
    {
        private static int s_birthID=0;
        public int BirthRegistrationID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string RegistrationDate { get; set; }
        public string BirthDate{ get; set; }
        public string Gender { get; set; }
        public BirthRegistration()
        {
            s_birthID++;
            BirthRegistrationID=s_birthID++;
        }
        public void Display()
        {
            return $"Birth Registration ID :";
        }
    }
}