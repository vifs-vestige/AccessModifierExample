using AccessModifierExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExample
{
    public class PublicModifier
    {

        public static void PublicMethod()
        {
            Console.WriteLine("Called a public method");
        }
    }

    public class TestPublicSubClass : PublicModifier
    {
        public TestPublicSubClass()
        {
            PublicModifier.PublicMethod();
        }
    }

    public class TestPublicInsideNamespace
    {
        public TestPublicInsideNamespace()
        {
            PublicModifier.PublicMethod();
        }
    }
}

public class TestPublicOutsideNamespace
{
    public TestPublicOutsideNamespace()
    {
        PublicModifier.PublicMethod();
    }
}

