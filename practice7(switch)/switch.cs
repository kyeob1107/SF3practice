using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice7_switch_
{ 
    public partial class Form1 : Form
    {   
       

        public Form1()
        {
            InitializeComponent();

        }
        public enum Day_of_week
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun,
            Etc = 999
        }
        public Day_of_week Input_trans(string text)
        {
            switch (text)
            {
                case "월요일":
                    return Day_of_week.Mon;

                case "화요일":
                    return Day_of_week.Tue;

                case "수요일":
                    return Day_of_week.Wed;

                case "목요일":
                    return Day_of_week.Thu;

                case "금요일":
                    return Day_of_week.Fri;

                case "토요일":
                    return Day_of_week.Sat;

                case "일요일":
                    return Day_of_week.Sun;

                default:
                    return Day_of_week.Etc;

            }
        }


        private void button_input_Click(object sender, EventArgs e)
        {
            //List<string> day_of_week_str = new List<string>;
            //day_of_week_str = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            Day_of_week dow = Input_trans(textBox_input.Text);      
            switch (dow)
            {
                case Day_of_week.Mon:
                    textBox_result.Text = "월요일, 일주일의 시작이군";
                    break;

                case Day_of_week.Tue:
                    textBox_result.Text = "화요일, 어제 일주일을 시작했구나";
                    break;

                case Day_of_week.Wed:
                    textBox_result.Text = "수요일, 반정도 했구나";
                    break;

                case Day_of_week.Thu:
                    textBox_result.Text = "목요일, 2일만 더 버티면 주말이다!";
                    break;

                case Day_of_week.Fri:
                    textBox_result.Text = "금요일, 이제 주말온다";
                    break;

                case Day_of_week.Sat:
                    textBox_result.Text = "토요일, 주말이 시작됬어";
                    break;

                case Day_of_week.Sun:
                    textBox_result.Text = "일요일, 벌써 주말이 끝나가네...";
                    break;

                default:
                    textBox_result.Text = "다른 문자";
                    break;
            }
            
        }
    }
}
