using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExample
{
    internal class InternalModifier
    {
        internal static void InternalMethod()
        {
            Console.WriteLine("Called a internal method");
        }
    }

    internal class TestInternalSubClass : InternalModifier
    {
        public TestInternalSubClass()
        {
            InternalModifier.InternalMethod();
        }
    }

}

