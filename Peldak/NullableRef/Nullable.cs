using System;

namespace NullableRef
{
    internal class Pelda
    {
        public string? Property { get; set; }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            Pelda p = new Pelda();
            Console.WriteLine();

            int x = p.Property?.Length ?? 0;

            Console.ReadKey();
        }
    }
}
