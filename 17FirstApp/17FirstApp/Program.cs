using System;

namespace _17FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 8;
            d = 9;
            var t = 9;
            int r = MathLib.T;
            MathLib m = new MathLib();
            int u = m.p;
            //MathLib.T = 9;

            Console.ReadKey();
        }
        class MathLib
        {
            public const int T = 67;
            public readonly int p = 89;
            public MathLib()
            {
                p = 78;
                //T = 78;
            }
        }
    }
}
