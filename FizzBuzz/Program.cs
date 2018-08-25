using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //new FizzBuzz().GetFizzOrBuzz(0, 100);
            List<(int, string)> combo2 = new List<(int, string)>
            {
                (3, "Fizz"),
                (5, "Buzz")
            };

            DoFizzBuzz(1, 100, combo2);
            Console.ReadLine();
        }

        public static void DoFizzBuzz(int start, int end, List<(int Mod, string Text)> combinations)
        {
            if (end < start)
            {
                throw new InvalidOperationException();
            }

            bool isMatch(int i, int comb) => i % comb == 0;
            for (int i = start; i <= end; i++)
            {
                var matchingCombs = combinations.Where(c => isMatch(i, c.Mod)).Select(c => c.Text).DefaultIfEmpty(i.ToString());
                Console.WriteLine(string.Join("", matchingCombs));
            }
        }

    }
    //public sealed class FizzBuzz
    //{
    //    public void GetFizzOrBuzz(int start, int end, int mod1 = 3, int mod2 = 5, string replacement1 = "Fizz", string replacement2 = "Buzz")
    //    {
    //        if (end < start || mod1 == mod2)
    //        {
    //            throw new InvalidOperationException();
    //        }
    //        for (int i = start; i <= end; i++)
    //        {
    //            Console.WriteLine(i.FizzOrBuzz(mod1, mod2, replacement1, replacement2));
    //        }
    //    }
    //}

    //public static class Extensions
    //{

    //    public static string FizzOrBuzz(this int step, int mod1, int mod2, string replacement1, string replacement2)
    //    {
    //        string phrase = "";
    //        var result = (x: step % mod1 == 0, y: step % mod2 == 0);
    //        if (result.x)
    //        {
    //            phrase += replacement1;
    //        }
    //        if (result.y)
    //        {
    //            phrase += replacement2;
    //        }
    //        if (phrase.Length == 0)
    //        {
    //            phrase = step.ToString();
    //        }
    //        return phrase;
    //    }

    //}
}
