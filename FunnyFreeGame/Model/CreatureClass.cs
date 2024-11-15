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
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double CurrentHP { get; set; }
        public double MaxHP { get; set; }
    }
}
