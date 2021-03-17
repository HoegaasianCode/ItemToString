using System;

namespace ItemsToString
{
    // https://edabit.com/challenge/hqTYj7NbLnCcjxryi
    // SOLVED

    class Program
    {
        static void Main(string[] args)
        {
            var items = new StringConverter(new object[] { 1, 2, "a", "b" });
            var stringItems = items.ConvertToString();
            foreach(var stringItem in stringItems)
            {
                Console.WriteLine(stringItem);
            }
        }
    }
}
