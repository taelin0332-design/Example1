namespace solution5
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
            Rock = new TextBox();
            Scissors = new TextBox();
            Paper = new TextBox();
            userScoreTextBox = new TextBox();
            computerScoreTextBox = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Rock
            // 
            Rock.Location = new Point(171, 319);
            Rock.Name = "Rock";
            Rock.Size = new Size(125, 27);
            Rock.TabIndex = 0;
            Rock.Text = "Rock";
            Rock.TextAlign = HorizontalAlignment.Center;
            Rock.Click += Rock_Click;
            // 
            // Scissors
            // 
            Scissors.Location = new Point(313, 319);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(125, 27);
            Scissors.TabIndex = 1;
            Scissors.Text = "Scissors";
            Scissors.TextAlign = HorizontalAlignment.Center;
            Scissors.Click += Scissors_Click;
            // 
            // Paper
            // 
            Paper.Location = new Point(460, 319);
            Paper.Name = "Paper";
            Paper.Size = new Size(125, 27);
            Paper.TabIndex = 2;
            Paper.Text = "Paper";
            Paper.TextAlign = HorizontalAlignment.Center;
            Paper.Click += Paper_Click;
            // 
            // userScoreTextBox
            // 
            userScoreTextBox.Location = new Point(171, 243);
            userScoreTextBox.Name = "userScoreTextBox";
            userScoreTextBox.Size = new Size(125, 27);
            userScoreTextBox.TabIndex = 3;
            userScoreTextBox.Text = "0";
            userScoreTextBox.TextAlign = HorizontalAlignment.Center;
            userScoreTextBox.TextChanged += textBox1_TextChanged;
            // 
            // computerScoreTextBox
            // 
            computerScoreTextBox.Location = new Point(460, 243);
            computerScoreTextBox.Name = "computerScoreTextBox";
            computerScoreTextBox.Size = new Size(125, 27);
            computerScoreTextBox.TabIndex = 4;
            computerScoreTextBox.Text = "0";
            computerScoreTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 27);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 162);
            textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(computerScoreTextBox);
            Controls.Add(userScoreTextBox);
            Controls.Add(Paper);
            Controls.Add(Scissors);
            Controls.Add(Rock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Rock;
        private TextBox Scissors;
        private TextBox Paper;
        private TextBox userScoreTextBox;
        private TextBox computerScoreTextBox;
        private TextBox textBox3;
    }
}
