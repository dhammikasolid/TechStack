using CSharp;
using System;
using Xunit;

namespace UnitTests
{
    public class OperatorsTests
    {
        Operators _operators;

        public OperatorsTests()
        {
            _operators = new Operators();
        }

        [Fact]
        public void Is_Test()
        {
            var a = new A();
            var b = new B();

            Assert.True(a is A);
            Assert.True(b is A);
            Assert.True(b is B);
        }

        [Fact]
        public void As_Test()
        {
            var b = new B();

            Assert.NotNull(b as A);
        }

        public class A { }
        public class B : A { }
    }
}
