using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Adventurer
    {
        public string name;
        public int exp = 0;
        public Adventurer()
        {
            Reset();
        }

        public Adventurer(string name)
        {
            this.name = name;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Adventurer: {0} - {1} EXP", this.name, this.exp);
        }

        private void Reset()
        {
            this.name = "unassigned";
            this.exp = 0;
        }
    }
}
