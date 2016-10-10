namespace Calculator
{
    /// <summary>
    /// Math problem delegate
    /// </summary>
    /// <param name="mp">math problem instance</param>
    public delegate void ParameterDelegate(MathProblem mp);

    /// <summary>
    /// Class representing a math problem
    /// </summary>
    public class MathProblem
    {
        /// <summary>
        /// Event showing that parameters of the math problem were changed
        /// </summary>
        public event ParameterDelegate NewParametersEvent;

        /// <summary>
        /// First paramter of the math problem
        /// </summary>
        public int ParameterA { set; get; }

        /// <summary>
        /// Second parameter of the math problem
        /// </summary>
        public int ParameterB { set; get; }

        /// <summary>
        /// Method setting the parameters
        /// </summary>
        /// <param name="a">new parameter a value</param>
        /// <param name="b">new parameter b value</param>
        public void SetParameters(int a, int b)
        {
            ParameterA = a;
            ParameterB = b;
            NewParametersEvent(this);
        }
    }
}
