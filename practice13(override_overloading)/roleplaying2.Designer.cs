namespace practice12_class_inheritance_
{
    partial class roleplaying2
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
            this.button_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_fighter1 = new System.Windows.Forms.ListBox();
            this.listBox_fighter2 = new System.Windows.Forms.ListBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_levelup = new System.Windows.Forms.Button();
            this.label_playerinfo = new System.Windows.Forms.Label();
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
            this.textBox_result.Size = new System.Drawing.Size(433, 143);
            this.textBox_result.TabIndex = 2;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(354, 25);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 47);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "fighter1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 142);
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
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(354, 78);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 46);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_levelup
            // 
            this.button_levelup.Location = new System.Drawing.Point(354, 131);
            this.button_levelup.Name = "button_levelup";
            this.button_levelup.Size = new System.Drawing.Size(75, 23);
            this.button_levelup.TabIndex = 8;
            this.button_levelup.Text = "levelup";
            this.button_levelup.UseVisualStyleBackColor = true;
            this.button_levelup.Click += new System.EventHandler(this.button_levelup_Click);
            // 
            // label_playerinfo
            // 
            this.label_playerinfo.AutoSize = true;
            this.label_playerinfo.Location = new System.Drawing.Point(24, 9);
            this.label_playerinfo.Name = "label_playerinfo";
            this.label_playerinfo.Size = new System.Drawing.Size(67, 15);
            this.label_playerinfo.TabIndex = 9;
            this.label_playerinfo.Text = "용사정보";
            // 
            // roleplaying2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 326);
            this.Controls.Add(this.label_playerinfo);
            this.Controls.Add(this.button_levelup);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.listBox_fighter2);
            this.Controls.Add(this.listBox_fighter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBox_result);
            this.Name = "roleplaying2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_fighter1;
        private System.Windows.Forms.ListBox listBox_fighter2;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_levelup;
        private System.Windows.Forms.Label label_playerinfo;
    }
}

