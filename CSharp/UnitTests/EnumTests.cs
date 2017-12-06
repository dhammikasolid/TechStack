using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    [Flags]
    public enum Terms
    {
        O = 0x0,
        A = 0x1,
        B = 0x2,
        C = 0x4,
        D = 0x8,
        E = 0x10,
        F = 0x20,
        G = 0x40,
        H = 0x80,
        I = 0x100,
        J = 0x200,
        K = 0x400
    }

    public class EnumTests
    {
        [Fact]
        public void Combinations_Test()
        {
            var c = Terms.A | Terms.B | Terms.C;

            var isA = (c & Terms.A) == Terms.A;
            var isD = (c & Terms.D) == Terms.D;

            c = c ^ Terms.A;
            c = c | Terms.D;

            isA = (c & Terms.A) == Terms.A;
            isD = (c & Terms.D) == Terms.D;

            c = c | Terms.G;
            var isG = (c & Terms.G) == Terms.G;
            var isE = (c & Terms.E) == Terms.E;

            c = c | Terms.J;
            var isJ = (c & Terms.J) == Terms.J;
            var isI = (c & Terms.I) == Terms.I;

            var cs = c.ToString();

            c = (Terms)Enum.Parse(typeof(Terms), "A, B, K");

            isA = (c & Terms.A) == Terms.A;
        }
    }
}
