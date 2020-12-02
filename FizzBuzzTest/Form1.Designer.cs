
namespace FizzBuzzTest
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
            this.fzBzOutputLabel = new System.Windows.Forms.Label();
            this.FizzButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fzBzOutputLabel
            // 
            this.fzBzOutputLabel.Location = new System.Drawing.Point(59, 124);
            this.fzBzOutputLabel.Name = "fzBzOutputLabel";
            this.fzBzOutputLabel.Size = new System.Drawing.Size(673, 162);
            this.fzBzOutputLabel.TabIndex = 0;
            // 
            // FizzButton
            // 
            this.FizzButton.Location = new System.Drawing.Point(253, 36);
            this.FizzButton.Name = "FizzButton";
            this.FizzButton.Size = new System.Drawing.Size(80, 32);
            this.FizzButton.TabIndex = 1;
            this.FizzButton.Text = "FizzBuzz!";
            this.FizzButton.UseVisualStyleBackColor = true;
            this.FizzButton.Click += new System.EventHandler(this.FizzButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(428, 36);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 248);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FizzButton);
            this.Controls.Add(this.fzBzOutputLabel);
            this.Name = "Form1";
            this.Text = "Fizz Buzz Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fzBzOutputLabel;
        private System.Windows.Forms.Button FizzButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

