using System.Threading;
using System.Windows.Forms;
using System;

namespace Basic_Threading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void StartThreads()
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1.threading);
            Thread ThreadB = new Thread(MyThreadClass.Thread1.threading);

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            MessageBox.Show("Both threads have finished execution."); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartThreads();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}