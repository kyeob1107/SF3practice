using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12_class_inheritance_
{
    internal class Fighter
    {
        protected int hp;
        protected int power;
        protected int honor;

        public int Hp
        {
            get { return hp; }
        }

        public int Power
        {
            get { return power; }
        }

        public int Honor
        {
            get { return honor; }
        }

        public Fighter() 
        {
            hp = 200;
            power = 1;
            honor = 1;
        }

        

        public virtual int attack()
        {
            return power;
        }

        public void takeDamage(int damage)
        {
            this.hp -= damage;
        }
    }
}
