using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_Analyzer
{
    class AssemblyBrowser
    {
        public List<Container> GetInfo(string path)
        {
            var assembly = Assembly.LoadFrom(path);
            var assemblyInfo = new Dictionary<string, Container>();
            

            return assemblyInfo.Values.ToList();
        }
    }
}
