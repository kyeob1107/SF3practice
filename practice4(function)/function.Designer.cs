namespace practice4_function_
{
    partial class function
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
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.div_x = new System.Windows.Forms.TextBox();
            this.div_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(31, 79);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.Size = new System.Drawing.Size(732, 323);
            this.textBox_print.TabIndex = 0;
            // 
            // div_x
            // 
            this.div_x.Location = new System.Drawing.Point(121, 29);
            this.div_x.Name = "div_x";
            this.div_x.Size = new System.Drawing.Size(100, 25);
            this.div_x.TabIndex = 1;
            this.div_x.Text = "7";
            // 
            // div_y
            // 
            this.div_y.Location = new System.Drawing.Point(326, 29);
            this.div_y.Name = "div_y";
            this.div_y.Size = new System.Drawing.Size(100, 25);
            this.div_y.TabIndex = 2;
            this.div_y.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "나누어질 수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "나누는 수";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.div_y);
            this.Controls.Add(this.div_x);
            this.Controls.Add(this.textBox_print);
            this.Name = "function";
            this.Text = "div_fnct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.TextBox div_x;
        private System.Windows.Forms.TextBox div_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

