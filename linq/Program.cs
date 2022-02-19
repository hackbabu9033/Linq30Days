using System;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var interger in ints)
            //{
            //    Console.WriteLine(interger);
            //}
            var starSignContents = new StarSignsContent(StarSign.Aquarius,12);
            foreach (var starSign in starSignContents)
            {
                Console.WriteLine(starSign);
            }
        }
    }
}
