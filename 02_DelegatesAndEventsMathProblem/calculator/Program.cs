using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp = new MathProblem();

            var add = new Add();
            var sub = new Sub();
            var mul = new Mul();
            var div = new Div();

            mp.NewParametersEvent += add.Solve;
            mp.NewParametersEvent += sub.Solve;
            mp.NewParametersEvent += mul.Solve;
            mp.NewParametersEvent += div.Solve;

            mp.SetParameters(10,10);

            Console.WriteLine("Add:" + add.Solution);
            Console.WriteLine("Sub:" + sub.Solution);
            Console.WriteLine("Mul:" + mul.Solution);
            Console.WriteLine("Div:" + div.Solution);
        }
    }
}
