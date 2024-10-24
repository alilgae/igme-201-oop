using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class SomeGuy
    {
        public string name;
        public int exp = 0;

        public SomeGuy()
        {
            Reset();
        }

        public SomeGuy(string name)
        {
            this.name = name;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Dude: {0} - {1} EXP", this.name, this.exp);
        }

        private void Reset()
        {
            this.name = "unassigned";
            this.exp = 0;
        }
    }
}
