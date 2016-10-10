namespace DelegatesAndEvents
{
    /// <summary>
    /// Object to be observed
    /// </summary>
    /// <typeparam name="T">Generic type to be used for value</typeparam>
    public class ObservedObject<T>
    {
        /// <summary>
        /// Delegate describing a format of the event
        /// </summary>
        /// <param name="value">changed value</param>
        public delegate void ValueChangedDelegate(T value);

        /// <summary>
        /// Event fired when value changed
        /// </summary>
        public event ValueChangedDelegate ValueChaged;

        /// <summary>
        /// property representing the value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// method changing the value and firing the ValueChanged event
        /// </summary>
        /// <param name="value">new value</param>
        public void ChangeValue(T value)
        {
            Value = value;
            ValueChaged(value);
        }
    }
}
