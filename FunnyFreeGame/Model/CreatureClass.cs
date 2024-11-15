using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyFreeGame.Model
{
    public abstract class CreatureClass
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public List<CreatureAction> Actions { get; set; }
        public void PrintActions()
        {
            foreach (CreatureAction action in Actions)
            {
                Console.WriteLine(action.Title);
            }
        }
    }
}
