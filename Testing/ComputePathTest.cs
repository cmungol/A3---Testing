using Assignment3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    /// <summary>
    ///This is a test class for ComputeTest and is intended
    ///to contain all ComputeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComputePathTest
    {

        Compute comp;

        [TestInitialize]
        public void Init()
        {
            comp = new Compute() { income = 0UL, dependent = 0UL, tax = (decimal)0.0 };
        }

        [TestCleanup]
        public void CleanUp()
        {
            comp = null;
        }

        [TestMethod()]
        public void pathTest_1()
        {
            comp.income = 15000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(600, comp.tax);
        }

        [TestMethod()]
        public void pathTest_2()
        {
            comp.income = 15000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(540, comp.tax);
        }

        [TestMethod()]
        public void pathTest_3()
        {
            comp.income = 15000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(450, comp.tax);
        }

        [TestMethod()]
        public void pathTest_4()
        {
            comp.income = 15000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(360, comp.tax);
        }

        [TestMethod()]
        public void pathTest_5()
        {
            comp.income = 25000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1250, comp.tax);
        }

        [TestMethod()]
        public void pathTest_6()
        {
            comp.income = 25000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1125, comp.tax);
        }

        [TestMethod()]
        public void pathTest_7()
        {
            comp.income = 25000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(938, comp.tax);
        }

        [TestMethod()]
        public void pathTest_8()
        {
            comp.income = 25000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(750, comp.tax);
        }

        [TestMethod()]
        public void pathTest_9()
        {
            comp.income = 35000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(2100, comp.tax);
        }

        [TestMethod()]
        public void pathTest_10()
        {
            comp.income = 35000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1890, comp.tax);
        }

        [TestMethod()]
        public void pathTest_11()
        {
            comp.income = 35000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1575, comp.tax);
        }

        [TestMethod()]
        public void pathTest_12()
        {
            comp.income = 35000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1260, comp.tax);
        }

        [TestMethod()]
        public void pathTest_13()
        {
            comp.income = 45000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(3150, comp.tax);
        }

        [TestMethod()]
        public void pathTest_14()
        {
            comp.income = 45000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(2835, comp.tax);
        }

        [TestMethod()]
        public void pathTest_15()
        {
            comp.income = 45000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(2363, comp.tax);
        }

        [TestMethod()]
        public void pathTest_16()
        {
            comp.income = 45000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(1890, comp.tax);
        }

        [TestMethod()]
        public void pathTest_17()
        {
            comp.income = 55000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(5500, comp.tax);
        }

        [TestMethod()]
        public void pathTest_18()
        {
            comp.income = 55000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(4950, comp.tax);
        }

        [TestMethod()]
        public void pathTest_19()
        {
            comp.income = 55000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(4125, comp.tax);
        }

        [TestMethod()]
        public void pathTest_20()
        {
            comp.income = 55000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(3300, comp.tax);
        }

        [TestMethod()]
        public void pathTest_21()
        {
            comp.income = 95000;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(12350, comp.tax);
        }

        [TestMethod()]
        public void pathTest_22()
        {
            comp.income = 95000;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(11115, comp.tax);
        }

        [TestMethod()]
        public void pathTest_23()
        {
            comp.income = 95000;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(9263, comp.tax);
        }

        [TestMethod()]
        public void pathTest_24()
        {
            comp.income = 95000;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(7410, comp.tax);
        }
    }
}
