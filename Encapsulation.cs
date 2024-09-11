namespace OOP1
{
    // Inkapsling
    public class Salary
    {
        // Skriv ut attributer, där lön och ålder är privat 
        public string name;
        private int age;
        private int salary;

        // gör konstruktör så jag kan sätta värde på attributerna direkt i skapandet av objektet
        public Salary(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            GetSalary = salary;
        }

        // metoder för att hämta privata attributerna 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int GetSalary
        {
            get { return salary; }  
            set { salary = value; }
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Namn: {name}, Ålder: {age}, Lön: {salary}");
        }
    }
}
