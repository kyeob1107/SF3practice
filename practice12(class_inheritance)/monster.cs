using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12_class_inheritance_
{
    internal class Monster : Fighter
    {
        protected int exp; //플레이어에게 경험치 통을 추가해줘야할듯
        public Monster() 
        {
            this.exp = 10;
            this.honor = -1;
        }

    }

    internal class Slime : Monster
    {
        public Slime()
        {
            this.exp = 20;
            this.hp = 150;
            this.power = 10;
        }

        public int acidAttack()
        {
            int damage = this.power + this.power / 5;
            return damage;
        }
    }

    internal class Orc : Monster
    {
        int max_hp;
        public Orc()
        {
            this.exp = 50;
            this.hp = 400;
            this.power = 15;
            max_hp = this.hp;
        }

        public int selfHeal()
        {
            int healValue = max_hp / 10;
            if (!(this.hp + healValue < max_hp))
            {
                healValue = max_hp - this.hp;
            }
            this.hp += healValue;
            return healValue;
        }
    }
}
