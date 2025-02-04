using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Inside
{
    public class Son : Parent //default Internal
    {
        //default is private
        public int PublicNumber=10;
        private int PrivateNumber=20;
        public int PrivateOutNumber
        {
            get{return PrivateOutNumber;}
        }
        public int PrivateParentNumber
        {
            get{return PrivateParentNumber;}
        }
        public int ProtectedParentNumber
        {
            get{return ProtectedParentNumber;}
        }
    
    }
}