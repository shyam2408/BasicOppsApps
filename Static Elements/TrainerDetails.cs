using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Static_Elements
{

        public static class TrainerDetails
        {
            //static field
            private static int s_trainerID;
            private static string Name;
            //static property
            public static string TrainerID { get; set; }
            //static events
            //static default constructor
            static TrainerDetails()
            {
                TrainerID=$"SF {++s_trainerID}";
                Name="Ravi";
            }
            //static methods
            public static string Showdata()
            {
                return TrainerID ;
            }
        
        }
    }
