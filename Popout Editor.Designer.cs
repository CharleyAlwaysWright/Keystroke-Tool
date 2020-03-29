namespace Keystroke_Tool_V2
{
    partial class Popout_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popout_Editor));
            this.Input = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.FileManagementLabel = new System.Windows.Forms.Label();
            this.InsertLabel = new System.Windows.Forms.Label();
            this.TabBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.KeyboardShotcutLabel = new System.Windows.Forms.Label();
            this.AltBtn = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.ShiftBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.InsertDelayBtn = new System.Windows.Forms.Button();
            this.InstructionsBtn = new System.Windows.Forms.Button();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.InsertDelayButton = new System.Windows.Forms.Button();
            this.StartDelayLabel = new System.Windows.Forms.Label();
            this.ScriptDelayLabel = new System.Windows.Forms.Label();
            this.ScriptDelay = new System.Windows.Forms.TextBox();
            this.StartDelay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(0, 0);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(492, 572);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(498, 25);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(198, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(498, 54);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(198, 23);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            // 
            // FileManagementLabel
            // 
            this.FileManagementLabel.AutoSize = true;
            this.FileManagementLabel.Location = new System.Drawing.Point(498, 9);
            this.FileManagementLabel.Name = "FileManagementLabel";
            this.FileManagementLabel.Size = new System.Drawing.Size(88, 13);
            this.FileManagementLabel.TabIndex = 3;
            this.FileManagementLabel.Text = "File Management";
            // 
            // InsertLabel
            // 
            this.InsertLabel.AutoSize = true;
            this.InsertLabel.Location = new System.Drawing.Point(498, 101);
            this.InsertLabel.Name = "InsertLabel";
            this.InsertLabel.Size = new System.Drawing.Size(33, 13);
            this.InsertLabel.TabIndex = 6;
            this.InsertLabel.Text = "Insert";
            // 
            // TabBtn
            // 
            this.TabBtn.Location = new System.Drawing.Point(498, 146);
            this.TabBtn.Name = "TabBtn";
            this.TabBtn.Size = new System.Drawing.Size(198, 23);
            this.TabBtn.TabIndex = 5;
            this.TabBtn.Text = "Tab";
            this.TabBtn.UseVisualStyleBackColor = true;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(498, 117);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(198, 23);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            // 
            // KeyboardShotcutLabel
            // 
            this.KeyboardShotcutLabel.AutoSize = true;
            this.KeyboardShotcutLabel.Location = new System.Drawing.Point(498, 221);
            this.KeyboardShotcutLabel.Name = "KeyboardShotcutLabel";
            this.KeyboardShotcutLabel.Size = new System.Drawing.Size(95, 13);
            this.KeyboardShotcutLabel.TabIndex = 9;
            this.KeyboardShotcutLabel.Text = "Keyboard Shortcut";
            // 
            // AltBtn
            // 
            this.AltBtn.Location = new System.Drawing.Point(498, 295);
            this.AltBtn.Name = "AltBtn";
            this.AltBtn.Size = new System.Drawing.Size(198, 23);
            this.AltBtn.TabIndex = 8;
            this.AltBtn.Text = "Alt";
            this.AltBtn.UseVisualStyleBackColor = true;
            // 
            // ControlBtn
            // 
            this.ControlBtn.Location = new System.Drawing.Point(498, 237);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(198, 23);
            this.ControlBtn.TabIndex = 7;
            this.ControlBtn.Text = "Control";
            this.ControlBtn.UseVisualStyleBackColor = true;
            // 
            // ShiftBtn
            // 
            this.ShiftBtn.Location = new System.Drawing.Point(498, 266);
            this.ShiftBtn.Name = "ShiftBtn";
            this.ShiftBtn.Size = new System.Drawing.Size(198, 23);
            this.ShiftBtn.TabIndex = 10;
            this.ShiftBtn.Text = "Shift";
            this.ShiftBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(501, 549);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(198, 23);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Save and Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InsertDelayBtn
            // 
            this.InsertDelayBtn.Location = new System.Drawing.Point(498, 175);
            this.InsertDelayBtn.Name = "InsertDelayBtn";
            this.InsertDelayBtn.Size = new System.Drawing.Size(198, 23);
            this.InsertDelayBtn.TabIndex = 13;
            this.InsertDelayBtn.Text = "Delay";
            this.InsertDelayBtn.UseVisualStyleBackColor = true;
            // 
            // InstructionsBtn
            // 
            this.InstructionsBtn.Location = new System.Drawing.Point(501, 520);
            this.InstructionsBtn.Name = "InstructionsBtn";
            this.InstructionsBtn.Size = new System.Drawing.Size(198, 23);
            this.InstructionsBtn.TabIndex = 14;
            this.InstructionsBtn.Text = "Instructions";
            this.InstructionsBtn.UseVisualStyleBackColor = true;
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(498, 338);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(34, 13);
            this.DelayLabel.TabIndex = 17;
            this.DelayLabel.Text = "Delay";
            // 
            // InsertDelayButton
            // 
            this.InsertDelayButton.Location = new System.Drawing.Point(498, 354);
            this.InsertDelayButton.Name = "InsertDelayButton";
            this.InsertDelayButton.Size = new System.Drawing.Size(198, 23);
            this.InsertDelayButton.TabIndex = 15;
            this.InsertDelayButton.Text = "Insert Delay";
            this.InsertDelayButton.UseVisualStyleBackColor = true;
            // 
            // StartDelayLabel
            // 
            this.StartDelayLabel.AutoSize = true;
            this.StartDelayLabel.Location = new System.Drawing.Point(498, 383);
            this.StartDelayLabel.Name = "StartDelayLabel";
            this.StartDelayLabel.Size = new System.Drawing.Size(59, 13);
            this.StartDelayLabel.TabIndex = 18;
            this.StartDelayLabel.Text = "Start Delay";
            // 
            // ScriptDelayLabel
            // 
            this.ScriptDelayLabel.AutoSize = true;
            this.ScriptDelayLabel.Location = new System.Drawing.Point(498, 409);
            this.ScriptDelayLabel.Name = "ScriptDelayLabel";
            this.ScriptDelayLabel.Size = new System.Drawing.Size(64, 13);
            this.ScriptDelayLabel.TabIndex = 19;
            this.ScriptDelayLabel.Text = "Script Delay";
            // 
            // ScriptDelay
            // 
            this.ScriptDelay.Location = new System.Drawing.Point(571, 406);
            this.ScriptDelay.Name = "ScriptDelay";
            this.ScriptDelay.Size = new System.Drawing.Size(125, 20);
            this.ScriptDelay.TabIndex = 20;
            // 
            // StartDelay
            // 
            this.StartDelay.Location = new System.Drawing.Point(571, 380);
            this.StartDelay.Name = "StartDelay";
            this.StartDelay.Size = new System.Drawing.Size(125, 20);
            this.StartDelay.TabIndex = 21;
            // 
            // Popout_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(708, 572);
            this.Controls.Add(this.StartDelay);
            this.Controls.Add(this.ScriptDelay);
            this.Controls.Add(this.ScriptDelayLabel);
            this.Controls.Add(this.StartDelayLabel);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.InsertDelayButton);
            this.Controls.Add(this.InstructionsBtn);
            this.Controls.Add(this.InsertDelayBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ShiftBtn);
            this.Controls.Add(this.KeyboardShotcutLabel);
            this.Controls.Add(this.AltBtn);
            this.Controls.Add(this.ControlBtn);
            this.Controls.Add(this.InsertLabel);
            this.Controls.Add(this.TabBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.FileManagementLabel);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Popout_Editor";
            this.Text = "Popout Editor";
            this.Load += new System.EventHandler(this.Popout_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label FileManagementLabel;
        private System.Windows.Forms.Label InsertLabel;
        private System.Windows.Forms.Button TabBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label KeyboardShotcutLabel;
        private System.Windows.Forms.Button AltBtn;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.Button ShiftBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button InsertDelayBtn;
        private System.Windows.Forms.Button InstructionsBtn;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Button InsertDelayButton;
        private System.Windows.Forms.Label StartDelayLabel;
        private System.Windows.Forms.Label ScriptDelayLabel;
        private System.Windows.Forms.TextBox ScriptDelay;
        private System.Windows.Forms.TextBox StartDelay;
    }
}