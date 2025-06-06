﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class BattleRobot: IPowerable, IMovable, IAttackable, IHealer
    {
        public bool IsOn { get; set; }
        public int Health { get; set; }
        public void TurnOn()
        {
            this.IsOn = true;
        }
        public void TurnOff()
        {
            this.IsOn = false;
        }
        public void MoveTo(string location)
        {
            if (this.IsOn)
            {
                Console.WriteLine($"Robbot is movinge to {location}.");
            }
            else
            {
                Console.WriteLine($"Robbot is off, Can't move.");
            }
            
        }
        public void Heal(int amount)
        {
            Console.WriteLine($"Robot is Healing - {amount}");
            this.Health -= amount;
        }
        public void TakeDamage(int amount)
        {
            Console.WriteLine($"Robbot is Taking Damage - {amount}.");
            this.Health -= amount;
        }
    }
}
