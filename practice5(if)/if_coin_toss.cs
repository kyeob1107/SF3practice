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
            bool prediction_1 = true;
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
            Random random = new Random();
            int coin_pre_process = random.Next();
            bool coin;
            bool result;
            if (coin_pre_process % 2 == 0)
            {
                coin = false;
            }
            else
            {
                coin = true;
            }

            result = (coin == prediction); // 괄호 안쳐도 작동은 하는듯함

            return result;
        }
    }
}
