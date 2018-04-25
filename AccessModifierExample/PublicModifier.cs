using AccessModifierExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExample
{
    class PublicModifier
    {

        public static void PublicMethod()
        {
            Console.WriteLine("Called a public method");
        }
    }

    class TestPublicSubClass : PublicModifier
    {
        public TestPublicSubClass()
        {
            PublicModifier.PublicMethod();
        }
    }

    class TestPublic
    {
        public TestPublic()
        {
            PublicModifier.PublicMethod();
        }
    }
}


