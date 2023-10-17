namespace Spell_A_Man
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.txtTimerTick = new System.Windows.Forms.TextBox();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.pboxHint = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblUnfinished = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.RadioButton();
            this.L2 = new System.Windows.Forms.RadioButton();
            this.L3 = new System.Windows.Forms.RadioButton();
            this.L4 = new System.Windows.Forms.RadioButton();
            this.L5 = new System.Windows.Forms.RadioButton();
            this.L6 = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.pboxTimer = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.tipAll = new System.Windows.Forms.ToolTip(this.components);
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.TimerTock = new System.Windows.Forms.Timer(this.components);
            this.pEffects = new System.Windows.Forms.PictureBox();
            this.pEf = new System.Windows.Forms.PictureBox();
            this.pShark = new System.Windows.Forms.PictureBox();
            this.pAstro = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.pHula = new System.Windows.Forms.PictureBox();
            this.pHawaii = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEffects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAstro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHawaii)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimerTick
            // 
            this.txtTimerTick.BackColor = System.Drawing.Color.DarkRed;
            this.txtTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimerTick.Enabled = false;
            this.txtTimerTick.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerTick.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTimerTick.Location = new System.Drawing.Point(83, 65);
            this.txtTimerTick.Name = "txtTimerTick";
            this.txtTimerTick.ReadOnly = true;
            this.txtTimerTick.Size = new System.Drawing.Size(100, 34);
            this.txtTimerTick.TabIndex = 13;
            this.txtTimerTick.Text = "0";
            this.txtTimerTick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimerTick.TextChanged += new System.EventHandler(this.txtTimerTick_TextChanged);
            // 
            // btnNewWord
            // 
            this.btnNewWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewWord.BackColor = System.Drawing.Color.Crimson;
            this.btnNewWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewWord.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWord.Location = new System.Drawing.Point(961, 282);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(223, 133);
            this.btnNewWord.TabIndex = 0;
            this.btnNewWord.Text = "NEW WORD";
            this.btnNewWord.UseVisualStyleBackColor = false;
            this.btnNewWord.Visible = false;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // btnHint
            // 
            this.btnHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHint.BackColor = System.Drawing.Color.Green;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHint.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(1013, 211);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(143, 51);
            this.btnHint.TabIndex = 1;
            this.btnHint.Text = "HINT";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Visible = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // pboxHint
            // 
            this.pboxHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxHint.BackColor = System.Drawing.Color.Transparent;
            this.pboxHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxHint.Location = new System.Drawing.Point(961, 21);
            this.pboxHint.Name = "pboxHint";
            this.pboxHint.Size = new System.Drawing.Size(223, 163);
            this.pboxHint.TabIndex = 2;
            this.pboxHint.TabStop = false;
            this.pboxHint.Visible = false;
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWord.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblWord.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWord.Location = new System.Drawing.Point(1, 359);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(348, 119);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "WORD";
            this.lblWord.Visible = false;
            // 
            // lblUnfinished
            // 
            this.lblUnfinished.AutoSize = true;
            this.lblUnfinished.BackColor = System.Drawing.Color.Transparent;
            this.lblUnfinished.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfinished.ForeColor = System.Drawing.Color.Gold;
            this.lblUnfinished.Location = new System.Drawing.Point(198, 26);
            this.lblUnfinished.Name = "lblUnfinished";
            this.lblUnfinished.Size = new System.Drawing.Size(367, 119);
            this.lblUnfinished.TabIndex = 4;
            this.lblUnfinished.Text = "CORNY";
            this.lblUnfinished.Click += new System.EventHandler(this.lblUnfinished_Click);
            // 
            // L1
            // 
            this.L1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.Orange;
            this.L1.Location = new System.Drawing.Point(535, 488);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(123, 114);
            this.L1.TabIndex = 6;
            this.L1.TabStop = true;
            this.L1.Text = "1";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L1.UseVisualStyleBackColor = false;
            this.L1.Visible = false;
            // 
            // L2
            // 
            this.L2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.Color.LimeGreen;
            this.L2.Location = new System.Drawing.Point(83, 368);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(123, 114);
            this.L2.TabIndex = 7;
            this.L2.TabStop = true;
            this.L2.Text = "2";
            this.L2.UseVisualStyleBackColor = false;
            this.L2.Visible = false;
            // 
            // L3
            // 
            this.L3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L3.AutoSize = true;
            this.L3.BackColor = System.Drawing.Color.Transparent;
            this.L3.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.ForeColor = System.Drawing.Color.Pink;
            this.L3.Location = new System.Drawing.Point(644, 188);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(123, 114);
            this.L3.TabIndex = 8;
            this.L3.TabStop = true;
            this.L3.Text = "3";
            this.L3.UseVisualStyleBackColor = false;
            this.L3.Visible = false;
            // 
            // L4
            // 
            this.L4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L4.AutoSize = true;
            this.L4.BackColor = System.Drawing.Color.Transparent;
            this.L4.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L4.ForeColor = System.Drawing.Color.Crimson;
            this.L4.Location = new System.Drawing.Point(628, 344);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(123, 114);
            this.L4.TabIndex = 9;
            this.L4.TabStop = true;
            this.L4.Text = "4";
            this.L4.UseVisualStyleBackColor = false;
            this.L4.Visible = false;
            // 
            // L5
            // 
            this.L5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L5.AutoSize = true;
            this.L5.BackColor = System.Drawing.Color.Transparent;
            this.L5.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L5.ForeColor = System.Drawing.Color.Yellow;
            this.L5.Location = new System.Drawing.Point(201, 575);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(123, 114);
            this.L5.TabIndex = 10;
            this.L5.TabStop = true;
            this.L5.Text = "5";
            this.L5.UseVisualStyleBackColor = false;
            this.L5.Visible = false;
            // 
            // L6
            // 
            this.L6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L6.AutoSize = true;
            this.L6.BackColor = System.Drawing.Color.Transparent;
            this.L6.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L6.ForeColor = System.Drawing.Color.Red;
            this.L6.Location = new System.Drawing.Point(201, 211);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(123, 114);
            this.L6.TabIndex = 11;
            this.L6.TabStop = true;
            this.L6.Text = "6";
            this.L6.UseVisualStyleBackColor = false;
            this.L6.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Jokerman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(565, 698);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 39);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // pboxTimer
            // 
            this.pboxTimer.BackColor = System.Drawing.Color.Transparent;
            this.pboxTimer.Image = global::Spell_A_Man.Properties.Resources.iconfinder_icon_24_stop_watch_316185;
            this.pboxTimer.Location = new System.Drawing.Point(31, 65);
            this.pboxTimer.Name = "pboxTimer";
            this.pboxTimer.Size = new System.Drawing.Size(54, 34);
            this.pboxTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTimer.TabIndex = 14;
            this.pboxTimer.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1072, 695);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(76, 103);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(41, 17);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "Level";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTheme.Location = new System.Drawing.Point(28, 9);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(45, 17);
            this.lblTheme.TabIndex = 17;
            this.lblTheme.Text = "Theme";
            // 
            // tipAll
            // 
            this.tipAll.AutoPopDelay = 5000;
            this.tipAll.InitialDelay = 50;
            this.tipAll.ReshowDelay = 10;
            // 
            // btnON
            // 
            this.btnON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnON.BackColor = System.Drawing.Color.Transparent;
            this.btnON.BackgroundImage = global::Spell_A_Man.Properties.Resources.iconfinder_6_Google_Play_Music_Google_Product_Logo_Brand_5764255;
            this.btnON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnON.FlatAppearance.BorderSize = 0;
            this.btnON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnON.ForeColor = System.Drawing.Color.Transparent;
            this.btnON.Location = new System.Drawing.Point(12, 695);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(43, 37);
            this.btnON.TabIndex = 18;
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Visible = false;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOFF.BackColor = System.Drawing.Color.Transparent;
            this.btnOFF.BackgroundImage = global::Spell_A_Man.Properties.Resources.iconfinder_43_Microsoft_Groove_Music_5764207;
            this.btnOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOFF.FlatAppearance.BorderSize = 0;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOFF.Location = new System.Drawing.Point(12, 695);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(43, 37);
            this.btnOFF.TabIndex = 19;
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // TimerTock
            // 
            this.TimerTock.Interval = 1000;
            this.TimerTock.Tick += new System.EventHandler(this.TimerTock_Tick);
            // 
            // pEffects
            // 
            this.pEffects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pEffects.BackColor = System.Drawing.Color.Transparent;
            this.pEffects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pEffects.Image = global::Spell_A_Man.Properties.Resources.star;
            this.pEffects.Location = new System.Drawing.Point(33, 507);
            this.pEffects.Name = "pEffects";
            this.pEffects.Size = new System.Drawing.Size(146, 182);
            this.pEffects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEffects.TabIndex = 20;
            this.pEffects.TabStop = false;
            this.pEffects.Visible = false;
            // 
            // pEf
            // 
            this.pEf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pEf.BackColor = System.Drawing.Color.Transparent;
            this.pEf.Image = ((System.Drawing.Image)(resources.GetObject("pEf.Image")));
            this.pEf.Location = new System.Drawing.Point(2, 188);
            this.pEf.Name = "pEf";
            this.pEf.Size = new System.Drawing.Size(181, 139);
            this.pEf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEf.TabIndex = 21;
            this.pEf.TabStop = false;
            this.pEf.Visible = false;
            // 
            // pShark
            // 
            this.pShark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pShark.BackColor = System.Drawing.Color.Transparent;
            this.pShark.Image = global::Spell_A_Man.Properties.Resources.shark;
            this.pShark.Location = new System.Drawing.Point(991, 478);
            this.pShark.Name = "pShark";
            this.pShark.Size = new System.Drawing.Size(193, 130);
            this.pShark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pShark.TabIndex = 22;
            this.pShark.TabStop = false;
            this.pShark.Visible = false;
            // 
            // pAstro
            // 
            this.pAstro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pAstro.BackColor = System.Drawing.Color.Transparent;
            this.pAstro.Image = global::Spell_A_Man.Properties.Resources.twerk;
            this.pAstro.Location = new System.Drawing.Point(991, 478);
            this.pAstro.Name = "pAstro";
            this.pAstro.Size = new System.Drawing.Size(193, 168);
            this.pAstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAstro.TabIndex = 23;
            this.pAstro.TabStop = false;
            this.pAstro.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(17, 29);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 30);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "SCORE:";
            this.lblScore.Visible = false;
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.BackColor = System.Drawing.Color.Transparent;
            this.lblNums.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNums.ForeColor = System.Drawing.Color.Transparent;
            this.lblNums.Location = new System.Drawing.Point(116, 21);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(59, 43);
            this.lblNums.TabIndex = 25;
            this.lblNums.Text = "00";
            this.lblNums.Visible = false;
            // 
            // pHula
            // 
            this.pHula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pHula.BackColor = System.Drawing.Color.Transparent;
            this.pHula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pHula.Image = global::Spell_A_Man.Properties.Resources.man;
            this.pHula.Location = new System.Drawing.Point(2, 488);
            this.pHula.Name = "pHula";
            this.pHula.Size = new System.Drawing.Size(146, 182);
            this.pHula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHula.TabIndex = 26;
            this.pHula.TabStop = false;
            this.pHula.Visible = false;
            // 
            // pHawaii
            // 
            this.pHawaii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pHawaii.BackColor = System.Drawing.Color.Transparent;
            this.pHawaii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pHawaii.Image = global::Spell_A_Man.Properties.Resources.girl;
            this.pHawaii.Location = new System.Drawing.Point(839, 575);
            this.pHawaii.Name = "pHawaii";
            this.pHawaii.Size = new System.Drawing.Size(146, 162);
            this.pHawaii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHawaii.TabIndex = 27;
            this.pHawaii.TabStop = false;
            this.pHawaii.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spell_A_Man.Properties.Resources.space_genetics_is_essential_making_life_in_space_work;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 746);
            this.Controls.Add(this.pHawaii);
            this.Controls.Add(this.pHula);
            this.Controls.Add(this.lblNums);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pAstro);
            this.Controls.Add(this.pShark);
            this.Controls.Add(this.pEf);
            this.Controls.Add(this.pEffects);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pboxTimer);
            this.Controls.Add(this.txtTimerTick);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.lblUnfinished);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pboxHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnNewWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.Text = "Spell-A-Man";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEffects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAstro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHawaii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.PictureBox pboxHint;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.RadioButton L1;
        private System.Windows.Forms.RadioButton L2;
        private System.Windows.Forms.RadioButton L3;
        private System.Windows.Forms.RadioButton L4;
        private System.Windows.Forms.RadioButton L5;
        private System.Windows.Forms.RadioButton L6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pboxTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ToolTip tipAll;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Timer TimerTock;
        private System.Windows.Forms.TextBox txtTimerTick;
        private System.Windows.Forms.Label lblUnfinished;
        private System.Windows.Forms.PictureBox pEffects;
        private System.Windows.Forms.PictureBox pEf;
        private System.Windows.Forms.PictureBox pShark;
        private System.Windows.Forms.PictureBox pAstro;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.PictureBox pHula;
        private System.Windows.Forms.PictureBox pHawaii;
    }
}