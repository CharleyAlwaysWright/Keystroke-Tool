namespace Keystroke_Tool_V2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StartDelayLabel = new System.Windows.Forms.Label();
            this.StartDelayField = new System.Windows.Forms.TextBox();
            this.CmdDelayField = new System.Windows.Forms.TextBox();
            this.CmdDelayLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditorBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartDelayLabel
            // 
            this.StartDelayLabel.AutoSize = true;
            this.StartDelayLabel.Location = new System.Drawing.Point(4, 4);
            this.StartDelayLabel.Name = "StartDelayLabel";
            this.StartDelayLabel.Size = new System.Drawing.Size(81, 13);
            this.StartDelayLabel.TabIndex = 0;
            this.StartDelayLabel.Text = "Start Delay (ms)";
            // 
            // StartDelayField
            // 
            this.StartDelayField.Location = new System.Drawing.Point(7, 20);
            this.StartDelayField.Name = "StartDelayField";
            this.StartDelayField.Size = new System.Drawing.Size(100, 20);
            this.StartDelayField.TabIndex = 1;
            // 
            // CmdDelayField
            // 
            this.CmdDelayField.Location = new System.Drawing.Point(126, 20);
            this.CmdDelayField.Name = "CmdDelayField";
            this.CmdDelayField.Size = new System.Drawing.Size(100, 20);
            this.CmdDelayField.TabIndex = 3;
            // 
            // CmdDelayLabel
            // 
            this.CmdDelayLabel.AutoSize = true;
            this.CmdDelayLabel.Location = new System.Drawing.Point(123, 4);
            this.CmdDelayLabel.Name = "CmdDelayLabel";
            this.CmdDelayLabel.Size = new System.Drawing.Size(80, 13);
            this.CmdDelayLabel.TabIndex = 2;
            this.CmdDelayLabel.Text = "Cmd Delay (ms)";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(238, 5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 31);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(7, 46);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(67, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(80, 46);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(67, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // EditorBtn
            // 
            this.EditorBtn.Location = new System.Drawing.Point(153, 46);
            this.EditorBtn.Name = "EditorBtn";
            this.EditorBtn.Size = new System.Drawing.Size(73, 23);
            this.EditorBtn.TabIndex = 7;
            this.EditorBtn.Text = "Editor";
            this.EditorBtn.UseVisualStyleBackColor = true;
            this.EditorBtn.Click += new System.EventHandler(this.EditorBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(238, 41);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 31);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(6, 72);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(79, 13);
            this.OutputLabel.TabIndex = 10;
            this.OutputLabel.Text = "No File Loaded";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(324, 91);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.EditorBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CmdDelayField);
            this.Controls.Add(this.CmdDelayLabel);
            this.Controls.Add(this.StartDelayField);
            this.Controls.Add(this.StartDelayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Keystroke Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDelayLabel;
        private System.Windows.Forms.TextBox StartDelayField;
        private System.Windows.Forms.TextBox CmdDelayField;
        private System.Windows.Forms.Label CmdDelayLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditorBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputLabel;
    }
}

