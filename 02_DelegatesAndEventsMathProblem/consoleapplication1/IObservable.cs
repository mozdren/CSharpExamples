namespace Pattern
{
    /// <summary>
    /// Itreface of Observable Item
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Attaches a notifying function
        /// </summary>
        /// <param name="notifyFunc">notifying funtion</param>
        void Attach(NotifyDelegate notifyFunc);

        /// <summary>
        /// Detaches a notyfiing function
        /// </summary>
        /// <param name="notifyFunc">notifying function</param>
        void Detach(NotifyDelegate notifyFunc);

        /// <summary>
        /// Fires notification
        /// </summary>
        void Notify();
    }
}
