﻿using System;
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
using DesktopWPFAppLowLevelKeyboardHook;
using Memory; //Memory.dll 

namespace RE5_Trainer
{
    public partial class Form1 : Form
    {
        private LowLevelKeyboardListener _listener;
        private Mem memLib = new Mem();

        private int processID;
        private bool processOpen = false;

        private bool validNumber = false;
        private int temporaryNumb = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(31, 24, 24);
            
            //Starts backgroundworker if not busy
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync(); 
            }

            //Setup keypress listener (so that the app can detect hotkeys when not in focus)
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.UnHookKeyboard();
            _listener.HookKeyboard();

            //Associates the event handler with the FormClosing Event
            this.FormClosing += Form1_FormClosing;
        }

        //Listens for key-press-events when app is not in focus with the help of the class "LowLevelKeyboardListener".
        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            switch (e.KeyPressed.ToString())
            {
                case "F1": hpCheckBox.Checked = !hpCheckBox.Checked; 
                    break;
                case "F2": ammoCheckBox.Checked = !ammoCheckBox.Checked;
                    break;
                case "F3": grenadesCheckBox.Checked = !grenadesCheckBox.Checked;
                    break;
                case "F4": moneyCheckBox.Checked = !moneyCheckBox.Checked;
                    break;
                case "F5": comboTimerCheckBox.Checked = !comboTimerCheckBox.Checked;
                    break;
                case "F6": countDownCheckBox.Checked = !countDownCheckBox.Checked;
                    break;
                case "F7": reserveAmmoCheckBox.Checked = !reserveAmmoCheckBox.Checked;
                    break;
                case "F8": proxyBombCheckBox.Checked = !proxyBombCheckBox.Checked;
                    break;
                case "F9": eggsCheckBox.Checked = !eggsCheckBox.Checked;
                    break;
                default:
                    break;
            }
        }

        //Runs before the application is closed
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _listener.UnHookKeyboard();
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

        //Locates PID
        private void findProcessID()
        {
            processID = memLib.GetProcIdFromName("re5dx9"); //Gets process ID
            processOpen = memLib.OpenProcess(processID);

            if (processID > 0)
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = processID.ToString();
                    procIdLabel.ForeColor = Color.Lime;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate{
                    gameProcessNameLabel.Text = "re5dx9.exe";
                    gameProcessNameLabel.ForeColor = Color.Lime;
                });
            }
            else
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = "Process ID Not Found";
                    procIdLabel.ForeColor = Color.Red;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate {
                    gameProcessNameLabel.Text = "N/A";
                    gameProcessNameLabel.ForeColor = Color.Red;
                });
            }

            if (processOpen)
            {

                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "GAME FOUND";
                    procOpenLabel.ForeColor = Color.Lime;
                });

            }
            else
            {
                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "N/A";
                    procOpenLabel.ForeColor = Color.Red;
                });
            }
        }

        //Hex code written constantly to the game's memory region
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) 
        {
            if (processOpen)
            {
                //================================================================================
                // GENERAL
                //================================================================================

                // Infinite Ammo
                try
                {
                    if (ammoCheckBox.Checked) 
                    {
                        memLib.WriteMemory("base+84B8FB", "bytes", "90 90 90 90");
                    }
                    else
                    {
                        memLib.WriteMemory("base+84B8FB", "bytes", "2B 44 24 08");
                    }
                }
                catch (NullReferenceException eee)
                {
                    Application.Exit();
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
                    memLib.WriteMemory("base+00DA23D8,1c0", "int", "999999");
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

        //Writes a specific amount of money to the memory
        private void saveMoneyButton_Click(object sender, EventArgs e)
        {
            validNumber = int.TryParse(moneyTextBox.Text, out temporaryNumb);

            if(validNumber)
            {
                memLib.WriteMemory("base+00DA23D8,1c0", "int", moneyTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Writes a specific amount of score (in mercanary game mode) to the memory
        private void scoreButton_Click(object sender, EventArgs e)
        {
            validNumber = int.TryParse(scoreTextBox.Text, out temporaryNumb);

            if(validNumber && temporaryNumb <= 999999)
            {
                memLib.WriteMemory("base+E243A8,1042C,6B4", "int", scoreTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                saveMoneyButton_Click(sender, e);
            }
        }

        private void scoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                scoreButton_Click(sender, e);
            }
        }
    }
}
