using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyFreeGame.Model
{
    public class Room
    {
        public Creature Player {  get; set; } 
        public List<Creature> Enemies { get; set; }
        public Room(Creature player) 
        {
            Player = player;
        }
        public void RunBattle()
        {

        }
    }
}
