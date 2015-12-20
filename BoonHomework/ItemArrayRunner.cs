using System;
using ItemArrayRecurser;

namespace BoonHomework
{
    public class ItemArrayRunner
    {
        public void Run()
        {
            var array = new[] { "First", "Second", "Third" };

            var recurser = new ItemArray();

            Console.WriteLine(recurser.Recurse_Round1(array));

            Console.Read();
        }
        public void Run2()
        {
            var array = new object[] { 3, 6, 9 };

            var recurser = new ItemArray();

            Console.WriteLine(recurser.Recurse_Round2(array));

            Console.Read();
        }
        public void Run3()
        {
            var array = new object[] { 3, 6, 9 };

            var recurser = new ItemArray();

            Console.WriteLine(recurser.Recurse_Round3(array));

            Console.Read();
        }
    }
}
