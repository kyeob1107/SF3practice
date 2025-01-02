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
using System.Net.Http;

namespace practice15_exceptional_handling_
{
    public partial class exceptional_handling : Form
    {
        string content;
        int[] content_parsing;
        public exceptional_handling()
        {
            InitializeComponent();
            textBox_result.Text = "========================================\r\n";
            textBox_result.Text += "<몇번째 줄> 원본 문자열\r\n";
            textBox_result.Text += "-> (문자인 부분S로 표시) : 숫자부분\r\n";
            textBox_result.Text += "========================================\r\n";

            try
            {
                content = File.ReadAllText("../../input.txt");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("경로를 찾지 못하였습니다");
            }
            catch (FileNotFoundException) 
            {
                MessageBox.Show("파일을 찾지 못하였습니다");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //catch  //그냥 이렇게 아래 달아도 에러 안나던데
            //{
                
            //}

            // 파싱되는 부분 확인
            HandmaidParsing(out content_parsing);
            
            //foreach (string line in content.Split('\r', '\n'))
            //{
            //    textBox_result.Text += line + "\r\n";
            //}
        }

        void HandmaidParsing(out int[] content_parsing)
        {
            //string[] lines = content.Split('\r', '\n');
            string[] lines = content.Replace("\r","").Split('\n');
            content_parsing = new int[lines.Length];
            int i = 0;
            foreach (string line in lines) 
            {
                string processedIndices = ""; //숫자로 파싱안되는 부분 표시
                string extractedNumbers = ""; //숫자만 모으기
                
                try
                {
                    content_parsing[i] = int.Parse(line);
                }
                catch (FormatException)
                {
                    foreach (char c in line)
                    {
                        //if(int.TryParse(c.ToString(), out temp))
                        //{

                        //}
                        if (char.IsDigit(c))
                        {
                            processedIndices += c;
                            extractedNumbers += c;
                        }
                        else 
                        {
                            processedIndices += "S";
                        }
                    }
                    if (string.IsNullOrEmpty(extractedNumbers)) extractedNumbers = "-";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("그외 에러가 나타났습니다: \r\n");
                    MessageBox.Show(ex.GetType().Name + "\r\n" + ex.Message);
                }
                finally
                {
                    if (String.IsNullOrEmpty(processedIndices))
                    {
                        textBox_result.Text += $"<{i}>(원본){line}\r\n";
                        textBox_result.Text += $"-> (전부 숫자){content_parsing[i]}\r\n";
                    }
                    else
                    {
                        textBox_result.Text += $"<{i}>(원본){line}\r\n";
                        textBox_result.Text += $"-> ({processedIndices}): {extractedNumbers}\r\n";
                    }
                    i++;
                }
            }
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            //textBox_result.Text = textBox_input.Text;
        }
    }
}
