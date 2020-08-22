namespace RSI_Clicker
{
    partial class RSIClick
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClicksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // ClicksLabel
            // 
            this.ClicksLabel.AutoSize = true;
            this.ClicksLabel.Location = new System.Drawing.Point(355, 99);
            this.ClicksLabel.Name = "ClicksLabel";
            this.ClicksLabel.Size = new System.Drawing.Size(54, 20);
            this.ClicksLabel.TabIndex = 2;
            this.ClicksLabel.Text = "Clicks:";
            // 
            // RSIClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClicksLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RSIClick";
            this.Text = "RSI Clicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ClicksLabel;
    }
}

