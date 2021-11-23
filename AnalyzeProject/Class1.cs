using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzzzzzzzzzzzz
{
    namespace N1 { namespace N2 { namespace N3 { class Cls { class Cls2{ private int hhh() { return 5; } } } } } }
    class Class1
    {
        public int n { get; set; }
        public string str;
        protected bool getB(string hjgj)
        {
            return hjgj.Length == 1;
        }
        private void hhh() { }
        public void mth()
        {
            string s = "qwertqq";
            char c = 'q';
            int i = s.CharCount(c);
        }
    }

    public static class Class2
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}
