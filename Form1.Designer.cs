namespace RE5_Trainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ammoCheckBox = new System.Windows.Forms.CheckBox();
            this.reserveAmmoCheckBox = new System.Windows.Forms.CheckBox();
            this.moneyCheckBox = new System.Windows.Forms.CheckBox();
            this.grenadesCheckBox = new System.Windows.Forms.CheckBox();
            this.hpCheckBox = new System.Windows.Forms.CheckBox();
            this.eggsCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.procIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.procOpenLabel = new System.Windows.Forms.Label();
            this.proxyBombCheckBox = new System.Windows.Forms.CheckBox();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveMoneyButton = new System.Windows.Forms.Button();
            this.comboTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.countDownCheckBox = new System.Windows.Forms.CheckBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.gameProcessNameLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoCheckBox
            // 
            this.ammoCheckBox.AutoSize = true;
            this.ammoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoCheckBox.ForeColor = System.Drawing.Color.White;
            this.ammoCheckBox.Location = new System.Drawing.Point(706, 123);
            this.ammoCheckBox.Name = "ammoCheckBox";
            this.ammoCheckBox.Size = new System.Drawing.Size(139, 24);
            this.ammoCheckBox.TabIndex = 0;
            this.ammoCheckBox.Text = "Infinite Ammo";
            this.ammoCheckBox.UseVisualStyleBackColor = true;
            // 
            // reserveAmmoCheckBox
            // 
            this.reserveAmmoCheckBox.AutoSize = true;
            this.reserveAmmoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveAmmoCheckBox.ForeColor = System.Drawing.Color.White;
            this.reserveAmmoCheckBox.Location = new System.Drawing.Point(243, 28);
            this.reserveAmmoCheckBox.Name = "reserveAmmoCheckBox";
            this.reserveAmmoCheckBox.Size = new System.Drawing.Size(210, 24);
            this.reserveAmmoCheckBox.TabIndex = 1;
            this.reserveAmmoCheckBox.Text = "Infinite Reserve Ammo";
            this.reserveAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyCheckBox
            // 
            this.moneyCheckBox.AutoSize = true;
            this.moneyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyCheckBox.ForeColor = System.Drawing.Color.White;
            this.moneyCheckBox.Location = new System.Drawing.Point(243, 120);
            this.moneyCheckBox.Name = "moneyCheckBox";
            this.moneyCheckBox.Size = new System.Drawing.Size(141, 24);
            this.moneyCheckBox.TabIndex = 2;
            this.moneyCheckBox.Text = "Freeze Money";
            this.moneyCheckBox.UseVisualStyleBackColor = true;
            // 
            // grenadesCheckBox
            // 
            this.grenadesCheckBox.AutoSize = true;
            this.grenadesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grenadesCheckBox.ForeColor = System.Drawing.Color.White;
            this.grenadesCheckBox.Location = new System.Drawing.Point(243, 94);
            this.grenadesCheckBox.Name = "grenadesCheckBox";
            this.grenadesCheckBox.Size = new System.Drawing.Size(168, 24);
            this.grenadesCheckBox.TabIndex = 3;
            this.grenadesCheckBox.Text = "Infinite Grenades";
            this.grenadesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hpCheckBox
            // 
            this.hpCheckBox.AutoSize = true;
            this.hpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpCheckBox.ForeColor = System.Drawing.Color.White;
            this.hpCheckBox.Location = new System.Drawing.Point(706, 93);
            this.hpCheckBox.Name = "hpCheckBox";
            this.hpCheckBox.Size = new System.Drawing.Size(111, 24);
            this.hpCheckBox.TabIndex = 4;
            this.hpCheckBox.Text = "God mode";
            this.hpCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggsCheckBox.ForeColor = System.Drawing.Color.White;
            this.eggsCheckBox.Location = new System.Drawing.Point(243, 88);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(204, 24);
            this.eggsCheckBox.TabIndex = 5;
            this.eggsCheckBox.Text = "Infinite Eggs ( to eat )";
            this.eggsCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // procIdLabel
            // 
            this.procIdLabel.AutoSize = true;
            this.procIdLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.procIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIdLabel.Location = new System.Drawing.Point(233, 386);
            this.procIdLabel.Name = "procIdLabel";
            this.procIdLabel.Size = new System.Drawing.Size(15, 15);
            this.procIdLabel.TabIndex = 6;
            this.procIdLabel.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Process ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "STATUS: ";
            // 
            // procOpenLabel
            // 
            this.procOpenLabel.AutoSize = true;
            this.procOpenLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.procOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.procOpenLabel.Location = new System.Drawing.Point(232, 409);
            this.procOpenLabel.Name = "procOpenLabel";
            this.procOpenLabel.Size = new System.Drawing.Size(29, 15);
            this.procOpenLabel.TabIndex = 9;
            this.procOpenLabel.Text = "N/A";
            // 
            // proxyBombCheckBox
            // 
            this.proxyBombCheckBox.AutoSize = true;
            this.proxyBombCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyBombCheckBox.ForeColor = System.Drawing.Color.White;
            this.proxyBombCheckBox.Location = new System.Drawing.Point(243, 58);
            this.proxyBombCheckBox.Name = "proxyBombCheckBox";
            this.proxyBombCheckBox.Size = new System.Drawing.Size(220, 24);
            this.proxyBombCheckBox.TabIndex = 10;
            this.proxyBombCheckBox.Text = "Infinite Proximity Bombs";
            this.proxyBombCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyTextBox.Location = new System.Drawing.Point(233, 157);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(131, 26);
            this.moneyTextBox.TabIndex = 11;
            this.moneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Money";
            // 
            // saveMoneyButton
            // 
            this.saveMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMoneyButton.ForeColor = System.Drawing.Color.Black;
            this.saveMoneyButton.Location = new System.Drawing.Point(370, 156);
            this.saveMoneyButton.Name = "saveMoneyButton";
            this.saveMoneyButton.Size = new System.Drawing.Size(86, 28);
            this.saveMoneyButton.TabIndex = 13;
            this.saveMoneyButton.Text = "SAVE";
            this.saveMoneyButton.UseVisualStyleBackColor = true;
            this.saveMoneyButton.Click += new System.EventHandler(this.saveMoneyButton_Click);
            // 
            // comboTimerCheckBox
            // 
            this.comboTimerCheckBox.AutoSize = true;
            this.comboTimerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimerCheckBox.ForeColor = System.Drawing.Color.White;
            this.comboTimerCheckBox.Location = new System.Drawing.Point(243, 40);
            this.comboTimerCheckBox.Name = "comboTimerCheckBox";
            this.comboTimerCheckBox.Size = new System.Drawing.Size(194, 24);
            this.comboTimerCheckBox.TabIndex = 14;
            this.comboTimerCheckBox.Text = "Freeze Combo Timer";
            this.comboTimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // countDownCheckBox
            // 
            this.countDownCheckBox.AutoSize = true;
            this.countDownCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownCheckBox.ForeColor = System.Drawing.Color.White;
            this.countDownCheckBox.Location = new System.Drawing.Point(243, 70);
            this.countDownCheckBox.Name = "countDownCheckBox";
            this.countDownCheckBox.Size = new System.Drawing.Size(228, 24);
            this.countDownCheckBox.TabIndex = 15;
            this.countDownCheckBox.Text = "Freeze Countdown Timer";
            this.countDownCheckBox.UseVisualStyleBackColor = true;
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.Black;
            this.scoreButton.Location = new System.Drawing.Point(378, 123);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(89, 28);
            this.scoreButton.TabIndex = 18;
            this.scoreButton.Text = "SAVE";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Score";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(236, 124);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(136, 26);
            this.scoreTextBox.TabIndex = 16;
            this.scoreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(230, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "*999 999 is the max score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(128, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Resident Evil 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 47);
            this.label9.TabIndex = 25;
            this.label9.Text = "Powered by: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(74, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 47);
            this.label10.TabIndex = 26;
            this.label10.Text = "@Puh00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(454, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "HOTKEYS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(700, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 31);
            this.label12.TabIndex = 30;
            this.label12.Text = "EFFECT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.grenadesCheckBox);
            this.groupBox1.Controls.Add(this.moneyTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.saveMoneyButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(463, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 207);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(42, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "F3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "F2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "F1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboTimerCheckBox);
            this.groupBox2.Controls.Add(this.countDownCheckBox);
            this.groupBox2.Controls.Add(this.scoreTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.scoreButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(463, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 177);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mercenary Game Mode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(42, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "F5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(42, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "F4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.reserveAmmoCheckBox);
            this.groupBox3.Controls.Add(this.proxyBombCheckBox);
            this.groupBox3.Controls.Add(this.eggsCheckBox);
            this.groupBox3.Controls.Add(this.moneyCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(463, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 155);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(42, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 24);
            this.label19.TabIndex = 42;
            this.label19.Text = "F9";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(42, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 24);
            this.label18.TabIndex = 41;
            this.label18.Text = "F8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(42, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 24);
            this.label17.TabIndex = 40;
            this.label17.Text = "F7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(42, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 24);
            this.label16.TabIndex = 39;
            this.label16.Text = "F6";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(84, 366);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 15);
            this.label22.TabIndex = 36;
            this.label22.Text = "Game Process Name:";
            // 
            // gameProcessNameLabel
            // 
            this.gameProcessNameLabel.AutoSize = true;
            this.gameProcessNameLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameProcessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameProcessNameLabel.Location = new System.Drawing.Point(231, 366);
            this.gameProcessNameLabel.Name = "gameProcessNameLabel";
            this.gameProcessNameLabel.Size = new System.Drawing.Size(29, 15);
            this.gameProcessNameLabel.TabIndex = 37;
            this.gameProcessNameLabel.Text = "N/A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(142, 318);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 31);
            this.label20.TabIndex = 38;
            this.label20.Text = "v1.1 Trainer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RE5_Trainer.Properties.Resources.resident_evil_5_wallpaper_1920x1200;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RE5_Trainer.Properties.Resources.box_small;
            this.pictureBox3.Location = new System.Drawing.Point(77, 354);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RE5_Trainer.Properties.Resources.qgnO7WyT3B;
            this.pictureBox2.Location = new System.Drawing.Point(257, 442);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(973, 616);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.gameProcessNameLabel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.procOpenLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procIdLabel);
            this.Controls.Add(this.hpCheckBox);
            this.Controls.Add(this.ammoCheckBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Resident Evil 5 V1.0.0.129 Trainer by @Puh00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ammoCheckBox;
        private System.Windows.Forms.CheckBox reserveAmmoCheckBox;
        private System.Windows.Forms.CheckBox moneyCheckBox;
        private System.Windows.Forms.CheckBox grenadesCheckBox;
        private System.Windows.Forms.CheckBox hpCheckBox;
        private System.Windows.Forms.CheckBox eggsCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label procIdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label procOpenLabel;
        private System.Windows.Forms.CheckBox proxyBombCheckBox;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveMoneyButton;
        private System.Windows.Forms.CheckBox comboTimerCheckBox;
        private System.Windows.Forms.CheckBox countDownCheckBox;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label gameProcessNameLabel;
        private System.Windows.Forms.Label label20;
    }
}

