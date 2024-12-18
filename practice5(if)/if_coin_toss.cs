using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice5_if_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string result_text;
            
            // 우선 동전을 True로 예측하는 것으로 설정
            bool prediction_1 = true;

            // 결과 확인 및 출력
            if (Coin_toss_result(prediction_1))
            {
                result_text = "승리";
            }
            else
            {
                result_text = "패배";
            }

            textBox_print.Text = $"동전던지기의 예측 결과는 {result_text}!";
        }

        public bool Coin_toss_result(bool prediction)
        {   
            // 난수 객체 생성 및 이용하여 정수 생성
            Random random = new Random();
            int coin_pre_process = random.Next();
            bool coin;
            bool result;

            //랜덤 값을 동전 상태(bool)로 정의
            if (coin_pre_process % 2 == 0)
            {
                coin = false;
            }
            else
            {
                coin = true;
            }

            // 예측결과 bool로 저장
            result = (coin == prediction); // 괄호 안쳐도 작동은 하는듯함

            return result;
        }
    }
}
