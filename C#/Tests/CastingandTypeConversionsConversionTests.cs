using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.TypeConversion
{
    public class A
    {
        public int PA { get; set; }
    }

    public class B : A
    {
        public int PB { get; set; }
    }

    public class C : A
    {
        public int PC { get; set; }
    }

    public class CastingAndTypeConversionsConversionTests
    {
        [Fact]
        public void Casting_RunTime_CompileTime_Types_Test()
        {
            A a = new B { PA = 2, PB = 3 };
            B b = (B)a;

            Assert.Equal(3, b.PB);
        }

        [Fact]
        public void DataLoss_TypeConversion_Test()
        {
            double a = 222.99;
            int b = (int)a;

            Assert.Equal(222, b);
        }

        [Fact]
        public void SafeTypeCasting_AsIs_Test()
        {
            object a = new A();
            object b = new B();
            object c = new C();

            Assert.True(b is A);
            Assert.False(a is B);
            Assert.False(c is B);

            Assert.NotNull(b as A);
            Assert.Null(a as B);
            Assert.Null(c as B);
        }

        // Convert
        // C# base data types: Boolean, Char, SByte, Byte, Int16, Int32, Int64, UInt16, UInt32, UInt64, Single, Double, Decimal, DateTime and String
        [Fact]
        public void Convert_ToBoolean_Test()
        {
            var trueString = Boolean.TrueString;
            Assert.True(Convert.ToBoolean(trueString));
            Assert.True(Convert.ToBoolean("true"));
            Assert.True(Convert.ToBoolean("True"));
            Assert.False(Convert.ToBoolean("false"));
            Assert.False(Convert.ToBoolean("False"));

            Assert.True(Convert.ToBoolean(1));
            Assert.False(Convert.ToBoolean(0));
        }

        [Fact]
        public void Convert_To_Numeric_Test()
        {
            Assert.Equal(11, Convert.ToInt32("11"));
            Assert.Equal(11.99m, Convert.ToDecimal("11.99"));
            Assert.Equal(11.99m, Convert.ToDecimal("11.99"));
            Assert.Equal(123456.78m, decimal.Parse("$123,456.78",NumberStyles.Currency));
        }

        [Fact]
        public void Convert_ToFrom_ByteArrays()
        {
            var intBytes = BitConverter.GetBytes(128);
            Assert.Equal(128, intBytes[0]);

            var strBytes = Encoding.UTF8.GetBytes("ABC");
            Assert.Equal(65, strBytes[0]);
        }
    }
}
