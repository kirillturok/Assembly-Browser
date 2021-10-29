using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAnalyzer
{
    public class MemberInfo
    {
        public string Signature;
        public string Class;

        public MemberInfo(string signature, string _class)
        {
            Signature = signature;
            Class = _class;
        } 
    }
}
