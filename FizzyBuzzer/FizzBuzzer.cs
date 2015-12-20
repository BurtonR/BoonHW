using System;
using System.Text;

namespace FizzyBuzzer
{
    public class FizzBuzzer
    {
        public string Buzz(int beingNumber, int endNumber)
        {
            var output = new StringBuilder();

            for (var x = beingNumber; x <= endNumber; x++)
            {
                if (x % 3 == 0 || x % 5 == 0)
                {
                    if (x % 3 == 0) output.Append("Fizz");
                    if (x % 5 == 0) output.Append("Buzz");
                }
                else
                {
                    output.Append(x);
                }
                output.Append(Environment.NewLine);
            }

            return output.ToString();
        }

        public string Buzz(FBConfig config)
        {
            var output = new StringBuilder();

            if (config.InputValue%config.ValidationValue == 0)
                {
                    output.Append("Valid Value!");
                }
                output.Append(Environment.NewLine);

            return output.ToString();
        }

        public string Buzz(FBConfig[] configs)
        {
            var output = new StringBuilder();

            foreach (var config in configs)
            {
                if (config.InputValue % config.ValidationValue == 0)
                {
                    output.Append("Valid Value!");
                }
                output.Append(Environment.NewLine);
            }

            return output.ToString();
        }
    }

    public class FBConfig
    {
        public int InputValue { get; set; }
        public int ValidationValue { get; set; }
    }
}
