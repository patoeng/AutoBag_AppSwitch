namespace ApplicationSwitch
{
    partial class FormApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.btnAutoBag = new System.Windows.Forms.Button();
            this.btnPOPC = new System.Windows.Forms.Button();
            this.btnWiringLabel = new System.Windows.Forms.Button();
            this.btnClearSetting = new System.Windows.Forms.Button();
            this.btnLoadSetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnAutoBag
            // 
            this.btnAutoBag.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoBag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBag.Image = global::ApplicationSwitch.Properties.Resources.Screenshot_112_8X8;
            this.btnAutoBag.Location = new System.Drawing.Point(328, -2);
            this.btnAutoBag.Name = "btnAutoBag";
            this.btnAutoBag.Size = new System.Drawing.Size(143, 110);
            this.btnAutoBag.TabIndex = 2;
            this.btnAutoBag.Text = "&AUTOBAG";
            this.btnAutoBag.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAutoBag.UseVisualStyleBackColor = false;
            this.btnAutoBag.Click += new System.EventHandler(this.btnAutoBag_Click);
            // 
            // btnPOPC
            // 
            this.btnPOPC.BackColor = System.Drawing.SystemColors.Control;
            this.btnPOPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOPC.Image = global::ApplicationSwitch.Properties.Resources.Screenshot_1_20X20;
            this.btnPOPC.Location = new System.Drawing.Point(-2, -2);
            this.btnPOPC.Name = "btnPOPC";
            this.btnPOPC.Size = new System.Drawing.Size(159, 110);
            this.btnPOPC.TabIndex = 1;
            this.btnPOPC.Text = "&PO PC";
            this.btnPOPC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPOPC.UseVisualStyleBackColor = false;
            this.btnPOPC.Click += new System.EventHandler(this.btnPOPC_Click);
            // 
            // btnWiringLabel
            // 
            this.btnWiringLabel.BackColor = System.Drawing.SystemColors.Control;
            this.btnWiringLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWiringLabel.Image = global::ApplicationSwitch.Properties.Resources.Screenshot_5_10x10;
            this.btnWiringLabel.Location = new System.Drawing.Point(163, -2);
            this.btnWiringLabel.Name = "btnWiringLabel";
            this.btnWiringLabel.Size = new System.Drawing.Size(159, 110);
            this.btnWiringLabel.TabIndex = 0;
            this.btnWiringLabel.Text = "&WIRING LABEL";
            this.btnWiringLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnWiringLabel.UseVisualStyleBackColor = false;
            this.btnWiringLabel.Click += new System.EventHandler(this.btnWiringLabel_Click);
            // 
            // btnClearSetting
            // 
            this.btnClearSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSetting.Location = new System.Drawing.Point(477, 70);
            this.btnClearSetting.Name = "btnClearSetting";
            this.btnClearSetting.Size = new System.Drawing.Size(54, 38);
            this.btnClearSetting.TabIndex = 3;
            this.btnClearSetting.Text = "&Clear Setting";
            this.btnClearSetting.UseVisualStyleBackColor = false;
            this.btnClearSetting.Click += new System.EventHandler(this.btnClearSetting_Click);
            // 
            // btnLoadSetting
            // 
            this.btnLoadSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSetting.Location = new System.Drawing.Point(477, 32);
            this.btnLoadSetting.Name = "btnLoadSetting";
            this.btnLoadSetting.Size = new System.Drawing.Size(54, 36);
            this.btnLoadSetting.TabIndex = 4;
            this.btnLoadSetting.Text = "&Load Setting";
            this.btnLoadSetting.UseVisualStyleBackColor = false;
            this.btnLoadSetting.Click += new System.EventHandler(this.btnLoadSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(477, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 22);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.BalloonTipText = "Application Switch";
            this.myNotifyIcon.BalloonTipTitle = "Application Switch";
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "notifyIcon1";
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.Click += new System.EventHandler(this.myNotifyIcon_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(534, 108);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadSetting);
            this.Controls.Add(this.btnClearSetting);
            this.Controls.Add(this.btnAutoBag);
            this.Controls.Add(this.btnPOPC);
            this.Controls.Add(this.btnWiringLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApp";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Application Switch";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormApp_FormClosing);
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.SizeChanged += new System.EventHandler(this.FormApp_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWiringLabel;
        private System.Windows.Forms.Button btnPOPC;
        private System.Windows.Forms.Button btnAutoBag;
        private System.Windows.Forms.Button btnClearSetting;
        private System.Windows.Forms.Button btnLoadSetting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
    }
}

