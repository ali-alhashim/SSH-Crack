
namespace GeneratingRandomPasswords
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
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.passLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portTxtBox = new System.Windows.Forms.TextBox();
            this.lowCharCheckBox = new System.Windows.Forms.CheckBox();
            this.upCharCheckBox = new System.Windows.Forms.CheckBox();
            this.NumericCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharCheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SpaceCheckBox = new System.Windows.Forms.CheckBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExceptionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 284);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(211, 67);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 519);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 1;
            // 
            // passLengthTextBox
            // 
            this.passLengthTextBox.Location = new System.Drawing.Point(12, 48);
            this.passLengthTextBox.Name = "passLengthTextBox";
            this.passLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.passLengthTextBox.TabIndex = 3;
            this.passLengthTextBox.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(229, 191);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(346, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(123, 191);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 11;
            this.userTextBox.Text = "root";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port";
            // 
            // portTxtBox
            // 
            this.portTxtBox.Location = new System.Drawing.Point(17, 191);
            this.portTxtBox.Name = "portTxtBox";
            this.portTxtBox.Size = new System.Drawing.Size(100, 20);
            this.portTxtBox.TabIndex = 14;
            this.portTxtBox.Text = "22";
            // 
            // lowCharCheckBox
            // 
            this.lowCharCheckBox.AutoSize = true;
            this.lowCharCheckBox.Checked = true;
            this.lowCharCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowCharCheckBox.Location = new System.Drawing.Point(146, 48);
            this.lowCharCheckBox.Name = "lowCharCheckBox";
            this.lowCharCheckBox.Size = new System.Drawing.Size(170, 17);
            this.lowCharCheckBox.TabIndex = 16;
            this.lowCharCheckBox.Text = "LOWERCASE CHARACTERS";
            this.lowCharCheckBox.UseVisualStyleBackColor = true;
            // 
            // upCharCheckBox
            // 
            this.upCharCheckBox.AutoSize = true;
            this.upCharCheckBox.Checked = true;
            this.upCharCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upCharCheckBox.Location = new System.Drawing.Point(146, 72);
            this.upCharCheckBox.Name = "upCharCheckBox";
            this.upCharCheckBox.Size = new System.Drawing.Size(167, 17);
            this.upCharCheckBox.TabIndex = 17;
            this.upCharCheckBox.Text = "UPPERCASE CHARACTERS";
            this.upCharCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumericCheckBox
            // 
            this.NumericCheckBox.AutoSize = true;
            this.NumericCheckBox.Checked = true;
            this.NumericCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumericCheckBox.Location = new System.Drawing.Point(146, 95);
            this.NumericCheckBox.Name = "NumericCheckBox";
            this.NumericCheckBox.Size = new System.Drawing.Size(152, 17);
            this.NumericCheckBox.TabIndex = 18;
            this.NumericCheckBox.Text = "NUMERIC CHARACTERS";
            this.NumericCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharCheckBox
            // 
            this.SpecialCharCheckBox.AutoSize = true;
            this.SpecialCharCheckBox.Checked = true;
            this.SpecialCharCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpecialCharCheckBox.Location = new System.Drawing.Point(146, 118);
            this.SpecialCharCheckBox.Name = "SpecialCharCheckBox";
            this.SpecialCharCheckBox.Size = new System.Drawing.Size(146, 17);
            this.SpecialCharCheckBox.TabIndex = 19;
            this.SpecialCharCheckBox.Text = "SPECIAL CHARACTERS";
            this.SpecialCharCheckBox.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 42);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // SpaceCheckBox
            // 
            this.SpaceCheckBox.AutoSize = true;
            this.SpaceCheckBox.Checked = true;
            this.SpaceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpaceCheckBox.Location = new System.Drawing.Point(146, 142);
            this.SpaceCheckBox.Name = "SpaceCheckBox";
            this.SpaceCheckBox.Size = new System.Drawing.Size(68, 17);
            this.SpaceCheckBox.TabIndex = 21;
            this.SpaceCheckBox.Text = "SPACES";
            this.SpaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(679, 284);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(109, 67);
            this.stopBtn.TabIndex = 22;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 67);
            this.button1.TabIndex = 23;
            this.button1.Text = "Start 2nd Thread new Window";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 67);
            this.button2.TabIndex = 24;
            this.button2.Text = "Crack With Password List File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ExceptionBox
            // 
            this.ExceptionBox.Location = new System.Drawing.Point(12, 405);
            this.ExceptionBox.Name = "ExceptionBox";
            this.ExceptionBox.Size = new System.Drawing.Size(776, 96);
            this.ExceptionBox.TabIndex = 25;
            this.ExceptionBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.ExceptionBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.SpaceCheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SpecialCharCheckBox);
            this.Controls.Add(this.NumericCheckBox);
            this.Controls.Add(this.upCharCheckBox);
            this.Controls.Add(this.lowCharCheckBox);
            this.Controls.Add(this.portTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLengthTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crack SSH Paasword";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox passLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox portTxtBox;
        private System.Windows.Forms.CheckBox lowCharCheckBox;
        private System.Windows.Forms.CheckBox upCharCheckBox;
        private System.Windows.Forms.CheckBox NumericCheckBox;
        private System.Windows.Forms.CheckBox SpecialCharCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox SpaceCheckBox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox ExceptionBox;
    }
}

