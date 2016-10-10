namespace FirstUse
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Animal("Mourek");
            var dog = new Animal("Rex");
            var karel = new Human("Karel");
            var samuel = new Human("Samuel");

            var television = new Television();
            var computer = new Computer();
            var radio = new Radio();

            television.Attach(cat.Notify);
            television.Attach(dog.Notify);
            television.Attach(karel.Notify);
            television.Attach(samuel.Notify);
            computer.Attach(karel.Notify);
            radio.Attach(cat.Notify);
            radio.Attach(dog.Notify);
            
            radio.TurnOn();
            radio.Tune(101.1f);
            radio.TurnOff();

            television.TurnOn();
            television.ChangeChannel(10);
            television.TurnOff();

            computer.TurnOn();
            computer.SendMessage("Hello, World!");
            computer.TurnOff();
        }
    }
}
