namespace CCDI2_HMI_App
{
    partial class ValveControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValveControl));
            this.ValveNumber = new System.Windows.Forms.Label();
            this.TurnValveOnLabel = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.ValveOff = new System.Windows.Forms.Button();
            this.ValveOn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ValveNumber
            // 
            this.ValveNumber.AutoSize = true;
            this.ValveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValveNumber.Location = new System.Drawing.Point(225, 43);
            this.ValveNumber.Name = "ValveNumber";
            this.ValveNumber.Size = new System.Drawing.Size(21, 24);
            this.ValveNumber.TabIndex = 22;
            this.ValveNumber.Text = "#";
            // 
            // TurnValveOnLabel
            // 
            this.TurnValveOnLabel.AutoSize = true;
            this.TurnValveOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnValveOnLabel.Location = new System.Drawing.Point(76, 43);
            this.TurnValveOnLabel.Name = "TurnValveOnLabel";
            this.TurnValveOnLabel.Size = new System.Drawing.Size(143, 24);
            this.TurnValveOnLabel.TabIndex = 21;
            this.TurnValveOnLabel.Text = "Open Valve #:";
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Gray;
            this.StatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusPanel.Location = new System.Drawing.Point(127, 104);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(73, 68);
            this.StatusPanel.TabIndex = 20;
            // 
            // ValveOff
            // 
            this.ValveOff.Location = new System.Drawing.Point(218, 205);
            this.ValveOff.Name = "ValveOff";
            this.ValveOff.Size = new System.Drawing.Size(75, 23);
            this.ValveOff.TabIndex = 19;
            this.ValveOff.Text = "OFF";
            this.ValveOff.UseVisualStyleBackColor = true;
            this.ValveOff.Click += new System.EventHandler(this.ValveOff_Click);
            // 
            // ValveOn
            // 
            this.ValveOn.Location = new System.Drawing.Point(34, 200);
            this.ValveOn.Name = "ValveOn";
            this.ValveOn.Size = new System.Drawing.Size(75, 23);
            this.ValveOn.TabIndex = 18;
            this.ValveOn.Text = "ON";
            this.ValveOn.UseVisualStyleBackColor = true;
            this.ValveOn.Click += new System.EventHandler(this.ValveOn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ValveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(327, 325);
            this.Controls.Add(this.ValveNumber);
            this.Controls.Add(this.TurnValveOnLabel);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.ValveOff);
            this.Controls.Add(this.ValveOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ValveControl";
            this.Text = "Valve Control";
            this.Load += new System.EventHandler(this.ValveControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValveNumber;
        private System.Windows.Forms.Label TurnValveOnLabel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button ValveOff;
        private System.Windows.Forms.Button ValveOn;
        private System.Windows.Forms.Timer timer1;
    }
}