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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            PlayerWinsCount = new Label();
            ComputerWinsCount = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(143, 115);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            button1.Click += ComputerClick;
            // 
            // button2
            // 
            button2.Location = new Point(211, 115);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            button2.Click += ComputerClick;
            // 
            // button3
            // 
            button3.Location = new Point(279, 115);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            button3.Click += ComputerClick;
            // 
            // button4
            // 
            button4.Location = new Point(143, 182);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            button4.Click += ComputerClick;
            // 
            // button5
            // 
            button5.Location = new Point(211, 182);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            button5.Click += ComputerClick;
            // 
            // button6
            // 
            button6.Location = new Point(279, 182);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            button6.Click += ComputerClick;
            // 
            // button7
            // 
            button7.Location = new Point(143, 250);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            button7.Click += ComputerClick;
            // 
            // button8
            // 
            button8.Location = new Point(211, 250);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            button8.Click += ComputerClick;
            // 
            // button9
            // 
            button9.Location = new Point(279, 250);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            button9.Click += ComputerClick;

            // 
            // button10
            // 
            button10.BackColor = Color.Pink;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.MediumVioletRed;
            button10.Location = new Point(318, 397);
            button10.Name = "button10";
            button10.Size = new Size(163, 40);
            button10.TabIndex = 9;
            button10.Text = "Start New Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 10;
            label1.Text = "Player Wins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(354, 9);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 11;
            label2.Text = "Computer Wins";
            // 
            // PlayerWinsCount
            // 
            PlayerWinsCount.AutoSize = true;
            PlayerWinsCount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerWinsCount.ForeColor = Color.OrangeRed;
            PlayerWinsCount.Location = new Point(117, 9);
            PlayerWinsCount.Name = "PlayerWinsCount";
            PlayerWinsCount.Size = new Size(19, 23);
            PlayerWinsCount.TabIndex = 12;
            PlayerWinsCount.Text = "0";
            // 
            // ComputerWinsCount
            // 
            ComputerWinsCount.AutoSize = true;
            ComputerWinsCount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ComputerWinsCount.ForeColor = Color.Red;
            ComputerWinsCount.Location = new Point(336, 9);
            ComputerWinsCount.Name = "ComputerWinsCount";
            ComputerWinsCount.Size = new Size(19, 23);
            ComputerWinsCount.TabIndex = 13;
            ComputerWinsCount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(482, 453);
            Controls.Add(ComputerWinsCount);
            Controls.Add(PlayerWinsCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Game X/O";
            ResumeLayout(false);
            PerformLayout();
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