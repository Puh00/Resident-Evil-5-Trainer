using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory; //Memory.dll 

namespace RE5_Trainer
{
    public partial class Form1 : Form
    {
        public Mem memLib = new Mem();
        public int processID;
        public bool processOpen = false;

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
            findProcessID();

            if (!processOpen)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            backgroundWorker.ReportProgress(0);
            
        }
        private void findProcessID()
        {
            processID = memLib.GetProcIdFromName("re5dx9"); //Gets process ID

            if (processID > 0)
            {
                processOpen = memLib.OpenProcess(processID);

                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = processID.ToString();
                });
            }
            else
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = "Process ID Not Found";
                    procIdLabel.ForeColor = Color.Red;
                });
            }

            if (processOpen)
            {
                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "OPEN";
                    procOpenLabel.ForeColor = Color.Green;
                });

            }
            else
            {
                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "CLOSED";
                    procOpenLabel.ForeColor = Color.Red;
                });
            }
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) //Put values that needs to be frozen here
        {
            if (processOpen)
            {
                // Infinite Ammo
                if (ammoCheckBox.Checked) 
                {
                    memLib.WriteMemory("base+84B8FB", "bytes", "90 90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+84B8FB", "bytes", "2B 44 24 08");
                }

                // Freeze Reserve Ammo
                if (reserveAmmoCheckBox.Checked)
                {
                    memLib.WriteMemory("base+84D3DB", "bytes", "90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+84D3DB", "bytes", "29 6E 08");
                }

                //Freeze Grenades
                if (grenadesCheckBox.Checked)
                {
                    memLib.WriteMemory("base+3EC402", "byte", "EB");
                }
                else
                {
                    memLib.WriteMemory("base+3EC402", "byte", "75");
                }

                //God mode
                if (hpCheckBox.Checked)
                {
                    memLib.WriteMemory("base+77CB40", "bytes", "90 90 90 90 90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+77CB40", "bytes", "66 29 8E 64 13 00 00");
                }

                //Ovo-lacto-vegetarian diet
                if (eggsCheckBox.Checked)
                {
                    memLib.WriteMemory("base+3EB64B", "bytes", "90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+3EB64B", "bytes", "89 71 08");
                }
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }
    }
}
