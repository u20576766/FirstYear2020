namespace Spell_A_Man
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumss = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pLose = new System.Windows.Forms.PictureBox();
            this.pWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(125, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(571, 96);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "GAME OVER";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(269, 45);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(147, 35);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "SCORE:";
            // 
            // lblNumss
            // 
            this.lblNumss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumss.AutoSize = true;
            this.lblNumss.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumss.Location = new System.Drawing.Point(411, 45);
            this.lblNumss.Name = "lblNumss";
            this.lblNumss.Size = new System.Drawing.Size(125, 35);
            this.lblNumss.TabIndex = 2;
            this.lblNumss.Text = "SCORE";
            this.lblNumss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(260, 487);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(298, 70);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pLose
            // 
            this.pLose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLose.BackColor = System.Drawing.Color.White;
            this.pLose.Image = global::Spell_A_Man.Properties.Resources.loser2;
            this.pLose.Location = new System.Drawing.Point(283, 280);
            this.pLose.Name = "pLose";
            this.pLose.Size = new System.Drawing.Size(253, 174);
            this.pLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pLose.TabIndex = 7;
            this.pLose.TabStop = false;
            this.pLose.Visible = false;
            // 
            // pWin
            // 
            this.pWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWin.BackColor = System.Drawing.Color.Transparent;
            this.pWin.Image = global::Spell_A_Man.Properties.Resources.trophy2;
            this.pWin.Location = new System.Drawing.Point(283, 280);
            this.pWin.Name = "pWin";
            this.pWin.Size = new System.Drawing.Size(253, 174);
            this.pWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pWin.TabIndex = 6;
            this.pWin.TabStop = false;
            this.pWin.Visible = false;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.pLose);
            this.Controls.Add(this.pWin);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblNumss);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameOver";
            this.Text = "GameOver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumss;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pLose;
        private System.Windows.Forms.PictureBox pWin;
    }
}