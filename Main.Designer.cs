namespace Keystroke_Tool
{
    partial class KeystrokeTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeystrokeTool));
            this.InputField = new System.Windows.Forms.TextBox();
            this.TabCheckBox = new System.Windows.Forms.CheckBox();
            this.EnterCheckBox = new System.Windows.Forms.CheckBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.waitTimeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDelayField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 25);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(257, 163);
            this.InputField.TabIndex = 1;
            // 
            // TabCheckBox
            // 
            this.TabCheckBox.AutoSize = true;
            this.TabCheckBox.Location = new System.Drawing.Point(276, 130);
            this.TabCheckBox.Name = "TabCheckBox";
            this.TabCheckBox.Size = new System.Drawing.Size(45, 17);
            this.TabCheckBox.TabIndex = 2;
            this.TabCheckBox.Text = "Tab";
            this.TabCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnterCheckBox
            // 
            this.EnterCheckBox.AutoSize = true;
            this.EnterCheckBox.Location = new System.Drawing.Point(276, 107);
            this.EnterCheckBox.Name = "EnterCheckBox";
            this.EnterCheckBox.Size = new System.Drawing.Size(51, 17);
            this.EnterCheckBox.TabIndex = 3;
            this.EnterCheckBox.Text = "Enter";
            this.EnterCheckBox.UseVisualStyleBackColor = true;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(276, 153);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 35);
            this.GoBtn.TabIndex = 4;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // waitTimeField
            // 
            this.waitTimeField.Location = new System.Drawing.Point(276, 81);
            this.waitTimeField.Name = "waitTimeField";
            this.waitTimeField.Size = new System.Drawing.Size(75, 20);
            this.waitTimeField.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delay (secs)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Delay (secs)";
            // 
            // startDelayField
            // 
            this.startDelayField.CausesValidation = false;
            this.startDelayField.Location = new System.Drawing.Point(276, 42);
            this.startDelayField.Name = "startDelayField";
            this.startDelayField.Size = new System.Drawing.Size(86, 20);
            this.startDelayField.TabIndex = 9;
            // 
            // KeystrokeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(363, 197);
            this.Controls.Add(this.startDelayField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waitTimeField);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.EnterCheckBox);
            this.Controls.Add(this.TabCheckBox);
            this.Controls.Add(this.InputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KeystrokeTool";
            this.Text = "Keystroke Tool - King Chungus#6133";
            this.Load += new System.EventHandler(this.KeystrokeTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.CheckBox TabCheckBox;
        private System.Windows.Forms.CheckBox EnterCheckBox;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox waitTimeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startDelayField;
    }
}

