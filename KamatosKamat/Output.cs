using System;

namespace KamatosKamat
{
    internal class Output
    {
        private int i;
        private double test;

        public Output(int i, double test)
        {
            this.I = i;
            this.Test = test;
        }

        public int I { get => i; set => i = value; }
        public double Test { get => test; set => test = value; }

        public override string ToString()
        {
            return $"{I} year : ${Math.Round(Test, 2)}";
        }
    }
}