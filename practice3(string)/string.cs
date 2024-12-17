using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3_string_
{
    public partial class Form1 : Form
    {
        string text = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
        
        public Form1()
        {
            InitializeComponent();
            string result1;
            result1 = text.Remove(text.IndexOf(" -"));

            string result2;
            result2 = text.Substring(text.IndexOf("한") + 2);
            result2 = result2.Remove(result2.IndexOf("중요") - 1);
            string[] result2_array = result2.Split(' ');
            result2_array[2] = result2_array[2].Remove(result2_array[2].LastIndexOf("는"));

            string result3;
            result3 = text.Replace(".", "");
            result3 = result3.Replace("-", "");
            result3 = result3.Replace(" ", ",");


            textBox_print.Text = "1번 결과물";
            textBox_print.Text += "\r\n" + result1;
            textBox_print.Text += "\r\n\r\n" + "2번 결과물";
            textBox_print.Text += "\r\n" + result2_array[0];
            textBox_print.Text += "\r\n" + result2_array[1];
            textBox_print.Text += "\r\n" + result2_array[2];
            textBox_print.Text += "\r\n\r\n" + "3번 결과물";
            textBox_print.Text += "\r\n" + result3;
        }
    }
}
