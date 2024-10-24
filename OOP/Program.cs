namespace OOP
{
    public class Character
    {
        public string name;
        public int exp = 0;

        public Character()
        {
            Reset();
        }

        public Character(string name)
        {
            this.name= name;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Hero: {0} - {1} EXP", this.name, this.exp);
        }

        private void Reset()
        {
            this.name = "unassigned";
            this.exp = 0;
        }
    }

    public class Paladin: Character
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon) : base(name) 
        {
            this.weapon = weapon;
        }

        public override void PrintStats()
        {
            Console.WriteLine("Paldain {0}! Take up your {1}!", this.name, this.weapon);
        }
    }
    public struct Weapon
    {
        public string name;
        public int damage;
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        public void PrintStats()
        {
            Console.WriteLine("Weapon: {0} - {1} DMG", this.name, this.damage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character steve = new Character();
            steve.PrintStats();

            Character daisy = new Character("Daisy");
            daisy.PrintStats();
            
            Weapon sword = new Weapon("Sword of Doom", 100);
            sword.PrintStats();

            Character jackBlack = steve;
            steve.PrintStats();
            jackBlack.PrintStats();

            jackBlack.name = "THE Jack Black";

            steve.PrintStats();
            jackBlack.PrintStats();

            Weapon longsword = sword;
            sword.PrintStats();
            longsword.PrintStats();

            longsword.name = "Longsword of Destruction";
            longsword.damage = 250;

            sword.PrintStats();
            longsword.PrintStats();

            Paladin batman = new Paladin("The Dark Knight: Batman", sword);
            batman.PrintStats();

            Adventurer dave = new Adventurer("dave");
            dave.PrintStats();

            SomeGuy jared = new SomeGuy("jared");
            jared.PrintStats();
        }
    }
}
