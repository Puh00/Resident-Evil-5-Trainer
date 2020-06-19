using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory; //Memory.dll 

namespace RE5_Trainer
{
    public partial class Form1 : Form
    {

        new Mem memory = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pid = memory.GetProcIdFromName("re5dx9");
            bool openProc = false;

            if(pid > 0)
            {
                memory.OpenProcess(pid);

            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
    }
}
