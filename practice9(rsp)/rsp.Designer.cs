namespace practice9_while_
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_user_wins = new System.Windows.Forms.Label();
            this.label_pc_wins = new System.Windows.Forms.Label();
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_rock = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(12, 90);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(343, 224);
            this.textBox_result.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(285, 9);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 42);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "restart";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "가위, 바위, 보를 선택해주세요";
            // 
            // label_user_wins
            // 
            this.label_user_wins.AutoSize = true;
            this.label_user_wins.Location = new System.Drawing.Point(13, 57);
            this.label_user_wins.Name = "label_user_wins";
            this.label_user_wins.Size = new System.Drawing.Size(125, 15);
            this.label_user_wins.TabIndex = 5;
            this.label_user_wins.Text = "사용자 승리 수: 0";
            // 
            // label_pc_wins
            // 
            this.label_pc_wins.AutoSize = true;
            this.label_pc_wins.Location = new System.Drawing.Point(183, 57);
            this.label_pc_wins.Name = "label_pc_wins";
            this.label_pc_wins.Size = new System.Drawing.Size(125, 15);
            this.label_pc_wins.TabIndex = 5;
            this.label_pc_wins.Text = "컴퓨터 승리 수: 0";
            // 
            // button_scissors
            // 
            this.button_scissors.Location = new System.Drawing.Point(16, 31);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(75, 23);
            this.button_scissors.TabIndex = 6;
            this.button_scissors.Text = "가위";
            this.button_scissors.UseVisualStyleBackColor = true;
            this.button_scissors.Click += new System.EventHandler(this.button_scissors_Click);
            // 
            // button_rock
            // 
            this.button_rock.Location = new System.Drawing.Point(102, 31);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(75, 23);
            this.button_rock.TabIndex = 6;
            this.button_rock.Text = "바위";
            this.button_rock.UseVisualStyleBackColor = true;
            this.button_rock.Click += new System.EventHandler(this.button_rock_Click);
            // 
            // button_paper
            // 
            this.button_paper.Location = new System.Drawing.Point(183, 31);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(75, 23);
            this.button_paper.TabIndex = 6;
            this.button_paper.Text = "보";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 326);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_rock);
            this.Controls.Add(this.button_scissors);
            this.Controls.Add(this.label_pc_wins);
            this.Controls.Add(this.label_user_wins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "가위_바위_보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user_wins;
        private System.Windows.Forms.Label label_pc_wins;
        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Button button_paper;
    }
}

