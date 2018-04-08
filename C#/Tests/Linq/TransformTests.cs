using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Linq
{
    public class TransformTests
    {
        List<int> testData = new List<int> { 1, 2, 3, 4 };

        [Fact]
        public void Annonymous_Test()
        {
            var query = from i in testData
                        select new { P1 = i, P2 = i + 2 };

            foreach (var i in query)
            {

            }
        }

        [Fact]
        public void Type_Test()
        {
            var query = from i in testData
                         select new Trasform { P1 = i };

            foreach (var i in query)
            {

            }
        }
    }

    public class Trasform
    {
        public int P1 { get; set; }
        public string P2 { get; set; }
    }
}
