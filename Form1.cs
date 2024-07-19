namespace JoeHendryRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCloseTimer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeCloseTimer()
        {
            TimerClose.Enabled = true;
            TimerClose.Interval = 5000;
            TimerClose.Tick += timer1_Tick;
            TimerClose.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerClose.Stop();
            Close();
        }
    }
}
