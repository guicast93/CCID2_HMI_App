namespace CCDI2_HMI_App
{
    partial class PumpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PumpControl));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PumpOn = new System.Windows.Forms.Button();
            this.PumpOff = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.TurnPumpOnLabel = new System.Windows.Forms.Label();
            this.PumpNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PumpOn
            // 
            this.PumpOn.Location = new System.Drawing.Point(33, 200);
            this.PumpOn.Name = "PumpOn";
            this.PumpOn.Size = new System.Drawing.Size(75, 23);
            this.PumpOn.TabIndex = 1;
            this.PumpOn.Text = "ON";
            this.PumpOn.UseVisualStyleBackColor = true;
            this.PumpOn.Click += new System.EventHandler(this.PumpOn_Click);
            // 
            // PumpOff
            // 
            this.PumpOff.Location = new System.Drawing.Point(217, 205);
            this.PumpOff.Name = "PumpOff";
            this.PumpOff.Size = new System.Drawing.Size(75, 23);
            this.PumpOff.TabIndex = 2;
            this.PumpOff.Text = "OFF";
            this.PumpOff.UseVisualStyleBackColor = true;
            this.PumpOff.Click += new System.EventHandler(this.PumpOff_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Gray;
            this.StatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusPanel.Location = new System.Drawing.Point(126, 104);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(73, 68);
            this.StatusPanel.TabIndex = 15;
            // 
            // TurnPumpOnLabel
            // 
            this.TurnPumpOnLabel.AutoSize = true;
            this.TurnPumpOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnPumpOnLabel.Location = new System.Drawing.Point(47, 43);
            this.TurnPumpOnLabel.Name = "TurnPumpOnLabel";
            this.TurnPumpOnLabel.Size = new System.Drawing.Size(171, 24);
            this.TurnPumpOnLabel.TabIndex = 16;
            this.TurnPumpOnLabel.Text = "Turn On Pump #:";
            // 
            // PumpNumber
            // 
            this.PumpNumber.AutoSize = true;
            this.PumpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PumpNumber.Location = new System.Drawing.Point(224, 43);
            this.PumpNumber.Name = "PumpNumber";
            this.PumpNumber.Size = new System.Drawing.Size(21, 24);
            this.PumpNumber.TabIndex = 17;
            this.PumpNumber.Text = "#";
            // 
            // PumpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(327, 325);
            this.Controls.Add(this.PumpNumber);
            this.Controls.Add(this.TurnPumpOnLabel);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.PumpOff);
            this.Controls.Add(this.PumpOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PumpControl";
            this.Text = "Pump Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PumpOn;
        private System.Windows.Forms.Button PumpOff;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label TurnPumpOnLabel;
        private System.Windows.Forms.Label PumpNumber;
    }
}

