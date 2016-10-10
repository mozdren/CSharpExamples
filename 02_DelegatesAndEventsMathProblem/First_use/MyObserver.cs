using System;

namespace FirstUse
{
    /// <summary>
    /// More concrete implementation of Observer
    /// </summary>
    public class MyObserver : Pattern.Observer
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Notification
        /// </summary>
        /// <param name="observable">observable object</param>
        public override void Notify(Pattern.IObservable observable)
        {
            // what to do if the observable object is Computer
            if (observable is Computer)
            {
                var computer = observable as Computer;
                Console.WriteLine("{0} -> Computer: ON:{1} , message: {2}", Name, computer.IsOn, computer.Message);
            }
            else if (observable is Television) // observable is television
            {
                var television = observable as Television;
                Console.WriteLine("{0} -> Computer: ON:{1} , Channel: {2}", Name, television.IsOn, television.Channel);
            }
            else if (observable is Radio)
            {
                var radio = observable as Radio;
                Console.WriteLine("{0} -> Computer: ON:{1} , Freq: {2}", Name, radio.IsOn, radio.Freq);
            }
        }
    }
}
