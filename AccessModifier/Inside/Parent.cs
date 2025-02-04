using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class Parent :GrandParents
    {
        private int PrivateParentNumber=30;
        protected int ProtectedParentNumber=40;
        internal int internalParentNumber=50;
        public int GrandParentInternalOut
        {
            get{return internalGra}
        }
        public int ProtectedInternalOut
        {
            get{return protectedInternalNumber;}
        }
}