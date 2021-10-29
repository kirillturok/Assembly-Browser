using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAnalyzer
{
    public class NamespaceInfo
    {
        public string Signature;
        public List<Container> MemberInfo;

        public NamespaceInfo(string signature)
        {
            MemberInfo = new List<Container>();
            Signature = signature;
        }

        public NamespaceInfo(List<Container> memberInfo, string signature)
        {
            Signature = signature;
            MemberInfo = memberInfo;
        }
    }
}
