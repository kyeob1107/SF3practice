using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12_class_inheritance_
{
    internal class Npc : Fighter
    {
        string name;
        public Npc()
        {
            this.name = "resident";
            this.hp = 600;
            this.power = 10;
        }
        
        string interaction()
        {
            string text = "반갑습니다 모험가님";
            return text;
        }
    }
}
