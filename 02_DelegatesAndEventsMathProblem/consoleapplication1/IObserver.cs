namespace Pattern
{
    /// <summary>
    /// Interface of Observer
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Method used for notification
        /// </summary>
        /// <param name="observable">observable item</param>
        void Notify(IObservable observable);
    }
}
