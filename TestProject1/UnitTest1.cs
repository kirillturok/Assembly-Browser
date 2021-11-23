using NUnit.Framework;
using AssemblyAnalyzer;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        AssemblyBrowser assemblyBrowser = new AssemblyBrowser();
        private string path = "D:\\5 семестр\\СПП\\3\\Assembly-Browser\\ProjectForUnitTest\\bin\\Debug\\net5.0\\ProjectForUnitTest.dll";
        List<Container> assemblyInfo;

        [SetUp]
        public void SetUp()
        {
            assemblyInfo = assemblyBrowser.GetAssemblyInfo(path);
        }

        [Test]
        public void Test1()
        {   
            Assert.AreEqual(assemblyInfo==null,false,"Couldn't load assembly info.");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(assemblyInfo[0].Class, "private   class  Program", "Wrong name for first class.");
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(assemblyInfo[0].Signature, "ProjectForUnitTest", "Wrong first namespace.");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(assemblyInfo.Count,2,"Wrong number of namespaces.");
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(assemblyInfo[0].Members.Count,1,"Wrong number of members in first namespace.");
        }
    }
}