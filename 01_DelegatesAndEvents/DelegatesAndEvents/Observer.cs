using System;

namespace DelegatesAndEvents
{
    /// <summary>
    /// Observer implementation, announces change using provided format
    /// </summary>
    /// <typeparam name="T">Generic type to be used for value</typeparam>
    public class Observer<T>
    {
        /// <summary>
        /// Format to be used with the announcement
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Constructor of the Observer
        /// </summary>
        /// <param name="format">format to be used</param>
        public Observer(string format)
        {
            Format = format;
        }

        /// <summary>
        /// Implementation of the announcement
        /// </summary>
        /// <param name="value">value to be annouced using set format</param>
        public void AnnounceObservation(T value)
        {
            Console.WriteLine(string.Format(Format, value));
        }
    }
}
