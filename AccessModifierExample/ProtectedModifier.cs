using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExample
{
    class ProtectedModifier
    {
        protected static void ProtectedMethod()
        {
            Console.WriteLine("Called a protected method");
        }

    }

    class TestProtectedSubClass : ProtectedModifier
    {
        public TestProtectedSubClass()
        {
            ProtectedModifier.ProtectedMethod();
        }
    }

    class TestProtected
    {
        public TestProtected()
        {
            ProtectedModifier.ProtectedMethod();
        }
    }
}
