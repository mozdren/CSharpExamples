using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    /// <summary>
    /// Abstract implementation of Observer
    /// </summary>
    public abstract class Observer : IObserver
    {
        /// <summary>
        /// Abstract method for notification
        /// </summary>
        /// <param name="observable">observable object</param>
        public abstract void Notify(IObservable observable);
    }
}
