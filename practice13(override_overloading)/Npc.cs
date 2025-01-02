using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public override void Talk()
        {
            MessageBox.Show("좋은 하루 되시길 바라겠습니다");
        }
    }
}
