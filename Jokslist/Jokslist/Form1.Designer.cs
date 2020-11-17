namespace Jokslist
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
            this.previous = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jokeText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(160, 239);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 0;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jokeText
            // 
            this.jokeText.Location = new System.Drawing.Point(191, 81);
            this.jokeText.Name = "jokeText";
            this.jokeText.Size = new System.Drawing.Size(190, 132);
            this.jokeText.TabIndex = 2;
            this.jokeText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rating";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(236, 55);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.previous);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox jokeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ratingTextBox;
    }
}

