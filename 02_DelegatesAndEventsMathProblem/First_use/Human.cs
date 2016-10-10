namespace FirstUse
{
    /// <summary>
    /// Even more concrete implementaion of observer (Human)
    /// </summary>
    public class Human : MyObserver
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name of the human</param>
        public Human(string name)
        {
            Name = "Human " + name;
        }
    }
}
