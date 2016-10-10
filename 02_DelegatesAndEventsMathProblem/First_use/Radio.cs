namespace FirstUse
{
    public class Radio : ElectricalDevice
    {
        public float Freq { set; get; }

        public void Tune(float freq)
        {
            Freq = freq;
            Notify();
        }
    }
}
