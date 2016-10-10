namespace Pattern
{
    /// <summary>
    /// Delegate for definition of notification
    /// </summary>
    /// <param name="observable">observable object</param>
    public delegate void NotifyDelegate(IObservable observable);

    /// <summary>
    /// Abstract implementation of an inteface of observable object
    /// </summary>
    public abstract class Observable : IObservable
    {
        /// <summary>
        /// Change event
        /// </summary>
        public event NotifyDelegate StateChangedEvent;

        /// <summary>
        /// Attaching method
        /// </summary>
        /// <param name="notifyFunc">function to be attached</param>
        public void Attach(NotifyDelegate notifyFunc)
        {
            StateChangedEvent += notifyFunc;
        }

        /// <summary>
        /// Detaching method
        /// </summary>
        /// <param name="notifyFunc">funtion to be detached</param>
        public void Detach(NotifyDelegate notifyFunc)
        {
            StateChangedEvent -= notifyFunc;
        }

        /// <summary>
        /// Notify
        /// </summary>
        public void Notify() {
            StateChangedEvent(this);
        }
    }
}
