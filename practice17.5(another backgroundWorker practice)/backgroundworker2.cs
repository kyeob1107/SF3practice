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
using System.Threading;

namespace practice17._5_another_backgroundWorker_practice_
{
    public partial class backgroundworker2 : Form
    {
        string filePath;
        string fileExtention;
        string[] files;
        BackgroundWorker worker;
        public backgroundworker2()
        {
            InitializeComponent();
            
            // BackgroundWorker 초기 세팅

            // BackgroundWorker의 객체 생성
            this.worker = new BackgroundWorker();
            // BackgroundWorker의 ReportProgress() 메소드 활용 여부, 보통 true
            this.worker.WorkerReportsProgress = true;
            // CancelAsync()로 BackgroundWorker를 멈출 수 있게 할지, 보통 true, 우리쪽에선 딱히 안 사용
            this.worker.WorkerSupportsCancellation = true;

            // BackgroundWokrer가 UI스레드와 별개로 수행할 메소드 - 검색 및 추가하는 메소드를 비동기로 이용
            this.worker.DoWork += new DoWorkEventHandler(SearchDisplayFile);
            //e 라는 거 이용해서 인자 입력받는 방법 있다고 하는데 하는 법 찾아보기
            // ReportProgress()메소드가 수행될때 메소드
            //this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_progressChanged);
            // ReportProgress()가 100으로 호출되면 마지막에 한 번 실행되는 메소드
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_complete);

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            filePath = textBox_input.Text;
            fileExtention = textBox_extension.Text;
            listBox_files.Items.Clear();
            
            //worker가 실행중일 경우 또 실행되지 않도록 방지하여 실행
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }

        private void SearchDisplayFile(object sender, EventArgs e)
        {
            try
            { 
                // 파일경로와 확장자명을 textBox를 통해 입력받은 값 사용, 하위 디렉토리까지 검색
                files = Directory.GetFiles(filePath, $"*.{fileExtention}", SearchOption.AllDirectories);
                
                // 검색 결과를 listBox에 추가
                foreach (string file in files)
                {
                    listBox_files.Items.Add(Path.GetFileName(file));
                }
            }
            catch { }
        }

        void Worker_complete(object sender, EventArgs e)
        {
            MessageBox.Show("Complete");
        }
    }
}
