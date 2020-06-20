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
        private Mem memLib = new Mem();
        private int processID;
        private bool processOpen = false;

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
                //================================================================================
                // GENERAL
                //================================================================================

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

                //Infinite Proximity Bombs
                if (proxyBombCheckBox.Checked)
                {
                    memLib.WriteMemory("base+3EBC3E", "byte", "EB");
                }
                else
                {
                    memLib.WriteMemory("base+3EBC3E", "byte", "75");
                }

                //Freeze Money
                if (moneyCheckBox.Checked)
                {
                    memLib.WriteMemory("base+8EDF19", "bytes", "90 90");
                }
                else
                {
                    memLib.WriteMemory("base+8EDF19", "bytes", "29 D0");
                }

                //================================================================================
                // MERCENARY GAME MODE
                //================================================================================

                //Freeze Combo Timer
                if (comboTimerCheckBox.Checked)
                {
                    memLib.WriteMemory("base+321A31", "bytes", "90 90 90 90 90 90 90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+321A31", "bytes", "F3 0F 11 84 31 A0 06 00 00");
                }

                //Freeze Countdown Timer
                if (countDownCheckBox.Checked)
                {
                    memLib.WriteMemory("base+31CCBF", "bytes", "90 90 90 90 90 90 90 90");
                }
                else
                {
                    memLib.WriteMemory("base+31CCBF", "bytes", "F3 0F 11 87 DC 04 00 00");
                }
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void saveMoneyButton_Click(object sender, EventArgs e)
        {
            if(moneyTextBox.Text != "")
            {
                memLib.WriteMemory("base+00DA23D8,1c0", "int", moneyTextBox.Text);
            }
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if(scoreTextBox.Text != "")
            {
                memLib.WriteMemory("1EBDD504", "int", scoreTextBox.Text);
                memLib.WriteMemory("1EBED504", "int", scoreTextBox.Text);
            }
        }
    }
}
