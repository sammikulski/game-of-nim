namespace GameOfNim
{
    partial class frmGameOfNim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOfNim));
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTurnIndicator = new System.Windows.Forms.Label();
            this.lblReadyMessage = new System.Windows.Forms.Label();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeDirections = new System.Windows.Forms.Label();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.txtFirstPlayerName = new System.Windows.Forms.TextBox();
            this.txtSecondPlayerName = new System.Windows.Forms.TextBox();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.btnFirstPlayerOK = new System.Windows.Forms.Button();
            this.btnSecondPlayerOK = new System.Windows.Forms.Button();
            this.btnTurnComplete = new System.Windows.Forms.Button();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Pink;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(21, 629);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(160, 33);
            this.btnPlayAgain.TabIndex = 36;
            this.btnPlayAgain.Text = "Let\'s Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInstructions.Location = new System.Drawing.Point(50, 313);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(635, 24);
            this.lblInstructions.TabIndex = 38;
            this.lblInstructions.Text = "Click on a Row button. Select any one or more marbles to take. Click Done.";
            // 
            // lblTurnIndicator
            // 
            this.lblTurnIndicator.AutoSize = true;
            this.lblTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnIndicator.Location = new System.Drawing.Point(233, 276);
            this.lblTurnIndicator.Name = "lblTurnIndicator";
            this.lblTurnIndicator.Size = new System.Drawing.Size(116, 20);
            this.lblTurnIndicator.TabIndex = 39;
            this.lblTurnIndicator.Text = "It\'s Your Turn...";
            // 
            // lblReadyMessage
            // 
            this.lblReadyMessage.AutoSize = true;
            this.lblReadyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyMessage.Location = new System.Drawing.Point(147, 232);
            this.lblReadyMessage.Name = "lblReadyMessage";
            this.lblReadyMessage.Size = new System.Drawing.Size(280, 20);
            this.lblReadyMessage.TabIndex = 40;
            this.lblReadyMessage.Text = "When ready to play, click this button-->";
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLetsPlay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLetsPlay.Location = new System.Drawing.Point(453, 226);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(134, 31);
            this.btnLetsPlay.TabIndex = 41;
            this.btnLetsPlay.Text = "Let\'s Play";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnQuit.Location = new System.Drawing.Point(465, 629);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(104, 33);
            this.btnQuit.TabIndex = 42;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(147, 8);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(440, 39);
            this.lblWelcomeTitle.TabIndex = 43;
            this.lblWelcomeTitle.Text = "Welcome to the Game of Nim";
            // 
            // lblWelcomeDirections
            // 
            this.lblWelcomeDirections.AutoSize = true;
            this.lblWelcomeDirections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcomeDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDirections.Location = new System.Drawing.Point(67, 52);
            this.lblWelcomeDirections.Name = "lblWelcomeDirections";
            this.lblWelcomeDirections.Size = new System.Drawing.Size(601, 60);
            this.lblWelcomeDirections.TabIndex = 44;
            this.lblWelcomeDirections.Text = resources.GetString("lblWelcomeDirections.Text");
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.Location = new System.Drawing.Point(140, 130);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(156, 20);
            this.lblFirstPlayerName.TabIndex = 45;
            this.lblFirstPlayerName.Text = "First Player Name -->";
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.Location = new System.Drawing.Point(116, 177);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(180, 20);
            this.lblSecondPlayerName.TabIndex = 46;
            this.lblSecondPlayerName.Text = "Second Player Name -->";
            // 
            // txtFirstPlayerName
            // 
            this.txtFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtFirstPlayerName.Location = new System.Drawing.Point(359, 130);
            this.txtFirstPlayerName.Name = "txtFirstPlayerName";
            this.txtFirstPlayerName.Size = new System.Drawing.Size(124, 21);
            this.txtFirstPlayerName.TabIndex = 47;
            // 
            // txtSecondPlayerName
            // 
            this.txtSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtSecondPlayerName.Location = new System.Drawing.Point(359, 179);
            this.txtSecondPlayerName.Name = "txtSecondPlayerName";
            this.txtSecondPlayerName.Size = new System.Drawing.Size(124, 21);
            this.txtSecondPlayerName.TabIndex = 48;
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Location = new System.Drawing.Point(402, 276);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 49;
            // 
            // btnFirstPlayerOK
            // 
            this.btnFirstPlayerOK.BackColor = System.Drawing.Color.Yellow;
            this.btnFirstPlayerOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFirstPlayerOK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFirstPlayerOK.Location = new System.Drawing.Point(546, 120);
            this.btnFirstPlayerOK.Name = "btnFirstPlayerOK";
            this.btnFirstPlayerOK.Size = new System.Drawing.Size(72, 39);
            this.btnFirstPlayerOK.TabIndex = 78;
            this.btnFirstPlayerOK.Text = "OK";
            this.btnFirstPlayerOK.UseVisualStyleBackColor = false;
            this.btnFirstPlayerOK.Click += new System.EventHandler(this.btnFirstPlayerOK_Click);
            // 
            // btnSecondPlayerOK
            // 
            this.btnSecondPlayerOK.BackColor = System.Drawing.Color.Yellow;
            this.btnSecondPlayerOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSecondPlayerOK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSecondPlayerOK.Location = new System.Drawing.Point(546, 169);
            this.btnSecondPlayerOK.Name = "btnSecondPlayerOK";
            this.btnSecondPlayerOK.Size = new System.Drawing.Size(72, 39);
            this.btnSecondPlayerOK.TabIndex = 79;
            this.btnSecondPlayerOK.Text = "OK";
            this.btnSecondPlayerOK.UseVisualStyleBackColor = false;
            this.btnSecondPlayerOK.Click += new System.EventHandler(this.btnSecondPlayerOK_Click);
            // 
            // btnTurnComplete
            // 
            this.btnTurnComplete.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTurnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTurnComplete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTurnComplete.Location = new System.Drawing.Point(606, 500);
            this.btnTurnComplete.Name = "btnTurnComplete";
            this.btnTurnComplete.Size = new System.Drawing.Size(111, 87);
            this.btnTurnComplete.TabIndex = 80;
            this.btnTurnComplete.Text = "I\'ve Completed My Turn";
            this.btnTurnComplete.UseVisualStyleBackColor = false;
            this.btnTurnComplete.Click += new System.EventHandler(this.btnTurnComplete_Click);
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(21, 352);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(548, 278);
            this.panelBoard.TabIndex = 81;
            // 
            // frmGameOfNim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 687);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.btnTurnComplete);
            this.Controls.Add(this.btnSecondPlayerOK);
            this.Controls.Add(this.btnFirstPlayerOK);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.txtSecondPlayerName);
            this.Controls.Add(this.txtFirstPlayerName);
            this.Controls.Add(this.lblSecondPlayerName);
            this.Controls.Add(this.lblFirstPlayerName);
            this.Controls.Add(this.lblWelcomeDirections);
            this.Controls.Add(this.lblWelcomeTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.lblReadyMessage);
            this.Controls.Add(this.lblTurnIndicator);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnPlayAgain);
            this.Name = "frmGameOfNim";
            this.Text = "Game of Nim";
            this.Load += new System.EventHandler(this.frmGameOfNim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTurnIndicator;
        private System.Windows.Forms.Label lblReadyMessage;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblWelcomeDirections;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.TextBox txtFirstPlayerName;
        private System.Windows.Forms.TextBox txtSecondPlayerName;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Button btnFirstPlayerOK;
        private System.Windows.Forms.Button btnSecondPlayerOK;
        private System.Windows.Forms.Button btnTurnComplete;
        private System.Windows.Forms.Panel panelBoard;
    }
}

