namespace practice17._5_another_backgroundWorker_practice_
{
    partial class backgroundworker2
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.textBox_extension = new System.Windows.Forms.TextBox();
            this.label_extension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 31);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(263, 25);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.Text = "C:\\Users\\KSY\\codingon";
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(281, 31);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 51);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "경로를 입력해주세요";
            // 
            // listBox_files
            // 
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.ItemHeight = 15;
            this.listBox_files.Location = new System.Drawing.Point(12, 108);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.Size = new System.Drawing.Size(344, 199);
            this.listBox_files.TabIndex = 4;
            // 
            // textBox_extension
            // 
            this.textBox_extension.Location = new System.Drawing.Point(175, 59);
            this.textBox_extension.Name = "textBox_extension";
            this.textBox_extension.Size = new System.Drawing.Size(100, 25);
            this.textBox_extension.TabIndex = 5;
            this.textBox_extension.Text = "txt";
            // 
            // label_extension
            // 
            this.label_extension.AutoSize = true;
            this.label_extension.Location = new System.Drawing.Point(102, 62);
            this.label_extension.Name = "label_extension";
            this.label_extension.Size = new System.Drawing.Size(67, 15);
            this.label_extension.TabIndex = 6;
            this.label_extension.Text = "확장자명";
            // 
            // backgroundworker2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 326);
            this.Controls.Add(this.label_extension);
            this.Controls.Add(this.textBox_extension);
            this.Controls.Add(this.listBox_files);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_input);
            this.Name = "backgroundworker2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_files;
        private System.Windows.Forms.TextBox textBox_extension;
        private System.Windows.Forms.Label label_extension;
    }
}

