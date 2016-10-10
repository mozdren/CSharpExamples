namespace DelegatesAndEvents
{
    /// <summary>
    /// This example demonstrates use of Delegates and Events
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /// Create observers
            var person1 = new Observer<int>("Well, I see there was a change of value to {0}.");
            var person2 = new Observer<int>("Value changed to {0}.");
            var person3 = new Observer<int>("Damn, not again! I hate {0}.");

            /// Create subject
            var objectOfInterest = new ObservedObject<int>();

            /// Subscribe observers
            objectOfInterest.ValueChaged += person1.AnnounceObservation;
            objectOfInterest.ValueChaged += person2.AnnounceObservation;
            objectOfInterest.ValueChaged += person3.AnnounceObservation;

            /// Fire event by changing value
            objectOfInterest.ChangeValue(123);

            /// Remove observer
            objectOfInterest.ValueChaged -= person3.AnnounceObservation;

            /// Fire again
            objectOfInterest.ChangeValue(321);
        }
    }
}
