namespace ShutdownTimer
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
            this.checkForce = new System.Windows.Forms.CheckBox();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.shutdownNowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkForce
            // 
            this.checkForce.AutoSize = true;
            this.checkForce.Location = new System.Drawing.Point(139, 65);
            this.checkForce.Name = "checkForce";
            this.checkForce.Size = new System.Drawing.Size(53, 17);
            this.checkForce.TabIndex = 0;
            this.checkForce.Text = "Force";
            this.checkForce.UseVisualStyleBackColor = true;
            // 
            // shutdownButton
            // 
            this.shutdownButton.Location = new System.Drawing.Point(142, 10);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(75, 23);
            this.shutdownButton.TabIndex = 1;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseVisualStyleBackColor = true;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // secondBox
            // 
            this.secondBox.Location = new System.Drawing.Point(12, 12);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(100, 20);
            this.secondBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(254, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel Shutdown";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(12, 38);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(100, 20);
            this.minuteBox.TabIndex = 2;
            // 
            // shutdownNowButton
            // 
            this.shutdownNowButton.Location = new System.Drawing.Point(142, 35);
            this.shutdownNowButton.Name = "shutdownNowButton";
            this.shutdownNowButton.Size = new System.Drawing.Size(124, 23);
            this.shutdownNowButton.TabIndex = 1;
            this.shutdownNowButton.Text = "Shutdown now";
            this.shutdownNowButton.UseVisualStyleBackColor = true;
            this.shutdownNowButton.Click += new System.EventHandler(this.shutdownNowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(13, 65);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(100, 20);
            this.hourBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Red;
            this.stateLabel.Location = new System.Drawing.Point(54, 95);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(43, 13);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "Waiting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.shutdownNowButton);
            this.Controls.Add(this.shutdownButton);
            this.Controls.Add(this.checkForce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 188);
            this.MinimumSize = new System.Drawing.Size(294, 188);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Shutdown Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkForce;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Button shutdownNowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stateLabel;
    }
}

