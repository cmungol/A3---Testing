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
    public class ComputeBoundaryValueTest
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
        public void bv_1()
        {
            comp.income = 1;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_2()
        {
            comp.income = 2;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_3()
        {
            comp.income = 2147483648;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(279172874, comp.tax);
        }

        [TestMethod()]
        public void bv_4()
        {
            comp.income = 4294967294;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(558345748, comp.tax);
        }

        [TestMethod()]
        public void bv_5()
        {
            comp.income = 4294967295;
            comp.dependent = 0;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(558345748, comp.tax);
        }

        [TestMethod()]
        public void bv_6()
        {
            comp.income = 1;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_7()
        {
            comp.income = 2;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_8()
        {
            comp.income = 2147483648;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(251255587, comp.tax);
        }

        [TestMethod()]
        public void bv_9()
        {
            comp.income = 4294967294;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(502511173, comp.tax);
        }

        [TestMethod()]
        public void bv_10()
        {
            comp.income = 4294967295;
            comp.dependent = 1;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(502511174, comp.tax);
        }

        [TestMethod()]
        public void bv_11()
        {
            comp.income = 1;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_12()
        {
            comp.income = 2;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_13()
        {
            comp.income = 2147483648;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(209379656, comp.tax);
        }

        [TestMethod()]
        public void bv_14()
        {
            comp.income = 4294967294;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(418759311, comp.tax);
        }

        [TestMethod()]
        public void bv_15()
        {
            comp.income = 4294967295;
            comp.dependent = 2;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(418759311, comp.tax);
        }

        [TestMethod()]
        public void bv_16()
        {
            comp.income = 1;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_17()
        {
            comp.income = 2;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(0, comp.tax);
        }

        [TestMethod()]
        public void bv_18()
        {
            comp.income = 2147483648;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(167503725, comp.tax);
        }

        [TestMethod()]
        public void bv_19()
        {
            comp.income = 4294967294;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(335007449, comp.tax);
        }

        [TestMethod()]
        public void bv_20()
        {
            comp.income = 4294967295;
            comp.dependent = 4;
            comp.Run();

            System.Diagnostics.Trace.WriteLine("income: " + comp.income + " dependents: " + comp.dependent + " tax: " + comp.tax);
            Assert.AreEqual(335007449, comp.tax);
        }
    }
}
