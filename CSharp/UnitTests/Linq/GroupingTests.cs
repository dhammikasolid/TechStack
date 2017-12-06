using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Linq
{
    public class GroupingTests
    {
        [Fact]
        public void Basic_Test()
        {
            var query = from student in ObjectDataSource.Students
                        group student by student.Age;

            foreach (var group in query)
            {
                var key = group.Key;

                foreach(var student in group)
                {

                }
            }
        }

        class ScoreGroup
        {
            public string Name { get; set; }
            public int Order { get; set; }
        }

        [Fact]
        public void Continuation_Test()
        {
            Func<int, ScoreGroup> name = (avg) => 
            {
                return avg < 80 ? new ScoreGroup { Name = "Fine", Order = 0 } 
                                : avg > 80 && avg < 90 ? new ScoreGroup { Name = "Good", Order = 1 }
                                : new ScoreGroup { Name = "Very Good", Order = 2 };
            };

            var query = from student in ObjectDataSource.Students
                        let examScores = student.ExamScores
                        let avg = examScores.Sum() / examScores.Count
                        let scoreGroup = name(avg)
                        group student by new { Name = scoreGroup.Name, Order = scoreGroup.Order } into scoreGroups
                        orderby scoreGroups.Key.Order descending
                        select new { Name = scoreGroups.Key.Name, Students = scoreGroups };
                        
            foreach (var scoreGroup in query)
            {
                var scoreGroupKey = scoreGroup.Name;

                foreach (var student in scoreGroup.Students)
                {
                    var avg = student.ExamScores.Average();
                }
            }

            var query2 = from student in ObjectDataSource.Students
                         let examScores = student.ExamScores
                         let avg = examScores.Sum() / examScores.Count
                         let scoreGroup = name(avg)
                         select new
                         {
                             Group = scoreGroup.Name,
                             Order = scoreGroup.Order,
                             Avg = avg,
                             Scors = examScores,
                             Name = student.FirstName
                         } into studentScoreGroup
                         group studentScoreGroup by studentScoreGroup.Group into studentScoreGroup2
                         orderby studentScoreGroup2.Key descending
                         select studentScoreGroup2;

            foreach (var groups in query2)
            {
                var key = groups.Key;

                foreach (var student in groups)
                {

                }
            }

        }
    }
}
