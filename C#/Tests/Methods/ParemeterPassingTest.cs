using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Methods
{
    public class ParemeterPassingTest
    {
        [Fact]
        public void PassReferenceTypeObject()
        {
            var caller = new Caller();

            var refTypeObj = new RefereceType { P = 1 };
            Assert.Equal(1, refTypeObj.P);

            caller.ChangeRefereceObjectPValueTo2(refTypeObj);
            Assert.Equal(2, refTypeObj.P);

            caller.ChangeRefereceParameterToNewObjectInternally(refTypeObj);
            Assert.Equal(2, refTypeObj.P);

            caller.ChangeRefereceParameterToNewObjectExternally(ref refTypeObj);
            Assert.Equal(5, refTypeObj.P);
        }
    }

    internal class Caller
    {
        public void ChangeRefereceObjectPValueTo2(RefereceType obj)
        {
            obj.P = 2;
        }

        public void ChangeRefereceParameterToNewObjectInternally(RefereceType obj)
        {
            obj = new RefereceType { P = 5 };
        }

        public void ChangeRefereceParameterToNewObjectExternally(ref RefereceType obj)
        {
            obj = new RefereceType { P = 5 };
        }
    }

    internal class RefereceType
    {
        public int P { get; set; }
    }
}
