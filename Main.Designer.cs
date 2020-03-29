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
            this.TriggerLabel = new System.Windows.Forms.Label();
            this.Trigger = new System.Windows.Forms.TextBox();
            this.TriggerBtn = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.PopOutBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.InsertReturnBtn = new System.Windows.Forms.Button();
            this.InsertTabBtn = new System.Windows.Forms.Button();
            this.InsertKBSCBtn = new System.Windows.Forms.Button();
            this.TabCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.InstructionsBtn = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DelaysLabel = new System.Windows.Forms.Label();
            this.DelaysBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TriggerLabel
            // 
            this.TriggerLabel.AutoSize = true;
            this.TriggerLabel.Location = new System.Drawing.Point(4, 4);
            this.TriggerLabel.Name = "TriggerLabel";
            this.TriggerLabel.Size = new System.Drawing.Size(40, 13);
            this.TriggerLabel.TabIndex = 0;
            this.TriggerLabel.Text = "Trigger";
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(7, 20);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(132, 20);
            this.Trigger.TabIndex = 1;
            // 
            // TriggerBtn
            // 
            this.TriggerBtn.Location = new System.Drawing.Point(145, 20);
            this.TriggerBtn.Name = "TriggerBtn";
            this.TriggerBtn.Size = new System.Drawing.Size(40, 20);
            this.TriggerBtn.TabIndex = 2;
            this.TriggerBtn.Text = "Set";
            this.TriggerBtn.UseVisualStyleBackColor = true;
            this.TriggerBtn.Click += new System.EventHandler(this.TriggerBtn_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(4, 52);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(7, 68);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(290, 150);
            this.Input.TabIndex = 4;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // PopOutBtn
            // 
            this.PopOutBtn.Location = new System.Drawing.Point(7, 231);
            this.PopOutBtn.Name = "PopOutBtn";
            this.PopOutBtn.Size = new System.Drawing.Size(67, 23);
            this.PopOutBtn.TabIndex = 5;
            this.PopOutBtn.Text = "Pop Out";
            this.PopOutBtn.UseVisualStyleBackColor = true;
            this.PopOutBtn.Click += new System.EventHandler(this.PopOutBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(80, 231);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(67, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(157, 231);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(67, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Location = new System.Drawing.Point(308, 52);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(43, 13);
            this.OptionsLabel.TabIndex = 8;
            this.OptionsLabel.Text = "Options";
            // 
            // InsertReturnBtn
            // 
            this.InsertReturnBtn.Location = new System.Drawing.Point(311, 68);
            this.InsertReturnBtn.Name = "InsertReturnBtn";
            this.InsertReturnBtn.Size = new System.Drawing.Size(81, 23);
            this.InsertReturnBtn.TabIndex = 9;
            this.InsertReturnBtn.Text = "Insert Return";
            this.InsertReturnBtn.UseVisualStyleBackColor = true;
            this.InsertReturnBtn.Click += new System.EventHandler(this.InsertReturnBtn_Click);
            // 
            // InsertTabBtn
            // 
            this.InsertTabBtn.Location = new System.Drawing.Point(398, 68);
            this.InsertTabBtn.Name = "InsertTabBtn";
            this.InsertTabBtn.Size = new System.Drawing.Size(81, 23);
            this.InsertTabBtn.TabIndex = 10;
            this.InsertTabBtn.Text = "Insert Tab";
            this.InsertTabBtn.UseVisualStyleBackColor = true;
            this.InsertTabBtn.Click += new System.EventHandler(this.InsertTabBtn_Click);
            // 
            // InsertKBSCBtn
            // 
            this.InsertKBSCBtn.Location = new System.Drawing.Point(311, 97);
            this.InsertKBSCBtn.Name = "InsertKBSCBtn";
            this.InsertKBSCBtn.Size = new System.Drawing.Size(168, 23);
            this.InsertKBSCBtn.TabIndex = 11;
            this.InsertKBSCBtn.Text = "Insert Keyboard Shortcut (+)";
            this.InsertKBSCBtn.UseVisualStyleBackColor = true;
            this.InsertKBSCBtn.Click += new System.EventHandler(this.InsertKBSCBtn_Click);
            // 
            // TabCheckBox
            // 
            this.TabCheckBox.AutoSize = true;
            this.TabCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCheckBox.Location = new System.Drawing.Point(311, 126);
            this.TabCheckBox.Name = "TabCheckBox";
            this.TabCheckBox.Size = new System.Drawing.Size(78, 17);
            this.TabCheckBox.TabIndex = 12;
            this.TabCheckBox.Text = "Tab at end";
            this.TabCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnCheckBox
            // 
            this.ReturnCheckBox.AutoSize = true;
            this.ReturnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnCheckBox.Location = new System.Drawing.Point(398, 126);
            this.ReturnCheckBox.Name = "ReturnCheckBox";
            this.ReturnCheckBox.Size = new System.Drawing.Size(91, 17);
            this.ReturnCheckBox.TabIndex = 13;
            this.ReturnCheckBox.Text = "Return at end";
            this.ReturnCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(308, 155);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 14;
            this.OutputLabel.Text = "Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(311, 171);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(168, 47);
            this.Output.TabIndex = 15;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(400, 224);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(79, 30);
            this.StartBtn.TabIndex = 16;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(230, 231);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(67, 23);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // InstructionsBtn
            // 
            this.InstructionsBtn.Location = new System.Drawing.Point(310, 20);
            this.InstructionsBtn.Name = "InstructionsBtn";
            this.InstructionsBtn.Size = new System.Drawing.Size(74, 20);
            this.InstructionsBtn.TabIndex = 18;
            this.InstructionsBtn.Text = "Instructions";
            this.InstructionsBtn.UseVisualStyleBackColor = true;
            this.InstructionsBtn.Click += new System.EventHandler(this.InstructionsBtn_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(307, 4);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(61, 13);
            this.InstructionsLabel.TabIndex = 19;
            this.InstructionsLabel.Text = "Instructions";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(330, 236);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(38, 13);
            this.VersionLabel.TabIndex = 20;
            this.VersionLabel.Text = "V1.0.0";
            // 
            // DelaysLabel
            // 
            this.DelaysLabel.AutoSize = true;
            this.DelaysLabel.Location = new System.Drawing.Point(397, 4);
            this.DelaysLabel.Name = "DelaysLabel";
            this.DelaysLabel.Size = new System.Drawing.Size(39, 13);
            this.DelaysLabel.TabIndex = 22;
            this.DelaysLabel.Text = "Delays";
            // 
            // DelaysBtn
            // 
            this.DelaysBtn.Location = new System.Drawing.Point(400, 20);
            this.DelaysBtn.Name = "DelaysBtn";
            this.DelaysBtn.Size = new System.Drawing.Size(74, 20);
            this.DelaysBtn.TabIndex = 21;
            this.DelaysBtn.Text = "Delays";
            this.DelaysBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Repeat No.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelaysLabel);
            this.Controls.Add(this.DelaysBtn);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.InstructionsBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ReturnCheckBox);
            this.Controls.Add(this.TabCheckBox);
            this.Controls.Add(this.InsertKBSCBtn);
            this.Controls.Add(this.InsertTabBtn);
            this.Controls.Add(this.InsertReturnBtn);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.PopOutBtn);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.TriggerBtn);
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.TriggerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Kestroke Tool";
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TriggerLabel;
        private System.Windows.Forms.TextBox Trigger;
        private System.Windows.Forms.Button TriggerBtn;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button PopOutBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Button InsertReturnBtn;
        private System.Windows.Forms.Button InsertTabBtn;
        private System.Windows.Forms.Button InsertKBSCBtn;
        private System.Windows.Forms.CheckBox TabCheckBox;
        private System.Windows.Forms.CheckBox ReturnCheckBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button InstructionsBtn;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label DelaysLabel;
        private System.Windows.Forms.Button DelaysBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

