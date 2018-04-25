using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExample
{
    class PrivateModifier
    {

        private static void PrivateMethod()
        {
            Console.WriteLine("Called a private method");
        }
    }

    class TestPrivateSubClass : PrivateModifier
    {
        public TestPrivateSubClass()
        {
            PrivateModifier.PrivateMethod();
        }
    }

    class TestPrivate
    {
        public TestPrivate()
        {
            PrivateModifier.PrivateMethod();
        }
    }
}
