namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int bonus;

        public Warrior() : base()
        {
            Console.WriteLine("----> Konstruktor default Warrior <----");
        }

        public Warrior(int bonus, string id, string name, int basePower, string address)
               : base(id, name, basePower, address)
        {
           Console.WriteLine("----> Konstruktor berparameter warrior <----");
           this.bonus = bonus; 
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS          = " + bonus);
            Console.WriteLine("TOTAL POWER    = " + (GetBasePower() + bonus));
            Console.WriteLine("=================");
        }
    }
}