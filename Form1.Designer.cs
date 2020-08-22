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
            this.ClicksLabel = new System.Windows.Forms.Label();
            this.AutoClickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "test click 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // ClicksLabel
            // 
            this.ClicksLabel.AutoSize = true;
            this.ClicksLabel.Location = new System.Drawing.Point(291, 27);
            this.ClicksLabel.Name = "ClicksLabel";
            this.ClicksLabel.Size = new System.Drawing.Size(54, 20);
            this.ClicksLabel.TabIndex = 2;
            this.ClicksLabel.Text = "Clicks:";
            // 
            // AutoClickButton
            // 
            this.AutoClickButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AutoClickButton.Location = new System.Drawing.Point(164, 223);
            this.AutoClickButton.Name = "AutoClickButton";
            this.AutoClickButton.Size = new System.Drawing.Size(293, 64);
            this.AutoClickButton.TabIndex = 3;
            this.AutoClickButton.Text = "turn ON auto clicker";
            this.AutoClickButton.UseVisualStyleBackColor = false;
            this.AutoClickButton.Click += new System.EventHandler(this.AutoClickButton_Click);
            // 
            // RSIClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(615, 324);
            this.Controls.Add(this.AutoClickButton);
            this.Controls.Add(this.ClicksLabel);
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
        private System.Windows.Forms.Label ClicksLabel;
        private System.Windows.Forms.Button AutoClickButton;
    }
}

