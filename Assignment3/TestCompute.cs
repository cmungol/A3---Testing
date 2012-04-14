using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using csUnit;

namespace Assignment3
{
    [TestFixture]
    public class TestCompute
    {
        [Test]
        public void TestComputeProperties()
        {
            Compute comp = new Compute() { income = 0UL, dependent = 0UL, tax = 0.0f };

            Assert.Equals(0UL, comp.income);

            Assert.Equals(0UL, comp.dependent);

            Assert.Equals(0.0f, comp.tax);

        }
    }
}
