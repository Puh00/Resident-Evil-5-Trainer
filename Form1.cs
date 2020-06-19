using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory; //Memory.dll 

namespace RE5_Trainer
{
    public partial class Form1 : Form
    {

        new Mem memLib = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int pid = memLib.GetProcIdFromName("re5dx9"); //Gets process ID
            bool openProc = false;

            if (pid > 0)
            {
                openProc = memLib.OpenProcess(pid);


                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = pid.ToString();
                });
            }
            else
            {
                Application.Exit();
            }
            while (true)
            {
                if (openProc)
                {
                    procOpenLabel.Invoke((MethodInvoker)delegate
                    {
                        procOpenLabel.Text = "OPEN";
                        procOpenLabel.ForeColor = Color.Green;
                    });

                    if (ammoCheckBox.Checked)
                    {
                        memLib.WriteMemory("re5dx9.exe+0x84B8F8", "bytes", "E9 03 47 4C 02 66 90");
                    }
                    else
                    {
                        memLib.WriteMemory("re5dx9.exe+0x84B8F8", "bytes", "8B 41 08 2B 44 24 08");
                    }

                }

                Thread.Sleep(1000);
            }
            
        }

        private void ammoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
