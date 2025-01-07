using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practice19_async_await_
{
    public partial class async_await : Form
    {
        public async_await()
        {
            InitializeComponent();

        }

        private async Task<string> ReadFileAsync()
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            //openFileDialog1.InitialDirectory = @""; //이건 왜 여기선 안되지?
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string fileContent = await sr.ReadToEndAsync();
                    return fileContent;

                }
            }
            openFileDialog1.Dispose();
            return "fail";
            
        }

        private async void button_input_Click(object sender, EventArgs e)
        {
            string content = await ReadFileAsync();
            //string[] content_lines = content.Replace("\r","").Split('\n');
            //textBox_result.Text = "";
            //for (int i = 0; i < content_lines.Length; i++)
            //{
            //    textBox_result.Text += $"{content_lines[i]}\r\n";
            //}
            textBox_result.Text = content;
        }
    }
}
