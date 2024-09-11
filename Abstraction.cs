namespace OOP1
{
    // Abstraktion
    abstract class Sport
    {
        public abstract void Movement();
        public abstract void GameLength();
    }

    class IceHockey : Sport
    {
        public override void Movement()
        {
            Console.WriteLine("I hockey åker man skridskor");
        }

        public override void GameLength() 
        {
            Console.WriteLine("En hockey match är 60 minuter lång indelad i 15 minuters perioder!");
        }
    }
}
