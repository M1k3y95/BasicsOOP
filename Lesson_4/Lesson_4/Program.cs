using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new(20);

            Creator.PrintList();

            test.RemoveSomeBuilding(2);

            Console.WriteLine();

            Creator.PrintList();

            test.RemoveSomeBuilding(10);

            Console.WriteLine();

            Creator.PrintList();

            test.RemoveSomeBuilding(17);

            Console.WriteLine();

            Creator.PrintList();
        }
    }
}
