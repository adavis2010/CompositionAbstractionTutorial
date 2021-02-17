using System;

namespace CompositionAbstractionTutorial {
    class Program {
        static void Main(string[] args) {

            var rect1 = new Rect(3, 8);
            Console.WriteLine($"Perimeter is {rect1.Perimeter()}");
            Console.WriteLine($"Area is {rect1.Area()}");

            var sqr1 = new Sqr(4);
            Console.WriteLine($"Perimeter is {sqr1.Perimeter()}");
            Console.WriteLine($"Area is {sqr1.Area()}");
        }



    }
}
