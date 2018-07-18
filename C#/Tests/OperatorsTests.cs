using Xunit;

namespace UnitTests
{
    public class A
    {
        public int? P { get; set; }
    }

    public class OperatorsTests
    {
        [Fact]
        public void ValueIfNull_NullCoalescing_Test()
        {
            int? x = null;
            Assert.Equal(2, x ?? 2);

            x = 5;
            Assert.Equal(5, x ?? 2);
        }

        [Fact]
        public void SafeNavigation_Test()
        {
            A a = null;
            Assert.Null(a?.P);

            A[] arr = null;
            Assert.Null(arr?[0].P);
        }

        [Fact]
        public void StandardNullHandling_Test()
        {
            A a = null;
            int b = a?.P ?? -1;
            Assert.Equal(-1, b);

            var a2 = new A { P = 2 };
            b = a2?.P ?? -1;
            Assert.Equal(2, b);
        }

        [Fact]
        public void IncrementDecrement_Test()
        {
            double a = 1.5;

            Assert.Equal(1.5, a++);
            Assert.Equal(2.5, a);
            Assert.Equal(3.5, ++a);
        }
    }
}
