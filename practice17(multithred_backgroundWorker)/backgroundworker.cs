using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace practice17_multithred_backgroundWorker_
{
    public partial class backgroundworker : Form
    {
        BackgroundWorker worker;
        public backgroundworker()
        {
            InitializeComponent();
            
            //progressBars 초기화
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
            progressBar1.Value = 0;

            // BackgroundWorker 초기 세팅
            
            // BackgroundWorker의 객체 생성
            this.worker = new BackgroundWorker();
            // BackgroundWorker의 ReportProgress() 메소드 활용 여부, 보통 true
            this.worker.WorkerReportsProgress = true;
            // CancelAsync()로 BackgroundWorker를 멈출 수 있게 할지, 보통 true, 우리쪽에선 딱히 안 사용
            this.worker.WorkerSupportsCancellation = true;

            // BackgroundWokrer가 UI스레드와 별개로 수행할 메소드
            this.worker.DoWork += new DoWorkEventHandler(Worker_dowork);
            // ReportProgress()메소드가 수행될때 메소드
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_progressChanged);
            // ReportProgress()가 100으로 호출되면 마지막에 한 번 실행되는 메소드
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_complete);
        }

        void Worker_dowork(object sender, DoWorkEventArgs e) 
        {
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30); //30ms
                this.worker.ReportProgress(i);
            }
        }
        void Worker_progressChanged(object sender, ProgressChangedEventArgs e) 
        {
            // ProgressPercentage는 0~100 사이의 값을 가짐
            progressBar1.Value = e.ProgressPercentage; //위에 적어준 i가 이 e로 전달됨
        }
        void Worker_complete(object sender, EventArgs e) 
        {
            Thread.Sleep(500); //완료창 다그려지고 뜨게 하고 싶어서 딜레이 줘보는 중
            // 보통 프로그램 설치 등 완료창 따로 안뜨는게 일반적인데 가끔 뜨게 해둔 것 보면
            // 완료창 먼저 뜨고 게이지 완전히 찬다고 함
            MessageBox.Show("Complete");
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            

            // 백그라운드워커가 실행중일 때 실행하면 에러가 나기때문에 방지하기 위해서 실행중이냐 확인하는 것으로
            // 실행 중 아닐 때만 실행하도록 설정
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }

            // 그냥 단순 while로 했을 경우
            while (true)
            {
                Thread.Sleep(30); //30ms
                progressBar2.Value += 1;

                if (progressBar2.Value >= 100) break;
            }
        }
    }
}
