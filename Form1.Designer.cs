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
            this.SuspendLayout();
            // 
            // ammoCheckBox
            // 
            this.ammoCheckBox.AutoSize = true;
            this.ammoCheckBox.Location = new System.Drawing.Point(77, 70);
            this.ammoCheckBox.Name = "ammoCheckBox";
            this.ammoCheckBox.Size = new System.Drawing.Size(89, 17);
            this.ammoCheckBox.TabIndex = 0;
            this.ammoCheckBox.Text = "Infinite Ammo";
            this.ammoCheckBox.UseVisualStyleBackColor = true;
            // 
            // reserveAmmoCheckBox
            // 
            this.reserveAmmoCheckBox.AutoSize = true;
            this.reserveAmmoCheckBox.Location = new System.Drawing.Point(77, 93);
            this.reserveAmmoCheckBox.Name = "reserveAmmoCheckBox";
            this.reserveAmmoCheckBox.Size = new System.Drawing.Size(132, 17);
            this.reserveAmmoCheckBox.TabIndex = 1;
            this.reserveAmmoCheckBox.Text = "Infinite Reserve Ammo";
            this.reserveAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyCheckBox
            // 
            this.moneyCheckBox.AutoSize = true;
            this.moneyCheckBox.Location = new System.Drawing.Point(77, 116);
            this.moneyCheckBox.Name = "moneyCheckBox";
            this.moneyCheckBox.Size = new System.Drawing.Size(92, 17);
            this.moneyCheckBox.TabIndex = 2;
            this.moneyCheckBox.Text = "Infinite Money";
            this.moneyCheckBox.UseVisualStyleBackColor = true;
            // 
            // grenadesCheckBox
            // 
            this.grenadesCheckBox.AutoSize = true;
            this.grenadesCheckBox.Location = new System.Drawing.Point(77, 139);
            this.grenadesCheckBox.Name = "grenadesCheckBox";
            this.grenadesCheckBox.Size = new System.Drawing.Size(106, 17);
            this.grenadesCheckBox.TabIndex = 3;
            this.grenadesCheckBox.Text = "Infinite Grenades";
            this.grenadesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hpCheckBox
            // 
            this.hpCheckBox.AutoSize = true;
            this.hpCheckBox.Location = new System.Drawing.Point(77, 162);
            this.hpCheckBox.Name = "hpCheckBox";
            this.hpCheckBox.Size = new System.Drawing.Size(75, 17);
            this.hpCheckBox.TabIndex = 4;
            this.hpCheckBox.Text = "Infinite HP";
            this.hpCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Location = new System.Drawing.Point(77, 186);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(84, 17);
            this.eggsCheckBox.TabIndex = 5;
            this.eggsCheckBox.Text = "Infinite Eggs";
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
            this.procIdLabel.Location = new System.Drawing.Point(134, 22);
            this.procIdLabel.Name = "procIdLabel";
            this.procIdLabel.Size = new System.Drawing.Size(14, 13);
            this.procIdLabel.TabIndex = 6;
            this.procIdLabel.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "re5dx9 Process ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Process Open: ";
            // 
            // procOpenLabel
            // 
            this.procOpenLabel.AutoSize = true;
            this.procOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.procOpenLabel.Location = new System.Drawing.Point(111, 45);
            this.procOpenLabel.Name = "procOpenLabel";
            this.procOpenLabel.Size = new System.Drawing.Size(50, 13);
            this.procOpenLabel.TabIndex = 9;
            this.procOpenLabel.Text = "CLOSED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resident Evil 5 Trainer ";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

