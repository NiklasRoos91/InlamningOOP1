namespace OOP1
{
    // Polymorfism
   public class MusicInstrument
    {

        public string name;
        public string material;
        public string vikt;

        // använder virtual så jag kan ändra det i sub klassen
        public virtual void Tuning()
        {
            Console.WriteLine("Hur stämmer man ett instrument");
        }
    }

    public class StringInstrument : MusicInstrument
    {
        public int numberOfStrings;

        // Override för att ändra metoden att passa in på denna sub klassen
        public override void Tuning()
        {
            Console.WriteLine("Ett sträng instrument stäms genom att dra åt och lossa på strängarna!");
        }
    }

    public class Pecussion : MusicInstrument
    {
        // Override för att ändra metoden att passa in på denna sub klassen
        public override void Tuning()
        {
            Console.WriteLine("Du stämer ett slaginstrument genom att justera spänningen på slagytan!");
        }
    }
}
