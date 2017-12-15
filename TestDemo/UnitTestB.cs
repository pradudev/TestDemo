using NUnit.Framework;
using System;
using System.Threading;

namespace TestDemo
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTestB
    {
        [Test]
        public void BTestMethod1()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void BTestMethod2()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void BTestMethod3()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void BTestMethod4()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }
    }
}