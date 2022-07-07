
namespace yoketoruvs22
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(222, 66);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 53);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2022";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(240, 290);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(335, 105);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(255, 413);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(262, 28);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright  © 2022 杉田夏葵";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(6, 3);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(113, 32);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftLabel.Location = new System.Drawing.Point(719, 3);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(69, 32);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "★:10";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highLabel.Location = new System.Drawing.Point(291, 178);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(167, 32);
            this.highLabel.TabIndex = 5;
            this.highLabel.Text = "ハイスコア　100";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.Location = new System.Drawing.Point(240, 142);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(268, 68);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "GameOver";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.Location = new System.Drawing.Point(282, 149);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(205, 68);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "CLEAR!!";
            // 
            // titleButton
            // 
            this.titleButton.Font = new System.Drawing.Font("Yu Gothic UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.Location = new System.Drawing.Point(240, 290);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(335, 104);
            this.titleButton.TabIndex = 8;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titleButton;
    }
}

