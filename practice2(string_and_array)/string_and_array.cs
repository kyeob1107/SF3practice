using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2_string_and_array_
{
    public partial class string_and_array : Form
    {
        string[] string_array = new string[10];
        string s1 = "동해 물과 백두산이";
        string s2 = "토요일에 먹는 토마토";
        string s3 = "질서있는 퇴장";
        string s4 = "그 사람의 그림자는 그랬다";
        string s5 = "삼성 갤럭시";
        string s6 = "오늘은 왠지 더 배고프다";
        string s7 = "이름, 나이, 전화번호";
        string s8 = "우리 나라 만세";

        public string_and_array()
        {
            InitializeComponent();
            string_array[0] = s1.IndexOf("백두산").ToString();
            string_array[1] = s2.LastIndexOf("토").ToString();
            string_array[2] = s3.Contains("퇴").ToString();
            string_array[3] = s4.Replace("그", "이");
            string_array[4] = s5.Insert(s5.IndexOf(" ") + 1, "애플 ");
            string_array[5] = s6.Remove(s6.IndexOf("더"));
            string[] split_temp = s7.Split(',');
            string_array[6] = split_temp[0];
            string_array[7] = split_temp[1].Replace(" ", "");
            string_array[8] = split_temp[2].Replace(" ", "");
            string_array[9] = s8.Substring(s8.IndexOf(" ") + 1, 2);

            foreach (string sub in string_array)
            {
                textBox_print.Text += sub + "\r\n";
            }
        }
    }
}
