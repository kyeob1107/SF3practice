using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 이곳에 소스코드를 작성

            //textBox_print.Text = "어떤 결과가 나올까?";

            byte call_total_count = 30;
            short a_point_height_meter = 2744;
            int solar_diameter_kilometer = 1392684;
            float exchange_rate_dollar_to_won = 1436.54f;
            double pie_to_15 = 3.141592653589793;
            decimal jupiter_mass_ton2 = 1.899m * 1_000_000_000_000_000_000_000_000m;

            // byte
            textBox_print.Text = call_total_count.GetType().ToString();
            textBox_print.Text += " call_total_count: ";
            textBox_print.Text += call_total_count.ToString();
            // short
            textBox_print.Text += "\r\n";
            textBox_print.Text += a_point_height_meter.GetType();
            textBox_print.Text += " a_point_height_meter: ";
            textBox_print.Text += a_point_height_meter.ToString();
            // int
            textBox_print.Text += "\r\n";
            textBox_print.Text += solar_diameter_kilometer.GetType();
            textBox_print.Text += " solar_diameter_kilometer: ";
            textBox_print.Text += solar_diameter_kilometer.ToString();
            // float
            textBox_print.Text += "\r\n";
            textBox_print.Text += exchange_rate_dollar_to_won.GetType();
            textBox_print.Text += " exchange_rate_dollar_to_won: ";
            textBox_print.Text += exchange_rate_dollar_to_won.ToString();
            // double
            textBox_print.Text += "\r\n";
            textBox_print.Text += pie_to_15.GetType();
            textBox_print.Text += " pie_to_15: ";
            textBox_print.Text += pie_to_15.ToString();
            // decimal
            textBox_print.Text += "\r\n";
            textBox_print.Text += jupiter_mass_ton2.GetType();
            textBox_print.Text += " jupiter_mass_ton: ";
            textBox_print.Text += jupiter_mass_ton2.ToString();
        }
    }
}
