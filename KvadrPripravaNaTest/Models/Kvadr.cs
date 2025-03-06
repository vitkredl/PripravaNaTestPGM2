namespace KvadrPripravaNaTest.Models
{
    public class Kvadr
    {
        private int stranaA;
        private int stranaB;
        private int stranaC;

        public int StranaA { get => stranaA; set => stranaA = value; }
        public int StranaB { get => stranaB; set => stranaB = value; }
        public int StranaC { get => stranaC; set => stranaC = value; }

        public double PovrchKvadru => 2 * (StranaA * StranaB + StranaA * StranaC + StranaB * StranaC);
        public double ObjemKvadru => StranaA * StranaB * StranaC;
    }
}
