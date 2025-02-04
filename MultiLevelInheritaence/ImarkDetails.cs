using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MultiLevelInheritaence
{
    public interface ImarkDetails
    {
         int physics { get; set; }
         int Chemistry { get; set; }
         int Maths { get; set; }

         public void GetMarks(int physics,int chemistry,int maths)

         public void GetMarks()
         {
        
         }
         public string showDetails()
         {
            return$"Student Id{StudentId}"
         }
    }
}