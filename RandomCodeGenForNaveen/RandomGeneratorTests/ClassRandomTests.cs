using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Tests
{
    [TestClass()]
    public class ClassRandomTests
    {
        RandomGenerator.ClassRandom tstCls = new ClassRandom();

        

        [TestMethod()]
        public void doesItExistTest()
        {
            int[] test = new int[] { 1199, 1198, 1192, 1197, 1195, 1919, 5655, 1919 };

            Assert.AreEqual(true, tstCls.doesItExist(test, 1192));
        }

    }
}