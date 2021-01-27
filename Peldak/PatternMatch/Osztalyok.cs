namespace PatternMatch
{
    public class Negyzet
    {
        public double Oldal { get; }

        public Negyzet(double oldal)
        {
            Oldal = oldal;
        }
    }
    public class Kor
    {
        public double Sugar { get; }

        public Kor(double sugar)
        {
            Sugar = sugar;
        }
    }
    public struct Teglalap
    {
        public double Hossz { get; }
        public double Magassag { get; }

        public Teglalap(double hossz, double magassag)
        {
            Hossz = hossz;
            Magassag = magassag;
        }
    }
    public class Haromszog
    {
        public double Alap { get; }
        public double Magassag { get; }

        public Haromszog(double alap, double magassag)
        {
            Alap = alap;
            Magassag = magassag;
        }
    }
}
