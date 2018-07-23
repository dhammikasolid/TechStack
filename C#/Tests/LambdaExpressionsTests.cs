using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class LambdaExpressionsTests
    {
        [Fact]
        public void Test()
        {
            Func<int, bool> del = x => x == 2; // Use for create delegate
            Assert.True(del(2));

            IEnumerable<int> enumerable = new List<int> { };
            enumerable.Where(del); // Extention from System.Linq.Enumerable

            IQueryable<int> queryable = enumerable.AsQueryable();
            Expression<Func<int, bool>> expression = x => x == 2; // Use for create Expression
            queryable.Where(expression); // Extention from System.Linq.Queryable
        }

        int M(int x) { return x; }

        [Fact]
        public void ExpressionLambdas_Test()
        {
            Func<int, bool> del1 = x => x == 2; // Single input
            Func<int, int, bool> del2 = (x, y) => x == y; // Single input
            Func<bool> del3 = () => 2 == 2; // No input 
            Func<int> del4 = () => M(2); // Calling methods has no meaning outside CLR (SQL-Server)
        }

        [Fact]
        public void StatementLambdas_Test()
        {
            Func<int, bool> del = x => {
                int y = x % 5;
                return y == 0;
            };

            //Like anonymous methods, cannot be used to create expression trees
        }
    }
}
