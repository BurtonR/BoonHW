using System;
using System.Linq;

namespace BoonHomework
{
    public class TwelveDays
    {
        public void Sing()
        {
            var days = new string[12] { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eigth", "ninth", "tenth", "elenth", "twelveth" };
            var gifts = new string[12]
            {
                "a partridge in a pear tree",
                "two turtle doves",
                "three french hens",
                "four callings birds",
                "five golden rings",
                "six geese a-layin'",
                "seven swans a-swimmin'",
                "eight maids a-milkin'",
                "nine ladies dancin'",
                "ten lords a-leapin'",
                "eleven pipers piping",
                "twelve drummers drumming"
            };

            Song(days, gifts);
        }

        public static void Song(string[] days, string[] gifts)
        {
            for (var d = 0; d < days.Count(); d++)
            {
                Console.WriteLine($"On the {days[d]} day of Christmas, ");
                Console.WriteLine("My true love gave to me: ");

                var x = 0;

                foreach (var gift in gifts.Take(d + 1).Reverse())
                {
                    if (x >= 1 && gift.Contains("partridge")) Console.Write("and ");
                    Console.WriteLine(gift);
                    x++;
                }
            }
            Console.Read();
        }
    }
}
