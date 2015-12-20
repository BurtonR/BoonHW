using System;

namespace BoonHomework
{
    public class FizzyBuzzerRunner
    {
        public void Run()
        {
            var fizz = new FizzyBuzzer.FizzBuzzer();

            Console.WriteLine(fizz.Buzz(0, 100));

            Console.Read();
        }
    }
}
