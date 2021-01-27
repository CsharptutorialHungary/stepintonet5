using System;

namespace PatternMatch
{   
    public static class Program
    {
        public static double TeruletSzamit(object shape)
        {
            switch (shape)
            {
                case Negyzet n when n.Oldal >= 0:
                    return n.Oldal * n.Oldal;
                case Kor k when k.Sugar >= 0:
                    return k.Sugar * k.Sugar * Math.PI;
                case Teglalap t when t.Hossz >= 0 && t.Magassag >= 0:
                    return t.Magassag * t.Hossz;
                default:
                    throw new ArgumentException("A terület nem számítható");
            }
        }

        private static bool IsBetu(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        static void Main(string[] args)
        {
            object[] elemek = new object[]
            {
                new Negyzet(2),
                new Kor(3),
                new Teglalap(5, 2)
            };

            foreach (var elem in elemek)
            {
                Console.WriteLine(TeruletSzamit(elem));
            }

            Console.WriteLine("IsBetu('z'): {0}", IsBetu('z'));

            Console.ReadKey();
        }
    }
}
