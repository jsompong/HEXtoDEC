namespace WFAnet
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
            this.HEXlistBox = new System.Windows.Forms.ListBox();
            this.DEClistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HEXlistBox
            // 
            this.HEXlistBox.FormattingEnabled = true;
            this.HEXlistBox.Location = new System.Drawing.Point(88, 121);
            this.HEXlistBox.Name = "HEXlistBox";
            this.HEXlistBox.Size = new System.Drawing.Size(65, 212);
            this.HEXlistBox.TabIndex = 0;
            this.HEXlistBox.SelectedIndexChanged += new System.EventHandler(this.HEXlistBox_SelectedIndexChanged);
            // 
            // DEClistBox
            // 
            this.DEClistBox.FormattingEnabled = true;
            this.DEClistBox.Location = new System.Drawing.Point(169, 121);
            this.DEClistBox.Name = "DEClistBox";
            this.DEClistBox.Size = new System.Drawing.Size(65, 212);
            this.DEClistBox.TabIndex = 1;
            this.DEClistBox.SelectedIndexChanged += new System.EventHandler(this.DEClistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DEC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DEClistBox);
            this.Controls.Add(this.HEXlistBox);
            this.Name = "Form1";
            this.Text = "Sine Wave HEX to DEC (VS Community 2022)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HEXlistBox;
        private System.Windows.Forms.ListBox DEClistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

