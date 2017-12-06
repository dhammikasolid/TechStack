using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Linq
{
    public class TechniquesTests
    {
        [Fact]
        public void Subqueries_Test()
        {
            var query = from student in ObjectDataSource.Students
                        let scores = (from score in student.ExamScores
                                      where score > 80
                                      select score)
                        from score in scores
                        let scoreStr = string.Format("Score: {0}", score)
                        select new { Name = student.FirstName, Score = scoreStr };

            foreach (var score in query)
            {

            }
        }
    }
}
