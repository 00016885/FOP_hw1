namespace StrangeLanguage
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
            tbxInput = new TextBox();
            btnTranslate = new Button();
            SuspendLayout();
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(162, 70);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(125, 27);
            tbxInput.TabIndex = 0;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(169, 132);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(94, 29);
            btnTranslate.TabIndex = 1;
            btnTranslate.Text = "button1";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTranslate);
            Controls.Add(tbxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxInput;
        private Button btnTranslate;
    }
}