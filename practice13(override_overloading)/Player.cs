using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice12_class_inheritance_
{
    internal class Player : Fighter
    {
        string name;
        int level;
        int max_hp;
        int needExp;
        
        public Player() 
        {
            this.name = "yeob";
            this.level = 5;
            this.hp = 400;
            this.power = 20;
            this.max_hp = this.hp;
            this.needExp = this.level * 5;
        }
        
        public int Level
        {
            get { return this.level; }
        }

        public int NeedEXP
        {
            get { return this.needExp; }
            set { this.needExp = value; }
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

        public override void Talk()
        {
            MessageBox.Show("정의를 위해 싸우겠습니다");
        }

        //오버로딩 연습용
        public void LevelUp()
        {
            this.level += 1;
            this.max_hp += 50;
            this.hp = this.max_hp;
            this.needExp = this.level * 5;
        }

        public void LevelUp(int value)
        {
            this.level += 1;
            this.max_hp += value;
            this.hp = this.max_hp;
            this.needExp = this.level * 5;
        }
    }
}
