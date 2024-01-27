namespace CalculatorUsingCSharp
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

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 60);
            textBox1.Font = new Font("Microsoft Sans Serif", 22);
            textBox1.TabIndex = 0;
            textBox1.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 521);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
     

 
    }
}
