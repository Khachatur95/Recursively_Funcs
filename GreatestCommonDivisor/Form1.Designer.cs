namespace GreatestCommonDivisor
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
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.Greatest_Button = new System.Windows.Forms.Button();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fact_Button = new System.Windows.Forms.Button();
            this.FIb_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(468, 65);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(100, 20);
            this.textBoxOut.TabIndex = 2;
            // 
            // Greatest_Button
            // 
            this.Greatest_Button.Location = new System.Drawing.Point(202, 2);
            this.Greatest_Button.Name = "Greatest_Button";
            this.Greatest_Button.Size = new System.Drawing.Size(89, 24);
            this.Greatest_Button.TabIndex = 3;
            this.Greatest_Button.Text = "GreatestDivisor";
            this.Greatest_Button.UseVisualStyleBackColor = true;
            this.Greatest_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(12, 65);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput1.TabIndex = 4;
            this.textBoxInput1.TextChanged += new System.EventHandler(this.textBoxInput1_TextChanged);
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(129, 65);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput2.TabIndex = 5;
            this.textBoxInput2.TextChanged += new System.EventHandler(this.textBoxInput2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Num 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Num 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // Fact_Button
            // 
            this.Fact_Button.Location = new System.Drawing.Point(12, 2);
            this.Fact_Button.Name = "Fact_Button";
            this.Fact_Button.Size = new System.Drawing.Size(89, 24);
            this.Fact_Button.TabIndex = 9;
            this.Fact_Button.Text = "Factorial";
            this.Fact_Button.UseVisualStyleBackColor = true;
            this.Fact_Button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FIb_Button
            // 
            this.FIb_Button.Location = new System.Drawing.Point(107, 2);
            this.FIb_Button.Name = "FIb_Button";
            this.FIb_Button.Size = new System.Drawing.Size(89, 24);
            this.FIb_Button.TabIndex = 10;
            this.FIb_Button.Text = "Fibonacci";
            this.FIb_Button.UseVisualStyleBackColor = true;
            this.FIb_Button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 340);
            this.Controls.Add(this.FIb_Button);
            this.Controls.Add(this.Fact_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.Greatest_Button);
            this.Controls.Add(this.textBoxOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button Greatest_Button;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Fact_Button;
        private System.Windows.Forms.Button FIb_Button;
    }
}

