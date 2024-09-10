namespace OOP1
{
    // Arv
    public class Building
    {
        // Attributer som subclass sen ärver
        public string walls;
        public string color;
        public string roof;
        public string windows;

        // Metod som sub class ärver
        public void Build()
        {
            Console.WriteLine("Alla hus behöver byggas");
        }
    }

    public class TwoStoryHouse
    {
        // Attribut bara för TwoStoryHouse
        public string stairs;

        // Metod bara för TwoStoryHouse
        public void SecondFloor()
        {
            Console.WriteLine("För att komma till andra våningen så behöver man gå upp för trapporna");
        }
    }
}
