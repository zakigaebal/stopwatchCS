using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        //시, 분, 초 변수 선언
        public int minutes = 0;
        public int chos = 0;
        public int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            //Start, Stop, Reset 버튼 클릭 이벤트 선언
            Btn_Start.Click += Btn_Start_Click;
            Btn_Reset.Click += Btn_Reset_Click;
        }
        private void IncreaseSecond()
        {
            //초가 99초 초과면
            if (seconds > 99)
            {
                seconds = 0;
                IncreaseCho();
            }
            else
            {
                seconds++;
            }
        }
        private void IncreaseCho()
        {
            //분이 59분 초과면
            if (chos > 59)
            {
                chos = 0;
            }
            else
            {
                chos++;
            }
        }
        private void IncreaseMinutes()
        {
            //분이 59분 초과면
            if (minutes > 59)
            {
                minutes = 0;
            }
            else
            {
                minutes++;
            }
        }
        public void StopWatch_Tick(object sender, EventArgs e)
        {
            ShowTime();
            IncreaseSecond();
        }
        public void Btn_Start_Click(object sender, EventArgs e)
        {
            if (this.Btn_Start.Text.Equals("시작"))
            {
                this.Btn_Start.Text = "멈춰";
                timer1.Enabled = true;
                timer1.Interval = 1;
                //타이머 Tick 이벤트

                timer1.Tick += StopWatch_Tick;
            }
            else
            {
                this.Btn_Start.Text = "시작";
                timer1.Enabled = false;
            }
        }
        public void Btn_Reset_Click(object sender, EventArgs e)
        {
            //분, 초 초기화
            chos = 0;
            seconds = 0;
            minutes = 0;
            ShowTime();
            if (!timer1.Enabled)
            {
                record.Items.Clear();
            }
        }
        private void ShowTime()
        {
            Lb_cho.Text = chos.ToString("00");
            Lb_Second.Text = seconds.ToString("00");
            Lb_Minutes.Text = minutes.ToString("00");
        }
        private void Btn_Save_MouseDown(object sender, MouseEventArgs e)
        {
            record.Items.Add(this.Lb_Minutes.Text + ":" + this.Lb_cho.Text + "." + this.Lb_Second.Text);
        }
    }
}