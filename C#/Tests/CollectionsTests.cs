using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class CollectionsTests
    {
        [Fact]
        public void List()
        {
            var list = new List<int> { 4, 2, 5 };
            list.Add(7);

            // Index
            Assert.Equal(7, list[list.Count - 1]);

            // Without Linq
            Assert.Equal(2, list.Find(i => i == 2));
        }

        [Fact]
        public void List_Remove_Test()
        {
            // Use IEquatable<T> for complex find, remove, contain tests
            var list = new List<int> { 4, 2, 5 };

            if (list.Contains(1))
                list.Remove(1);
            Assert.Equal(3, list.Count);

            // Use Linq to find and Remove item
            var item = list.FirstOrDefault(i => i == 2);
            list.Remove(item);

            Assert.DoesNotContain(2, list);
        }

        [Fact]
        public void List_Sort_Test()
        {
            // Use IComparable for complex ordering
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

            // Use Linq for basic acs, desc ordering
            var list3 = new List<int> { 4, 2, 5 };
            list3 = list3.OrderByDescending(i => i).ToList();

            Assert.Equal(5, list3[0]);
            Assert.Equal(2, list3[2]);
        }

        [Fact]
        public void SortedList_Test()
        {
            var sortedList = new SortedList<string, int>
            {
                { "c", 10 },
                { "a", 8 },
                { "b", 15 }
            };

            Assert.Equal("a", sortedList.ToList()[0].Key);
            Assert.Equal("c", sortedList.ToList()[2].Key);
        }

        [Fact]
        public void Dictionary_Test()
        {
            var dic = new Dictionary<int, string>
            {
                { 5, "Item 3" },
                { 2, "Item 2" },
                { 7, "Item 5" },
            };

            Assert.Equal("Item 2", dic[2]);
        }
    }
}
