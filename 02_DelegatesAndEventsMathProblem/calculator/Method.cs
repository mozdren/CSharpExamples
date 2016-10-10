namespace Calculator
{
    abstract class Method
    {
        /// <summary>
        /// Solution of the computation
        /// </summary>
        public int Solution { set; get; }

        /// <summary>
        /// Abstract method for computational method
        /// </summary>
        /// <param name="mp">math problem instance</param>
        public abstract void Solve(MathProblem mp);
    }

    /// <summary>
    /// Concrete implementation of the Method (Addition)
    /// </summary>
    class Add : Method
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="mp"></param>
        public override void Solve(MathProblem mp)
        {
            Solution = mp.ParameterA + mp.ParameterB;
        }
    }

    /// <summary>
    /// Concrete implementation of the Method (Subtraction)
    /// </summary>
    class Sub : Method
    {
        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="mp">math problem instance</param>
        public override void Solve(MathProblem mp)
        {
            Solution = mp.ParameterA - mp.ParameterB;
        }
    }

    /// <summary>
    /// Concrete implementation of the Method (Multiplication)
    /// </summary>
    class Mul : Method
    {
        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="mp">math problem</param>
        public override void Solve(MathProblem mp)
        {
            Solution = mp.ParameterA * mp.ParameterB;
        }
    }

    /// <summary>
    /// Concrete implementation of the method (Division)
    /// </summary>
    class Div : Method
    {
        /// <summary>
        /// Division
        /// </summary>
        /// <param name="mp">math problem</param>
        public override void Solve(MathProblem mp)
        {
            Solution = mp.ParameterA / mp.ParameterB;
        }
    }
}
