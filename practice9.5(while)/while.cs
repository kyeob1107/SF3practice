using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 실습8의 for로 구현한 것 while로 수정

namespace practice9._5_while_
{
    public partial class Form1 : Form
    {
        int students_number;
        public Form1()
        {
            InitializeComponent();

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            //텍스트박스 입력으로 숫자받음
            if (int.TryParse(textBox_input.Text, out students_number))
            {
                int[] scores = Give_student_score(students_number);
                student_name_score_print(scores);
            }
            //입력값이 숫자가 아닐경우
            else
            {
                textBox_result.Text = $"숫자가 아닌 값을 입력하였습니다: {textBox_input.Text}";
                return;
            }
        }

        //랜덤하게 점수 부여함수
        int[] Give_student_score(int number)
        {
            int[] student_scores = new int[students_number + 1];
            //랜덤 객체 생성
            Random random = new Random();
            //반복문으로 학생수만큼 점수부여
            int i = 1; // while을 위한 정수
            //for (int i = 1; i < students_number + 1; i++)
            //{
            //    //Random random = new Random();
            //    student_scores[i] = random.Next(101); //101미만의 정수
            //}
            while(i < students_number + 1)
            {
                student_scores[i] = random.Next(101); //101미만의 정수
                i++;
            }

            return student_scores;
        }

        //출력함수
        void student_name_score_print(int[] scores)
        {
            //textBox_result 초기화
            textBox_result.Text = "";

            //반복문을 통해 배열의 데이터 정해진 틀로 출력
            for (int i = 1; i < students_number + 1; i++)
            {
                textBox_result.Text += $"학생{i}의 점수: {scores[i]}점\r\n";
            }
        }
    }
}
