using System.Xml.Linq;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance !!
            // Skapar ett objek
            Building newBuilding = new Building();

            // Använder sen objektet för att anropa metoden
            newBuilding.Build();

            TwoStoryHouse twoStoryHouse1 = new TwoStoryHouse();

            twoStoryHouse1.SecondFloor();

            //Polymorphism !!
            MusicInstrument drum = new Pecussion();

            drum.Tuning();

            MusicInstrument guitarr = new StringInstrument();

            guitarr.Tuning();

            // Encapsulation

            Salary salary1 = new Salary("Pelle", 31, 24300);

            salary1.DisplayInformation();

            // Abstaction

            IceHockey IceHockeyGame1 = new IceHockey();

            IceHockeyGame1.Movement();

            IceHockeyGame1.GameLength();

        }
    }
}
