namespace LedControl
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
            this.resetButton = new System.Windows.Forms.Button();
            this.RedBar = new System.Windows.Forms.HScrollBar();
            this.GreenBar = new System.Windows.Forms.HScrollBar();
            this.BlueBar = new System.Windows.Forms.HScrollBar();
            this.redBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(29, 32);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(29, 76);
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(182, 24);
            this.RedBar.TabIndex = 1;
            this.RedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Red_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(29, 120);
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(182, 27);
            this.GreenBar.TabIndex = 1;
            this.GreenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Green_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(29, 172);
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(182, 24);
            this.BlueBar.TabIndex = 1;
            this.BlueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Blue_Scroll);
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(228, 76);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(100, 20);
            this.redBox.TabIndex = 2;
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(228, 120);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(100, 20);
            this.greenBox.TabIndex = 3;
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(228, 172);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(100, 20);
            this.blueBox.TabIndex = 4;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(29, 230);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(182, 20);
            this.statusBox.TabIndex = 4;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(39, 62);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(42, 104);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(36, 13);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(42, 151);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 7;
            this.blueLabel.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 262);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.HScrollBar RedBar;
        private System.Windows.Forms.HScrollBar GreenBar;
        private System.Windows.Forms.HScrollBar BlueBar;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
    }
}

