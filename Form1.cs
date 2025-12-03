using NAudio.Wave;

namespace EveningLearningCaretaker
{
    public partial class Form1 : Form
    {
        private static WaveInEvent _waveIn;
        private const int SampleRate = 44100;
        private const int BitsPerSample = 16;
        private const int Channels = 1;
        private const float ReferenceValue = 32767f;
        private const float MinDecibel = -60f; // 最小负分贝（仍保持-60dB，确保灵敏度）
        private const int TargetMaxDecibel = 120; // 目标最大正整数分贝
        private const int OriginalMaxRange = 60; // 原始正整数最大范围（0 - MinDecibel = 60）
        private const float ScaleFactor = TargetMaxDecibel / (float)OriginalMaxRange; // 缩放系数（120/60=2）

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            StartRecording();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //注意判断关闭事件Reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;    //取消"关闭窗口"事件
                this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
                this.Hide();
                return;
            }
        }
        void StartRecording()
        {
            _waveIn = new WaveInEvent
            {
                WaveFormat = new WaveFormat(SampleRate, BitsPerSample, Channels),
                BufferMilliseconds = 50
            };
            _waveIn.DataAvailable += WaveIn_DataAvailable;
            _waveIn.StartRecording();
        }
        void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            short[] samples = new short[e.BytesRecorded / 2];
            Buffer.BlockCopy(e.Buffer, 0, samples, 0, e.BytesRecorded);

            // 1. 计算原始负分贝（保持不变）
            double rms = Math.Sqrt(samples.Average(s => Math.Pow(s, 2)));
            float decibel = rms > 0 ? (float)(20 * Math.Log10(rms / ReferenceValue)) : MinDecibel;
            decibel = Math.Max(decibel, MinDecibel); // 限制最小为-60dB

            // 2. 核心修改：负分贝 → 0~120正整数（偏移+缩放+取整）
            int positiveDecibel = (int)Math.Round((decibel - MinDecibel) * ScaleFactor);
            label3.Text = positiveDecibel.ToString() + "db";
            if (positiveDecibel > 75) { }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 还原窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new setting().ShowDialog();
        }
    }
}
