namespace DragTree
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
            this.components = new System.ComponentModel.Container();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lightA1 = new System.Windows.Forms.Button();
            this.lightA2 = new System.Windows.Forms.Button();
            this.lightB1 = new System.Windows.Forms.Button();
            this.lightB2 = new System.Windows.Forms.Button();
            this.lightC1 = new System.Windows.Forms.Button();
            this.lightC2 = new System.Windows.Forms.Button();
            this.lightD2 = new System.Windows.Forms.Button();
            this.lightD1 = new System.Windows.Forms.Button();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.reactionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(348, 212);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 37);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(348, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(348, 352);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(96, 37);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(345, 120);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(99, 33);
            this.outputLabel.TabIndex = 3;
            // 
            // lightA1
            // 
            this.lightA1.BackColor = System.Drawing.Color.Silver;
            this.lightA1.Enabled = false;
            this.lightA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightA1.Location = new System.Drawing.Point(73, 77);
            this.lightA1.Name = "lightA1";
            this.lightA1.Size = new System.Drawing.Size(45, 45);
            this.lightA1.TabIndex = 4;
            this.lightA1.UseVisualStyleBackColor = false;
            // 
            // lightA2
            // 
            this.lightA2.BackColor = System.Drawing.Color.Silver;
            this.lightA2.Enabled = false;
            this.lightA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightA2.Location = new System.Drawing.Point(139, 77);
            this.lightA2.Name = "lightA2";
            this.lightA2.Size = new System.Drawing.Size(45, 45);
            this.lightA2.TabIndex = 5;
            this.lightA2.UseVisualStyleBackColor = false;
            // 
            // lightB1
            // 
            this.lightB1.BackColor = System.Drawing.Color.Silver;
            this.lightB1.Enabled = false;
            this.lightB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightB1.Location = new System.Drawing.Point(73, 166);
            this.lightB1.Name = "lightB1";
            this.lightB1.Size = new System.Drawing.Size(45, 45);
            this.lightB1.TabIndex = 6;
            this.lightB1.UseVisualStyleBackColor = false;
            // 
            // lightB2
            // 
            this.lightB2.BackColor = System.Drawing.Color.Silver;
            this.lightB2.Enabled = false;
            this.lightB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightB2.Location = new System.Drawing.Point(139, 166);
            this.lightB2.Name = "lightB2";
            this.lightB2.Size = new System.Drawing.Size(45, 45);
            this.lightB2.TabIndex = 7;
            this.lightB2.UseVisualStyleBackColor = false;
            // 
            // lightC1
            // 
            this.lightC1.BackColor = System.Drawing.Color.Silver;
            this.lightC1.Enabled = false;
            this.lightC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightC1.Location = new System.Drawing.Point(73, 255);
            this.lightC1.Name = "lightC1";
            this.lightC1.Size = new System.Drawing.Size(45, 45);
            this.lightC1.TabIndex = 8;
            this.lightC1.UseVisualStyleBackColor = false;
            // 
            // lightC2
            // 
            this.lightC2.BackColor = System.Drawing.Color.Silver;
            this.lightC2.Enabled = false;
            this.lightC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightC2.Location = new System.Drawing.Point(139, 255);
            this.lightC2.Name = "lightC2";
            this.lightC2.Size = new System.Drawing.Size(45, 45);
            this.lightC2.TabIndex = 9;
            this.lightC2.UseVisualStyleBackColor = false;
            // 
            // lightD2
            // 
            this.lightD2.BackColor = System.Drawing.Color.Gray;
            this.lightD2.Enabled = false;
            this.lightD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightD2.Location = new System.Drawing.Point(139, 344);
            this.lightD2.Name = "lightD2";
            this.lightD2.Size = new System.Drawing.Size(45, 45);
            this.lightD2.TabIndex = 10;
            this.lightD2.UseVisualStyleBackColor = false;
            // 
            // lightD1
            // 
            this.lightD1.BackColor = System.Drawing.Color.Gray;
            this.lightD1.Enabled = false;
            this.lightD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightD1.Location = new System.Drawing.Point(73, 344);
            this.lightD1.Name = "lightD1";
            this.lightD1.Size = new System.Drawing.Size(45, 45);
            this.lightD1.TabIndex = 11;
            this.lightD1.UseVisualStyleBackColor = false;
            // 
            // lightTimer
            // 
            this.lightTimer.Interval = 400;
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // reactionLabel
            // 
            this.reactionLabel.Location = new System.Drawing.Point(345, 77);
            this.reactionLabel.Name = "reactionLabel";
            this.reactionLabel.Size = new System.Drawing.Size(99, 23);
            this.reactionLabel.TabIndex = 12;
            this.reactionLabel.Text = "Reaction: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.reactionLabel);
            this.Controls.Add(this.lightD1);
            this.Controls.Add(this.lightD2);
            this.Controls.Add(this.lightC2);
            this.Controls.Add(this.lightC1);
            this.Controls.Add(this.lightB2);
            this.Controls.Add(this.lightB1);
            this.Controls.Add(this.lightA2);
            this.Controls.Add(this.lightA1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Racing Tree";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button lightA1;
        private System.Windows.Forms.Button lightA2;
        private System.Windows.Forms.Button lightB1;
        private System.Windows.Forms.Button lightB2;
        private System.Windows.Forms.Button lightC1;
        private System.Windows.Forms.Button lightC2;
        private System.Windows.Forms.Button lightD2;
        private System.Windows.Forms.Button lightD1;
        private System.Windows.Forms.Timer lightTimer;
        private System.Windows.Forms.Label reactionLabel;
    }
}

