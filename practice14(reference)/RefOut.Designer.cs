namespace practice14_reference_
{
    partial class RefOut
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_ref = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 59);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(259, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(13, 91);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(343, 224);
            this.textBox_result.TabIndex = 2;
            // 
            // button_ref
            // 
            this.button_ref.Location = new System.Drawing.Point(281, 22);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(75, 23);
            this.button_ref.TabIndex = 1;
            this.button_ref.Text = "ref";
            this.button_ref.UseVisualStyleBackColor = true;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "내용을 입력해주세요";
            // 
            // button_out
            // 
            this.button_out.Location = new System.Drawing.Point(281, 59);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(75, 23);
            this.button_out.TabIndex = 4;
            this.button_out.Text = "out";
            this.button_out.UseVisualStyleBackColor = true;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // RefOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 326);
            this.Controls.Add(this.button_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ref);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_input);
            this.Name = "RefOut";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_ref;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_out;
    }
}

