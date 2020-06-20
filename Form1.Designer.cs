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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoCheckBox
            // 
            this.ammoCheckBox.AutoSize = true;
            this.ammoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoCheckBox.Location = new System.Drawing.Point(51, 426);
            this.ammoCheckBox.Name = "ammoCheckBox";
            this.ammoCheckBox.Size = new System.Drawing.Size(126, 24);
            this.ammoCheckBox.TabIndex = 0;
            this.ammoCheckBox.Text = "Infinite Ammo";
            this.ammoCheckBox.UseVisualStyleBackColor = true;
            // 
            // reserveAmmoCheckBox
            // 
            this.reserveAmmoCheckBox.AutoSize = true;
            this.reserveAmmoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveAmmoCheckBox.Location = new System.Drawing.Point(51, 456);
            this.reserveAmmoCheckBox.Name = "reserveAmmoCheckBox";
            this.reserveAmmoCheckBox.Size = new System.Drawing.Size(189, 24);
            this.reserveAmmoCheckBox.TabIndex = 1;
            this.reserveAmmoCheckBox.Text = "Infinite Reserve Ammo";
            this.reserveAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyCheckBox
            // 
            this.moneyCheckBox.AutoSize = true;
            this.moneyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyCheckBox.Location = new System.Drawing.Point(51, 582);
            this.moneyCheckBox.Name = "moneyCheckBox";
            this.moneyCheckBox.Size = new System.Drawing.Size(129, 24);
            this.moneyCheckBox.TabIndex = 2;
            this.moneyCheckBox.Text = "Freeze Money";
            this.moneyCheckBox.UseVisualStyleBackColor = true;
            // 
            // grenadesCheckBox
            // 
            this.grenadesCheckBox.AutoSize = true;
            this.grenadesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grenadesCheckBox.Location = new System.Drawing.Point(51, 486);
            this.grenadesCheckBox.Name = "grenadesCheckBox";
            this.grenadesCheckBox.Size = new System.Drawing.Size(151, 24);
            this.grenadesCheckBox.TabIndex = 3;
            this.grenadesCheckBox.Text = "Infinite Grenades";
            this.grenadesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hpCheckBox
            // 
            this.hpCheckBox.AutoSize = true;
            this.hpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpCheckBox.Location = new System.Drawing.Point(51, 396);
            this.hpCheckBox.Name = "hpCheckBox";
            this.hpCheckBox.Size = new System.Drawing.Size(103, 24);
            this.hpCheckBox.TabIndex = 4;
            this.hpCheckBox.Text = "God mode";
            this.hpCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggsCheckBox.Location = new System.Drawing.Point(51, 546);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(180, 24);
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
            this.procIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIdLabel.Location = new System.Drawing.Point(370, 305);
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
            this.label2.Location = new System.Drawing.Point(239, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "re5dx9 Process ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 324);
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
            this.procOpenLabel.Location = new System.Drawing.Point(370, 325);
            this.procOpenLabel.Name = "procOpenLabel";
            this.procOpenLabel.Size = new System.Drawing.Size(29, 15);
            this.procOpenLabel.TabIndex = 9;
            this.procOpenLabel.Text = "N/A";
            // 
            // proxyBombCheckBox
            // 
            this.proxyBombCheckBox.AutoSize = true;
            this.proxyBombCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyBombCheckBox.Location = new System.Drawing.Point(51, 516);
            this.proxyBombCheckBox.Name = "proxyBombCheckBox";
            this.proxyBombCheckBox.Size = new System.Drawing.Size(196, 24);
            this.proxyBombCheckBox.TabIndex = 10;
            this.proxyBombCheckBox.Text = "Infinite Proximity Bombs";
            this.proxyBombCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyTextBox.Location = new System.Drawing.Point(80, 611);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(100, 26);
            this.moneyTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Money:";
            // 
            // saveMoneyButton
            // 
            this.saveMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMoneyButton.Location = new System.Drawing.Point(186, 610);
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
            this.comboTimerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimerCheckBox.Location = new System.Drawing.Point(301, 396);
            this.comboTimerCheckBox.Name = "comboTimerCheckBox";
            this.comboTimerCheckBox.Size = new System.Drawing.Size(176, 24);
            this.comboTimerCheckBox.TabIndex = 14;
            this.comboTimerCheckBox.Text = "Freeze Combo Timer";
            this.comboTimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // countDownCheckBox
            // 
            this.countDownCheckBox.AutoSize = true;
            this.countDownCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownCheckBox.Location = new System.Drawing.Point(301, 426);
            this.countDownCheckBox.Name = "countDownCheckBox";
            this.countDownCheckBox.Size = new System.Drawing.Size(206, 24);
            this.countDownCheckBox.TabIndex = 15;
            this.countDownCheckBox.Text = "Freeze Countdown Timer";
            this.countDownCheckBox.UseVisualStyleBackColor = true;
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(433, 458);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Score:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(327, 459);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 26);
            this.scoreTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(316, 485);
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
            this.label6.Location = new System.Drawing.Point(45, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "RE5 Trainer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "General";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mercenary Game Mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 657);
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
            this.label10.Location = new System.Drawing.Point(97, 702);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 47);
            this.label10.TabIndex = 26;
            this.label10.Text = "@Puh00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RE5_Trainer.Properties.Resources.resident_evil_5_wallpaper_1920x1200;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RE5_Trainer.Properties.Resources.qgnO7WyT3B;
            this.pictureBox2.Location = new System.Drawing.Point(319, 589);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RE5_Trainer.Properties.Resources.box_small;
            this.pictureBox3.Location = new System.Drawing.Point(233, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(287, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 763);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.countDownCheckBox);
            this.Controls.Add(this.comboTimerCheckBox);
            this.Controls.Add(this.saveMoneyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.proxyBombCheckBox);
            this.Controls.Add(this.procOpenLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procIdLabel);
            this.Controls.Add(this.eggsCheckBox);
            this.Controls.Add(this.hpCheckBox);
            this.Controls.Add(this.grenadesCheckBox);
            this.Controls.Add(this.moneyCheckBox);
            this.Controls.Add(this.reserveAmmoCheckBox);
            this.Controls.Add(this.ammoCheckBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Resident Evil 5 V1.0.0.129 Trainer by @Puh00";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

