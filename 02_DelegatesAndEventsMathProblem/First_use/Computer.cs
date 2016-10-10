namespace FirstUse
{
    /// <summary>
    /// Specific electrical device
    /// </summary>
    public class Computer : ElectricalDevice
    {
        /// <summary>
        /// Message
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// Sends message
        /// </summary>
        /// <param name="message">message</param>
        public void SendMessage(string message)
        {
            Message = message;
            Notify();
        }
    }
}
