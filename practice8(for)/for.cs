using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice8_for_
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
            //텍스트박스 입력으로 숫자받음(아닐 경우 체크기능 추가해야함)
            students_number = int.Parse(textBox_input.Text);
            int[] scores = Give_student_score(students_number);
            student_name_score_print(scores);
        }

        //랜덤하게 점수 부여
        int[] Give_student_score(int number)
        {
            int[] student_scores = new int[students_number + 1];
            //우선 시드 정해지는 걸텐데 이렇게 하면 동일하게 될것으로 예상
            //테스트 결과 다르게 나와서 random에 대해 더 알아봐야할듯
            Random random = new Random();
            for (int i = 1; i < students_number + 1; i++)
            {
                //Random random = new Random();
                student_scores[i] = random.Next(100); //100이하의 정수
            }

            return student_scores;
        }

        //출력
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
