using NAudio.Wave;
using NAudio.Lame;

namespace EveningLearningCaretaker
{
    public partial class Form1 : Form
    {
        private static WaveInEvent _waveIn;
        private const int SampleRate = 44100;
        private const int BitsPerSample = 16;
        private const int Channels = 1;
        private const float ReferenceValue = 32767f;
        private const float MinDecibel = -70f;

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
            double rms = Math.Sqrt(samples.Average(s => Math.Pow(s, 2)));
            float decibel = rms > 0 ? (float)(20 * Math.Log10(rms / ReferenceValue)) : MinDecibel;
            decibel = Math.Max(decibel, MinDecibel); 
            int positiveDecibel = (int)Math.Round(decibel - MinDecibel);
            label3.Text = positiveDecibel.ToString() + "db";
            if (positiveDecibel >= 50) {
                using (var mp3Reader = new Mp3FileReader(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)+"sound1.mp3"))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(mp3Reader);
                    outputDevice.Play();
                }
            }
            
            
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
