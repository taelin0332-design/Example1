namespace solution4
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
            textBox_Input = new TextBox();
            button_Input = new TextBox();
            textBox_result = new TextBox();
            radioTrue = new RadioButton();
            radioFalse = new RadioButton();
            SuspendLayout();
            // 
            // textBox_Input
            // 
            textBox_Input.Location = new Point(222, 55);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(125, 27);
            textBox_Input.TabIndex = 0;
            // 
            // button_Input
            // 
            button_Input.Location = new Point(386, 55);
            button_Input.Name = "button_Input";
            button_Input.Size = new Size(125, 27);
            button_Input.TabIndex = 1;
            button_Input.Click += button_Input_Click;
            // 
            // textBox_result
            // 
            textBox_result.BackColor = SystemColors.ControlLightLight;
            textBox_result.Location = new Point(237, 142);
            textBox_result.Multiline = true;
            textBox_result.Name = "textBox_result";
            textBox_result.ReadOnly = true;
            textBox_result.Size = new Size(302, 165);
            textBox_result.TabIndex = 2;
            // 
            // radioTrue
            // 
            radioTrue.AutoSize = true;
            radioTrue.Location = new Point(222, 88);
            radioTrue.Name = "radioTrue";
            radioTrue.Size = new Size(60, 24);
            radioTrue.TabIndex = 3;
            radioTrue.TabStop = true;
            radioTrue.Text = "True";
            radioTrue.UseVisualStyleBackColor = true;
            radioTrue.CheckedChanged += this.radioTrue_CheckedChanged;
            // 
            // radioFalse
            // 
            radioFalse.AutoSize = true;
            radioFalse.Location = new Point(279, 88);
            radioFalse.Name = "radioFalse";
            radioFalse.Size = new Size(63, 24);
            radioFalse.TabIndex = 4;
            radioFalse.TabStop = true;
            radioFalse.Text = "False";
            radioFalse.UseVisualStyleBackColor = true;
            radioFalse.CheckedChanged += radioFalse_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioFalse);
            Controls.Add(radioTrue);
            Controls.Add(textBox_result);
            Controls.Add(button_Input);
            Controls.Add(textBox_Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Input;
        private TextBox button_Input;
        private TextBox textBox_result;
        private RadioButton radioFalse;
        private RadioButton radioTrue;
        private RadioButton radioTrue;
        private RadioButton radioTrue;
    }
}
