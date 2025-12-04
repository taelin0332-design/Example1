namespace solution6
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
            textBox_input = new TextBox();
            textBox_result = new TextBox();
            SuspendLayout();
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(102, 37);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(125, 27);
            textBox_input.TabIndex = 0;
            textBox_input.TextChanged += textBox_input_TextChanged;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(102, 97);
            textBox_result.Multiline = true;
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(321, 256);
            textBox_result.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_result);
            Controls.Add(textBox_input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_input;
        private TextBox textBox_result;
    }
}
