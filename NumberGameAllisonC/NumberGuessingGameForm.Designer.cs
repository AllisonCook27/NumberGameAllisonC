namespace NumberGameAllisonC
{
    partial class frmNumberGuessingGame
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
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblright = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.White;
            this.lblWrong.Location = new System.Drawing.Point(28, 198);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(144, 20);
            this.lblWrong.TabIndex = 0;
            this.lblWrong.Text = "Sorry, guess agian.";
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblright.ForeColor = System.Drawing.Color.White;
            this.lblright.Location = new System.Drawing.Point(28, 198);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(116, 20);
            this.lblright.TabIndex = 1;
            this.lblright.Text = "You got it right!";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.ForeColor = System.Drawing.Color.White;
            this.lblGuess.Location = new System.Drawing.Point(24, 59);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(266, 20);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "Guess a number between 1 and 10 :";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(180, 123);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 27);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(445, 24);
            this.mnuMenu.TabIndex = 4;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // picCheck
            // 
            this.picCheck.BackColor = System.Drawing.Color.DarkGreen;
            this.picCheck.Location = new System.Drawing.Point(293, 161);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(116, 70);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 5;
            this.picCheck.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(324, 61);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 6;
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmNumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblright);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmNumberGuessingGame";
            this.Text = "Number Guessing game by Allison C";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.TextBox txtInput;
    }
}

