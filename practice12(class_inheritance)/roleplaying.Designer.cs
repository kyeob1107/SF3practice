namespace practice12_class_inheritance_
{
    partial class roleplaying
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_fighter1 = new System.Windows.Forms.ListBox();
            this.listBox_fighter2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(13, 172);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(343, 143);
            this.textBox_result.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(150, -2);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 23);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "fighter1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "fighter2";
            // 
            // listBox_fighter1
            // 
            this.listBox_fighter1.FormattingEnabled = true;
            this.listBox_fighter1.ItemHeight = 15;
            this.listBox_fighter1.Items.AddRange(new object[] {
            "player",
            "npc",
            "slime",
            "orc"});
            this.listBox_fighter1.Location = new System.Drawing.Point(24, 30);
            this.listBox_fighter1.Name = "listBox_fighter1";
            this.listBox_fighter1.Size = new System.Drawing.Size(120, 94);
            this.listBox_fighter1.TabIndex = 6;
            // 
            // listBox_fighter2
            // 
            this.listBox_fighter2.FormattingEnabled = true;
            this.listBox_fighter2.ItemHeight = 15;
            this.listBox_fighter2.Items.AddRange(new object[] {
            "player",
            "npc",
            "slime",
            "orc"});
            this.listBox_fighter2.Location = new System.Drawing.Point(189, 30);
            this.listBox_fighter2.Name = "listBox_fighter2";
            this.listBox_fighter2.Size = new System.Drawing.Size(120, 94);
            this.listBox_fighter2.TabIndex = 6;
            // 
            // roleplaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 326);
            this.Controls.Add(this.listBox_fighter2);
            this.Controls.Add(this.listBox_fighter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_result);
            this.Name = "roleplaying";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_fighter1;
        private System.Windows.Forms.ListBox listBox_fighter2;
    }
}

