using System;


namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            

            Console.WriteLine(value: $"Name: {heroName}\nHealth: |{Health(currentHealth,maxHealth)}|\nEnergy: |{Energy(currentEnergy,maxEnergy)}|");

            
        }

        static string Energy(int currentEnergy, int maxEnergy)
        {
            string symbolsOfCurrentEnergy = new string('|',currentEnergy);
            string symbolsOfMaxEnergy = new  string('.', maxEnergy-currentEnergy);

            string statusBar = symbolsOfCurrentEnergy + symbolsOfMaxEnergy;

            return statusBar;
        }

        static string Health(int currentHealth, int maxHealth)
        {
            string symbolsOfCurrentHealth = new string('|',currentHealth);
            string symbolsOfMaxHealth = new string('.',maxHealth-currentHealth);

            string statusBar = symbolsOfCurrentHealth + symbolsOfMaxHealth;

            return  statusBar;
        }

    }
}
