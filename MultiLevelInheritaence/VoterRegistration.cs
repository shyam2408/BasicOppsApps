using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MultiLevelInheritaence
{
    public class VoterRegistration
    {
        private static int s_voterID=0;
        public int VoterID { get; set; }
        public string AssemblyConstutuency { get; set; }
        public VoterRegistration(){}
        public string(string assemblyConstutuency)
        {
            s_voterID++;
            VoterID=s_voterID;
            AssemblyConstutuency=AssemblyConfigurationAttributej
        }

    }
}