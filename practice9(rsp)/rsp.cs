using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice9_while_
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        //enum rock_scissors_parper
        //{
        //    Rock = 0,
        //    Scissors = 2,
        //    Paper = 5

        //}
        // 바위 = 0
        // 가위 = 2
        // 보 = 5
        int user_state;
        int pc;
        int win_count_user = 0;
        int win_count_pc = 0;

        public Form1()

        {
            InitializeComponent();
            textBox_result.Text = "";

        }
        
        //다시시작
        private void button_input_Click(object sender, EventArgs e)
        {
            win_count_user = 0;
            win_count_pc = 0;
            label_user_wins.Text = $"사용자 승리 수: {win_count_user}";
            label_pc_wins.Text = $"컴퓨터 승리 수: {win_count_pc}";
            textBox_result.Text = "";
        }

        private void button_scissors_Click(object sender, EventArgs e)
        {
            user_state = 2;
            textBox_result.Text ="사용자가 가위를 냈습니다\r\n";
            Final_process();


        }

        private void button_rock_Click(object sender, EventArgs e)
        {
            user_state = 0;
            textBox_result.Text = "사용자가 바위를 냈습니다\r\n";
            Final_process();

        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            user_state = 5;
            textBox_result.Text = "사용자가 보를 냈습니다\r\n";
            Final_process();
        }

        void Final_process()
        {
            pc = Computer_random_rsp();
            Check_result(user_state, pc);
            label_user_wins.Text = $"사용자 승리 수: {win_count_user}";
            label_pc_wins.Text = $"컴퓨터 승리 수: {win_count_pc}";
            if (win_count_user > 2 | win_count_pc > 2)
            {
                textBox_result.Text += "게임이 끝났습니다\r\n";
                if (win_count_pc > 2)
                {
                    textBox_result.Text += "컴퓨터가 최종승리하였습니다";
                    MessageBox.Show("컴퓨터가 최종승리하였습니다");
                }
                else
                {
                    textBox_result.Text += "사용자가 최종승리하였습니다";
                    MessageBox.Show("사용자가 최종승리하였습니다");
                }
            }
        }

        int Computer_random_rsp()
        {
            //컴퓨터가 랜덤하게 내기
            int pre_pc_state = rand.Next(3); // 랜덤하게 컴퓨터 낼 것 정하는 값
            switch (pre_pc_state)
            {
                case 0:
                    textBox_result.Text += "컴퓨터가 바위를 냈습니다\r\n";
                    return 0;

                case 1:
                    textBox_result.Text += "컴퓨터가 가위를 냈습니다\r\n";
                    return 2;

                default:
                    textBox_result.Text += "컴퓨터가 보를 냈습니다\r\n";
                    return 5;

            }
        }

        void Check_result(int user, int computer)
        {
            //비겼을때
            if (user == computer)
            {
                textBox_result.Text += "비겼습니다\r\n";
            }
            // 바위와 보가 나왔을 때
            else if (user + computer == 5)
            {
                if (user == 0)
                {
                    win_pc();
                }
                else
                {
                    win_user();
                }
            }
            //그외 일반적인 상황
            else
            {
                if (user > computer)
                {
                    win_pc();
                }
                else
                {
                    win_user();
                }
            }
        }
        void win_pc()
        {
            win_count_pc += 1;
            textBox_result.Text += "컴퓨터가 이겼습니다\r\n";
        }

        void win_user()
        {
            win_count_user += 1;
            textBox_result.Text += "사용자가 이겼습니다\r\n";
        }

    }
}
