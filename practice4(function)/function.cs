using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice4_function_
{
    public partial class function : Form
    {
        public function()
        {
            // 처음 실행시 form이 만들어지는 어떤 것이라는 좀 특수한 것이라고 함
            InitializeComponent();
            //int[] value = Div_mod(7, 5);
            int[] value = Div_mod(int.Parse(div_x.Text), int.Parse(div_y.Text));
            textBox_print.Text = "몫은 " + value[0].ToString();
            textBox_print.Text += ", 나머지는 " + value[1].ToString();
        }

        public int[] Div_mod(int x, int y)
        {
            int[] result = new int[2];
            result[0] = x / y;
            result[1] = x % y;

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //function(); 
            //form(function)그냥은 못쓰고 따로 객체로 만들어야 가능하다고 해서
            //일단 그렇게 알고 패스
            int[] value = Div_mod(int.Parse(div_x.Text), int.Parse(div_y.Text));
            textBox_print.Text = "몫은 " + value[0].ToString();
            textBox_print.Text += ", 나머지는 " + value[1].ToString();
        }
    }
}
