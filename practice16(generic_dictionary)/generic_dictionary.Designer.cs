namespace practice16_generic_dictionary_
{
    partial class generic_dictionary
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
            this.textBox_input_id = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_default_path = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_input_id
            // 
            this.textBox_input_id.Location = new System.Drawing.Point(54, 60);
            this.textBox_input_id.Name = "textBox_input_id";
            this.textBox_input_id.Size = new System.Drawing.Size(222, 25);
            this.textBox_input_id.TabIndex = 0;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(282, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 34);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(282, 61);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 60);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 11F);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // textBox_input_pw
            // 
            this.textBox_input_pw.Location = new System.Drawing.Point(54, 95);
            this.textBox_input_pw.Name = "textBox_input_pw";
            this.textBox_input_pw.PasswordChar = '●';
            this.textBox_input_pw.Size = new System.Drawing.Size(222, 25);
            this.textBox_input_pw.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 11F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "default_path";
            // 
            // comboBox_default_path
            // 
            this.comboBox_default_path.FormattingEnabled = true;
            this.comboBox_default_path.Items.AddRange(new object[] {
            "바탕화면",
            "문서",
            "프로젝트실행경로"});
            this.comboBox_default_path.Location = new System.Drawing.Point(124, 9);
            this.comboBox_default_path.Name = "comboBox_default_path";
            this.comboBox_default_path.Size = new System.Drawing.Size(121, 23);
            this.comboBox_default_path.TabIndex = 7;
            // 
            // generic_dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 133);
            this.Controls.Add(this.comboBox_default_path);
            this.Controls.Add(this.textBox_input_pw);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.textBox_input_id);
            this.Name = "generic_dictionary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input_id;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_default_path;
    }
}

