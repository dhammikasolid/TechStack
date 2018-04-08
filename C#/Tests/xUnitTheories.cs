using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{

    public class xUnitTheories
    {
        [Theory]
        [InlineData(3)]
        public void TestInline(int data)
        {
            Assert.Equal(3, data);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestClassData(TestData data1, TestData data2)
        {
            Assert.True(data1.Porp1 > 1);
            Assert.Equal("A", data1.Porp2);

            Assert.True(data2.Porp1 > 3);
            Assert.Equal("A", data2.Porp2);
        }

    }

    public class TestDataGenerator : IEnumerable<object[]>
    {
        List<object[]> _testData = new List<object[]>
        {
            new [] 
            {
                new TestData { Porp1 = 2, Porp2 = "A" },
                new TestData { Porp1 = 5, Porp2 = "A" },
            }
        };

        public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _testData.GetEnumerator();
    }

    public class TestData 
    {
        public int Porp1 { get; set; }
        public string Porp2 { get; set; }
    }
}
