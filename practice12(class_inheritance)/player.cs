using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12_class_inheritance_
{
    internal class Player : Fighter
    {
        string name;
        int level;
        
        public Player() 
        {
            this.name = "yeob";
            this.level = 5;
            this.hp = 400;
            this.power = 20;
        }
        
        public override int attack()
        {
            int damage = this.power + level * 10;
            return damage;
        }
        string interaction()
        {
            string text = "안녕하세요";
            return text;
        }
    }
}
