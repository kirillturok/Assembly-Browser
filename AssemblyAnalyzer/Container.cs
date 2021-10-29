using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAnalyzer
{
    public class Container : MemberInfo
    {
        public List<MemberInfo> Members;
        public Container(string nmspace, string _class, string signature, List<MemberInfo> members) : base(nmspace, _class)
        {
            Members = members;
        }
        public Container(string nmspace, string _class) : base(nmspace, _class)
        {
            Members = new List<MemberInfo>();
        }

    }
}
