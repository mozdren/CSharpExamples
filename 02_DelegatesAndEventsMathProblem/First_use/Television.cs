namespace FirstUse
{
    /// <summary>
    /// Television - concrete electrical device
    /// </summary>
    public class Television : ElectricalDevice
    {
        /// <summary>
        /// Channel
        /// </summary>
        public int Channel { set; get; }

        /// <summary>
        /// Change the channel
        /// </summary>
        /// <param name="i">channel number</param>
        public void ChangeChannel(int i)
        {
            Channel = i;
            Notify();
        }
    }
}
