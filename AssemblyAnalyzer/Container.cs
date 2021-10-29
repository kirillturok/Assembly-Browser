using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAnalyzer
{
    public class Container : MemberInfo
    {
        public List<MemberInfo> Members { get; set; }

        public Container(string @namespace, string @class, string signature, List<MemberInfo> members) : base(@namespace, @class)
        {
            Signature = signature;
            Members = members;
        }
        public Container(string @namespace, string @class) : base(@namespace, @class)
        {
            Members = new List<MemberInfo>();
        }


    }
}
