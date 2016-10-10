namespace FirstUse
{
    /// <summary>
    /// Concrete observer representing Animal
    /// </summary>
    public class Animal : MyObserver
    {
        /// <summary>
        /// Constructor for Animal
        /// </summary>
        /// <param name="name">name of the animal</param>
        public Animal(string name)
        {
            Name = "Animal " + name;
        }
    }
}
