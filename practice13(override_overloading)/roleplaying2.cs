﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice12_class_inheritance_
{
    public partial class roleplaying2 : Form
    {
        Monster monster;
        Player player;
        Npc npc;
        
        public roleplaying2()
        {
            InitializeComponent();
            monster = new Slime();
            player = new Player();
            npc = new Npc();
            textBox_result.Text = "";
            DisplayPlayerInfo();

        }

        //void fight(Fighter player, Fighter monster)
        //{
        //    player
        //}

        private void button_play_Click(object sender, EventArgs e)
        {
            monster = new Slime(); //몬스터, npc는 새로 생성
            npc = new Npc();

            if (listBox_fighter1.SelectedItem != null && listBox_fighter2.SelectedItem != null)
            {
                string selectCharcter1 = listBox_fighter1.SelectedItem.ToString();
                string selectCharcter2 = listBox_fighter2.SelectedItem.ToString();
                Fighter fighter1 = SelectMatching(selectCharcter1);// = new Fighter();
                Fighter fighter2 = SelectMatching(selectCharcter2);// = new Fighter();
                label1.Text = $"체력: {fighter1.Hp}, 공격력: {fighter1.Power}";
                label2.Text = $"체력: {fighter2.Hp}, 공격력: {fighter2.Power}";
                
                //오버라이딩 연습용: 대사하기
                fighter1.Talk();
                fighter2.Talk();
                
                //textBox_result.Text = $"{fighter1.Honor}, {fighter2.Honor}"; //확인용
                if (fighter1.Honor * fighter2.Honor > 0)
                {
                    textBox_result.Text = "둘은 아군입니다 싸우지말고 사이좋게 지내세요\r\n";
                    //상호작용 넣기?
                }
                else
                {
                    int turnCount = 1;
                    textBox_result.Text = "";
                    while (fighter1.Hp > 0 && fighter2.Hp >0)
                    {
                        textBox_result.Text += $"=========={turnCount}번째 턴입니다============\r\n";

                        fighter2.takeDamage(fighter1.attack());
                        textBox_result.Text += $"{selectCharcter1}가 {selectCharcter2}에게 " +
                                                                $"{fighter1.attack()}만큼 데미지를 입혔습니다\r\n";
                        fighter1.takeDamage(fighter2.attack());
                        textBox_result.Text += $"{selectCharcter2}가 {selectCharcter1}에게 " +
                                                                $"{fighter2.attack()}만큼 데미지를 입혔습니다\r\n";
                        SpecialAction(selectCharcter1, fighter1, fighter2);
                        SpecialAction(selectCharcter2, fighter2, fighter1);
                        
                        textBox_result.Text += $"{selectCharcter1}의 체력은 {fighter1.Hp}입니다\r\n";
                        textBox_result.Text += $"{selectCharcter2}의 체력은 {fighter2.Hp}입니다\r\n";
                    }
                    if (fighter1.Hp > fighter2.Hp) 
                    {
                        MessageBox.Show($"{selectCharcter1} 승리!!");
                        //if (selectCharcter1 == "player" && 
                        //                (selectCharcter2 == "slime" || selectCharcter2 == "orc"))
                        //{
                        //    int tempExp = ((Player)fighter1).NeedEXP - ((Monster)fighter2).Exp;
                        //    if (tempExp > 0)
                        //    {
                        //        ((Player)fighter1).NeedEXP = tempExp;
                        //    }
                        //    else
                        //    {

                        //    }
                        //}
                            if (selectCharcter2 == "player") player = new Player();

                    }
                    else 
                    { 
                        MessageBox.Show($"{selectCharcter2} 승리!!");
                        if (selectCharcter1 == "player") player = new Player();
                    }

                }
            }
            else
            {
                MessageBox.Show("선택을 해주세요!!!");
            }
        }

        //void DisplayHpNPower()
        //{
            
        //}

        void SpecialAction(string selectCharcter, Fighter actor, Fighter target)
        {
            if (selectCharcter == "slime")
            {
                target.takeDamage(((Slime)actor).acidAttack());
                textBox_result.Text += $"[특별행동]{selectCharcter}가 산성공격을" +
                                       $"{((Slime)actor).acidAttack()}만큼 데미지를 입혔습니다\r\n";
            }
            else if (selectCharcter == "orc")
            {
                int healValue = ((Orc)actor).selfHeal();
                textBox_result.Text += $"[특별행동]{selectCharcter}가 자신의 체력을" +
                                       $"{healValue}만큼 회복했습니다\r\n";
            }
        }

        Fighter SelectMatching(string selectCharcter)
        {
            switch (selectCharcter)
            {
                case "player":
                    return player;
                case "npc":
                    return npc;
                case "slime":
                    return monster;
                case "orc":
                    monster = new Orc();
                    return monster;
                default:
                    return null;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            monster = new Slime();
            player = new Player();
            npc = new Npc();
            textBox_result.Text = "";
        }

        private void button_levelup_Click(object sender, EventArgs e)
        {
            //player.LevelUp();
            player.LevelUp(100);
            DisplayPlayerInfo();
        }

        void DisplayPlayerInfo()
        {
            label_playerinfo.Text = $"Level: {player.Level}, HP: {player.Hp}, " +
                $"power: {player.Power}, Need_EXP: {player.NeedEXP}";
        }
    }
}
