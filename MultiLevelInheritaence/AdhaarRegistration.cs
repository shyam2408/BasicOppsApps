using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInferitance
{
    public class AdhaarRegistration
    {
        private static int s_aadharRegistration=0;
        public int AdhaarRegistrationID { get; set; }
        public string Address { get; set; }
        public AdhaarRegistration() :base
    }
}