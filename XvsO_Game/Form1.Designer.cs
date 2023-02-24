namespace XvsO_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerWinsCount = new System.Windows.Forms.Label();
            this.ComputerWinsCount = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(143, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(143, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(211, 250);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(279, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Pink;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button10.Location = new System.Drawing.Point(318, 397);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "Start New Game";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Computer Wins";
            // 
            // PlayerWinsCount
            // 
            this.PlayerWinsCount.AutoSize = true;
            this.PlayerWinsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerWinsCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.PlayerWinsCount.Location = new System.Drawing.Point(117, 9);
            this.PlayerWinsCount.Name = "PlayerWinsCount";
            this.PlayerWinsCount.Size = new System.Drawing.Size(19, 23);
            this.PlayerWinsCount.TabIndex = 12;
            this.PlayerWinsCount.Text = "0";
            // 
            // ComputerWinsCount
            // 
            this.ComputerWinsCount.AutoSize = true;
            this.ComputerWinsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerWinsCount.ForeColor = System.Drawing.Color.Red;
            this.ComputerWinsCount.Location = new System.Drawing.Point(336, 9);
            this.ComputerWinsCount.Name = "ComputerWinsCount";
            this.ComputerWinsCount.Size = new System.Drawing.Size(19, 23);
            this.ComputerWinsCount.TabIndex = 13;
            this.ComputerWinsCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.ComputerWinsCount);
            this.Controls.Add(this.PlayerWinsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Game X/O";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.button1.Click += new System.EventHandler(this.playerClick);
            this.button2.Click += new System.EventHandler(this.playerClick);
            this.button3.Click += new System.EventHandler(this.playerClick);
            this.button4.Click += new System.EventHandler(this.playerClick);
            this.button5.Click += new System.EventHandler(this.playerClick);
            this.button6.Click += new System.EventHandler(this.playerClick);
            this.button7.Click += new System.EventHandler(this.playerClick);
            this.button8.Click += new System.EventHandler(this.playerClick);
            this.button9.Click += new System.EventHandler(this.playerClick);
            this.button1.Click += new System.EventHandler(this.ComputerClick);
            this.button2.Click += new System.EventHandler(this.ComputerClick);
            this.button3.Click += new System.EventHandler(this.ComputerClick);
            this.button4.Click += new System.EventHandler(this.ComputerClick);
            this.button5.Click += new System.EventHandler(this.ComputerClick);
            this.button6.Click += new System.EventHandler(this.ComputerClick);
            this.button7.Click += new System.EventHandler(this.ComputerClick);
            this.button8.Click += new System.EventHandler(this.ComputerClick);
            this.button9.Click += new System.EventHandler(this.ComputerClick);
            this.Check();
            this.StartNewGame();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
        private Label PlayerWinsCount;
        private Label ComputerWinsCount;
        private System.Windows.Forms.Timer Timer;

    }
}