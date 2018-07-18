using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class CollectionsTests
    {
        [Fact]
        public void List_Test()
        {
            Assert.Equal(-1, 10.CompareTo(12));
            Assert.Equal(0, 10.CompareTo(10));
            Assert.Equal(1, 10.CompareTo(8));

            var list = new List<int> { 4, 2, 5 };
            list.Sort();

            Assert.Equal(2, list[0]);
            Assert.Equal(5, list[2]);

            var list2 = new List<int> { 4, 2, 5 };
            list2.Sort((a, b) => b.CompareTo(a));

            Assert.Equal(5, list2[0]);
            Assert.Equal(2, list2[2]);

            var list3 = new List<int> { 4, 2, 5 };
            list3 = list3.OrderByDescending(i => i).ToList();

            Assert.Equal(5, list3[0]);
            Assert.Equal(2, list3[2]);
        }

        [Fact]
        public void SortedList_Test()
        {
            var sortedList = new SortedList<string, int>();
            sortedList.Add("c", 10);
            sortedList.Add("a", 8);
            sortedList.Add("b", 15);

            Assert.Equal("a", sortedList.ToList()[0].Key);
            Assert.Equal("c", sortedList.ToList()[2].Key);
        }
    }
}
