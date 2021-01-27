using System;

namespace Record
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            PointClass a = new PointClass(2, 5);
            PointClass b = new PointClass(2, 5);

            Console.WriteLine("a.Equals(b): {0}", a.Equals(b));
            Console.WriteLine("b.Equals(a): {0}", b.Equals(a));

            var copy = (PointClass)a.Clone();
            Console.WriteLine($"{copy.X}, {copy.Y}");

            PointRecord aR = new PointRecord
            {
                X = 1,
                Y = 9,
            };

            PointRecord bR = new PointRecord
            {
                X = 1,
                Y = 9,
            };

            Console.WriteLine("aR.Equals(bR): {0}", aR.Equals(bR));
            Console.WriteLine("bR.Equals(aR): {0}", bR.Equals(aR));


            var copyRecord = aR with { X = 5 };
            Console.WriteLine($"{copyRecord.X}, {copyRecord.Y}");

            Console.ReadKey();
        }
    }
}
