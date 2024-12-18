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
            InitializeComponent();
            int[] value = Div_mod(7, 5);
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
    }
}
