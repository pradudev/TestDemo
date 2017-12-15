using NUnit.Framework;
using System;
using System.Threading;

namespace TestDemo
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTestA
    {
        [Test]
        public void ATestMethod1()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void ATestMethod2()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void ATestMethod3()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }

        [Test]
        public void ATestMethod4()
        {
            Thread.Sleep(new Random().Next(1, 5) * 1000);
            Assert.That(1 == 1);
        }
    }
}
