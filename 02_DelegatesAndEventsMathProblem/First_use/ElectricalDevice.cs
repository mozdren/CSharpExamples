namespace FirstUse
{
    /// <summary>
    /// Abstract implementation of Electrical Device
    /// </summary>
    public abstract class ElectricalDevice : Pattern.Observable
    {
        /// <summary>
        /// Is it on or off?
        /// </summary>
        public bool IsOn { set; get; }

        /// <summary>
        /// Model of the device
        /// </summary>
        public string Model { set; get; }

        /// <summary>
        /// Turn on
        /// </summary>
        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Notify();
            }
        }

        /// <summary>
        /// Turn off
        /// </summary>
        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Notify();
            }
        }
    }
}
