using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice14_reference_
{
    public partial class RefOut : Form
    {
        //int[] numbers;
        int[] numbers;
        int[] numbers2;
        


        public RefOut()
        {
            InitializeComponent();
            numbers = new int[10];
        }

        void Practice_ref(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
        }

        void Practice_out(out int[] numbers2, int size)
        {
            numbers2 = new int[size];
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = i + 1;
            } 
        }

        private void button_ref_Click(object sender, EventArgs e)
        {
            Practice_ref(ref numbers);
            textBox_result.Text += "==========ref 실행한 결과입니다============\r\n";
            foreach (int number in numbers)
            {
                textBox_result.Text += $"{number} \r\n";
            }
        }

        private void button_out_Click(object sender, EventArgs e)
        {
            Practice_out(out numbers2, 10);
            textBox_result.Text += "==========out 실행한 결과입니다============\r\n";
            foreach (int number in numbers2)
            {
                textBox_result.Text += $"{number} \r\n";
            }
        }
    }
}
