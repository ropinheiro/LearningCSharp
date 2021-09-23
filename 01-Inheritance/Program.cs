using System;

namespace Inheritance
{
    // ClassA inherits from ClassB
    public class ClassA : ClassB
    {
        public int a1;
        public int a2;
    }

    public class ClassB
    {
        public int b1;
        public int b2;
    }

    class Program
    {
        static void Main( string[] args )
        {
            ClassA a = new ClassA();
            a.b1 = 1;
            a.b2 = 2;

            // Prove that we can assign a ClassA thing to a ClassB, and see its values.
            ClassB b = a;
            Console.WriteLine( "b.b1 = " + b.b1 );
            Console.WriteLine( "b.b2 = " + b.b2 );
        }
    }
}
