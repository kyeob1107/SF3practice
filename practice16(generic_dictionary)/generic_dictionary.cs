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
using System.IO;

namespace practice16_generic_dictionary_
{
    public partial class generic_dictionary : Form
    {
        string filePath;
        IDictionary<string, string> loginInfo;
        IDictionary<string, string> userInfo;
        public generic_dictionary()
        {
            InitializeComponent();

        }

        private void button_open_Click(object sender, EventArgs e)
        {
            filePath = OpenFileDialog_action();
            ReadFile(filePath, out loginInfo, out userInfo);

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // 데이터 똑바로 들어갔나 확인용
            //foreach(KeyValuePair<string, string> user in userInfo) //var로 해도 되는듯
            //{
            //    MessageBox.Show($"{user.Key}: {user.Value}");
            //}
            string input_id;
            string input_pw;
            input_id = textBox_input_id.Text;
            input_pw = textBox_input_pw.Text;

            if (loginInfo.TryGetValue(input_id, out string value_pw))
            {
                if (input_pw == value_pw)
                {
                    string messageText = $"{input_id}님 환영합니다\r\n";
                    //MessageBox.Show(userInfo[input_id].Length.ToString());
                    messageText += $"({TransPhoneNumber(userInfo[input_id])})";
                    MessageBox.Show(messageText);
                }
                else MessageBox.Show("비밀번호가 틀렸습니다");
            }
            else MessageBox.Show("아이디가 존재하지 않습니다");

        }

        string OpenFileDialog_action()
        {
            string selectedFilePath = "";
            try
            {
                //인스턴스 생성
                OpenFileDialog ofd = new OpenFileDialog();

                // 사용할 필터(확장자) 설정
                List<string> filterList = new List<string>
                {
                    "Text Files (*.txt)|*.txt;",
                    "|CSV Files (*.csv)|*.csv;",
                    "|All Files (*.*)|*.*;"
                };

                // 필터(확장자 적용)
                foreach (string filter in filterList)
                { ofd.Filter += filter; }

                // 또는 아래와 같이 한꺼번에 Supported Image File로 표시할 수 있다.
                //ofd.Filter = "Supported Image File|*jpg;*.jpeg;*.bmp;*.png;*.dib;*.gif;*.tif;";

                ofd.AddExtension = false;                    // 확장자 자동 추가
                ofd.CheckFileExists = true;                  // 파일 존재하지 않을 경우 메시지 표시 여부
                ofd.CheckPathExists = true;                  // 경로 존재하지 않을 경우 메시지 표시 여부    
                ofd.Multiselect = false;                     // 복수 선택

                ofd.ShowHelp = true;                         // Help 버튼 표시 여부
                ofd.ShowReadOnly = false;                    // 읽기 전용 체크박스 표시 여부
                ofd.ReadOnlyChecked = false;                 // 읽기 전용항목 체크 여부
                ofd.SupportMultiDottedExtensions = true;     // 여러개의 확장자를 표시하는지 여부(저장시 또한)
                ofd.Title = "Select an file...";            // 타이틀 표시
                ofd.ValidateNames = true;                    // 파일명의 유효성 검증

                //초기 디렉터리 -> 기본 바탕화면으로 설정, 선택가능하도록해줬음
                //함수화시켜주고 싶음
                string selectDefaultPath = comboBox_default_path.Text;
                switch (selectDefaultPath)
                {
                    case "바탕화면":
                        ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                        break;
                    case "문서":
                        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        break;
                    case "프로젝트실행경로":
                        ofd.InitialDirectory = @"";
                        break;
                    //case "마지막 사용한 경로":
                    //    break;
                    default:
                        ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                        break;
                }
                


                if (ofd.ShowDialog() == DialogResult.OK)    // 다이얼로그 표시
                {
                    //Do Something
                    selectedFilePath = ofd.FileName; // 선택된 파일 경로 사용
                    //string selectedFileName = ofd.SafeFileName; // 선택된 파일 이름 사용
                }

                ofd.Dispose(); // OpenFileDialog 리소스 해제
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Sample");
            }

            return selectedFilePath;
        }

        void ReadFile(string filePath, 
            out IDictionary<string, string> loginInfo, out IDictionary<string, string> userInfo)
        {
            loginInfo = new Dictionary<string, string>();
            userInfo = new Dictionary<string, string>();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Trim(' ', '\r', '\n').Split(',');
                        loginInfo.Add(data[0], data[1]);
                        if (data.Length > 2) userInfo.Add(data[0], data[2]);
                        else userInfo.Add(data[0], null);
                        //userInfo.Add(data[0], string.IsNullOrEmpty(data[2]) ? null: data[2]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        
        // 전화번호 길이별 출력
        string TransPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return "전화번호 정보 없음";
            }
            else
            {
                switch (phoneNumber.Length)
                {
                    case 11:
                        //return $"{phoneNumber:###-####-####}"; //이건 왜 똑바로 안되지..?
                        return $"{phoneNumber.Substring(0, 3)}" +
                            $"-{phoneNumber.Substring(3, 4)}" +
                            $"-{phoneNumber.Substring(7)}";
                    case 10:
                        return $"{phoneNumber.Substring(0, 3)}" +
                            $"-{phoneNumber.Substring(3, 3)}" +
                            $"-{phoneNumber.Substring(6)}";
                    case 8:
                        return $"{phoneNumber.Substring(0, 4)}-{phoneNumber.Substring(4)}";
                    case 7:
                        return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3)}";
                    default:
                        return phoneNumber; // 기타 길이는 그대로 반환
                }
            }

        }
    }
}
