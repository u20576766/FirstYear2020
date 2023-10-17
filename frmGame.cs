using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Spell_A_Man
{
    public partial class frmGame : Form
    {
        public static string passingTouch;
        public frmGame()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle = 0x02000000;
                return handleParams;
            }
        }
        public void lblUnfinished_Click(object sender, EventArgs e)
        {
            //Declare variables
            string theme = lblTheme.Text;
            string level = lblLevel.Text;

            //When the word corney is clicked the game will activate itself and start
            lblScore.Visible = true;
            lblNums.Visible = true;

            lblName.Text = frmPlayerDetails.passingText; lblName.Visible = true;
            L1.Visible = true; L2.Visible = true; L3.Visible = true; L4.Visible = true; L5.Visible = true; L6.Visible = true;
            btnNewWord.Visible = true;

            //When the label is clicked the timer will begin
            TimerTock.Start();


            //if statement for each theme when game begins
            if (level == "Beginner")
            {
                if (theme == "ASTRONOMY")
                {
                    lblUnfinished.Text = "C R A _ E R";
                    L1.Text = "B"; L2.Text = "D"; L3.Text = "T"; L4.Text = "S"; L5.Text = "V"; L6.Text = "F";
                }
                if (theme == "AQUA")
                {
                    lblUnfinished.Text = "S C _ O O L";
                    L1.Text = "B"; L2.Text = "D"; L3.Text = "T"; L4.Text = "S"; L5.Text = "V"; L6.Text = "H";
                }
            }
            else if (level == "Intermediate")
            {
                if (theme == "ASTRONOMY")
                {
                    lblUnfinished.Text = "C_N_TEL_ATION";
                    L1.Text = "E'P'S"; L2.Text = "O'P'S"; L3.Text = "A'T'P"; L4.Text = "O'S'L"; L5.Text = "O'L'S"; L6.Text = "E'S'L";
                }
                if (theme == "AQUA")
                {
                    lblUnfinished.Text = "S U _ _ A R I N E";
                    L1.Text = "B'M"; L2.Text = "D'V"; L3.Text = "T'F"; L4.Text = "S'H"; L5.Text = "V'M"; L6.Text = "H'N";
                }
            }
            else if (level == "Advanced")
            {
                if (theme == "ASTRONOMY")
                {
                    lblUnfinished.Text = "B _ G  _ A N G";
                    L1.Text = "E'P"; L2.Text = "O'P"; L3.Text = "A'T"; L4.Text = "O'S"; L5.Text = "O'L"; L6.Text = "I'B";
                }
                if (theme == "AQUA")
                {
                    lblUnfinished.Text = "_ A _ R _ S";
                    L1.Text = "B'M'I"; L2.Text = "W'L'U"; L3.Text = "T'F'U"; L4.Text = "S'H'O"; L5.Text = "V'M'E"; L6.Text = "H'N'O";
                }
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            frmCover.player.controls.stop();
            if (btnOFF.Enabled)
            {
                btnON.Visible = true;
                btnOFF.Visible = false;
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            frmCover.player.controls.play();
            if (btnON.Enabled)
            {
                btnON.Visible = false;
                btnOFF.Visible = true;
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            //Countdown timer is enabled
            ToolTip tipAll = new ToolTip();
            tipAll.ShowAlways = true;
            tipAll.SetToolTip(this.btnOFF, "Sound OFF");
            tipAll.SetToolTip(this.btnON, "Sound ON");

            //Theme label is visible when game starts
            lblTheme.Text = frmPlayerDetails.passingTheme;
            lblLevel.Text = frmPlayerDetails.passingLevel;
            


            //if statements for theme choice
            if (lblTheme.Text == "AQUA")
            {
                if(lblLevel.Text == "Intermediate")
                {
                    frmCover.player.URL = "Ocean.mp3";
                    frmCover.player.controls.play();
                    this.BackgroundImage = Properties.Resources.aqua5;
                    pShark.Visible = true;
                }
                if(lblLevel.Text == "Advanced")
                {
                    frmCover.player.URL = "Under the Sea.mp3";
                    frmCover.player.controls.play();
                    this.BackgroundImage = Properties.Resources.bubbles;
                    pShark.Visible = true;pHula.Visible = true;pHawaii.Visible = true;
                }
                if (lblLevel.Text == "Beginner")
                {
                    frmCover.player.URL = "Martin Garrix-Ocean.mp3";
                    frmCover.player.controls.play();
                    this.BackgroundImage = Properties.Resources.aqua3;
                }
               
                pEffects.Visible = false;pEf.Visible = true;pShark.Visible = true;
            }
            else if (lblTheme.Text == "ASTRONOMY")
            {
                if(lblLevel.Text == "Intermediate")
                {
                    this.BackgroundImage = Properties.Resources.astro;
                    pAstro.Visible = true;
                    frmCover.player.URL = "Stars.mp3";
                    frmCover.player.controls.play();
                }
                if (lblLevel.Text == "Advanced")
                {
                    this.BackgroundImage = Properties.Resources.astro2;
                    pAstro.Visible = true;
                    frmCover.player.URL = "Kygo-Stargazing.mp3";
                    frmCover.player.controls.play();

                }
                if (lblLevel.Text == "Beginner")
                {
                    frmCover.player.URL = "The Galaxy - The Galaxy.mp3";
                    frmCover.player.controls.play();
                    this.BackgroundImage = Properties.Resources.guy;
                }
               
                pEffects.Visible = true;pEf.Visible = false;pShark.Visible = false;
            }
            
        }

        private void TimerTock_Tick(object sender, EventArgs e)
        {
            //Show timer ticks on textbox
            int counter = Convert.ToInt32(txtTimerTick.Text);
            counter++;
            txtTimerTick.Text = Convert.ToString(counter);

            if (txtTimerTick.Text == "60")
                TimerTock.Stop();
          
        }

        private void txtTimerTick_TextChanged(object sender, EventArgs e)
        {
            //Declare variables
            string theme = lblTheme.Text;
            string level = lblLevel.Text;
            string count = txtTimerTick.Text;
            int score;

            //Show score in textbox
            score = Convert.ToInt32(lblNums.Text);

            //Hint button and hint picturbox appearance
            if (count == "5" || count == "55" || count == "15" || count == "25" || count == "35" || count == "45")
            {
                btnHint.Visible = true;
            }
            if (count == "10" || count == "30" || count == "40" || count == "60" || count == "50" || count == "20")
            {
                btnHint.Visible = false;
                pboxHint.Visible = false;
            }

            //Game
            if (level == "Beginner" || level == "Intermediate" || level == "Advanced")
            {
                if (theme == "ASTRONOMY")
                {
                    if (lblUnfinished.Text == "C R A _ E R" && L3.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "CRATER!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "E C _ I P S E" && L1.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ECLIPSE!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "_ O O N" && L5.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "MOON!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "O _ B I T" && L2.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ORBIT!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "L U N _ R" && L1.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "LUNAR!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "W A _ I N G" && L5.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "WANING!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "C_N_TEL_ATION" && L4.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "CONSTELLATION!";
                        lblNums.Text = Convert.ToString(score + 10);
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "M E _ E O _ O _ D" && L3.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "METEOROID!";
                        lblNums.Text = Convert.ToString(score + 10);
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "_ R A V _ T Y" && L2.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "GRAVITY!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "_ O _ I A _" && L1.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ZODIAC!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "A _ I _ N" && L6.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ALIEN!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "_ A L A _ Y" && L5.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "GALAXY!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "B _ G  _ A N G" && L6.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "BING BANG!";
                        lblNums.Text = Convert.ToString(score + 10);
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "_ U _ E _ _ O V A" && L5.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "SUPERNOVA!";
                        lblNums.Text = Convert.ToString(score + 10);
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                    else if (lblUnfinished.Text == "I _ E R T I _" && L3.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "INERTIA!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "_ E _ U _ A" && L2.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "NEBULA!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "A _ T R _ _ O M E R" && L4.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ASTRONOMER!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "_ O S _ O N _ U T" && L1.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "COSMONAUT!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;

                    }
                }
                if (theme == "AQUA")
                {
                    if (lblUnfinished.Text == "S C _ O O L" && L6.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "SCHOOL!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "C _ A B" && L2.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "CRAB!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "A L _ A E" && L3.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "ALGAE!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "S _ U I D" && L4.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "SQUID!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "D O L _ H I N" && L1.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "DOLPHIN!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    else if (lblUnfinished.Text == "C O _ A L" && L5.Checked)
                    {
                        TimerTock.Stop();
                        lblUnfinished.Visible = false; lblWord.Visible = true;
                        lblWord.Text = "CORAL!";
                        lblNums.Text = Convert.ToString(score + 10);
                        score += 10;
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    }
                    if (level == "Intermediate")
                        if (lblUnfinished.Text == "S U _ _ A R I N E" && L1.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "SUBMARINE!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                        else if (lblUnfinished.Text == "P L A _ _ T O N" && L4.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "PLANKTON!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                        else if (lblUnfinished.Text == "_ U S _ E L S" && L6.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "MUSSELS!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                        else if (lblUnfinished.Text == "S E A _ _ _ D" && L2.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "SEAWEED!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                        else if (lblUnfinished.Text == "S _ I P _ R E _ K" && L3.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "SHIPWRECK!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                        else if (lblUnfinished.Text == "N A _ T _ _ U S" && L5.Checked)
                        {
                            TimerTock.Stop();
                            lblUnfinished.Visible = false; lblWord.Visible = true;
                            lblWord.Text = "NAUTILUS!";
                            lblNums.Text = Convert.ToString(score + 10);
                            score += 10;
                            L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        }
                }

            }
            if (level == "Advanced")
                if (lblUnfinished.Text == "_ A _ R _ S" && L2.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "WALRUS!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
                else if (lblUnfinished.Text == "S E _ L _ O _" && L6.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "SEALION!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
                else if (lblUnfinished.Text == "C _ O _ N F I _ H" && L4.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "CLOWNFISH!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
                else if (lblUnfinished.Text == "_ I G E _ SHARK" && L5.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "TIGER SHARK!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
                else if (lblUnfinished.Text == "_ T _ E R" && L1.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "OTTER!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
                else if (lblUnfinished.Text == "CO_ _AC_NTH" && L3.Checked)
                {
                    TimerTock.Stop();
                    lblUnfinished.Visible = false; lblWord.Visible = true;
                    lblWord.Text = "COELACANTH!";
                    lblNums.Text = Convert.ToString(score + 10);
                    score += 10;
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                }
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            //Declare variables
            string theme = lblTheme.Text;
            string level = lblLevel.Text;
            btnHint.Visible = false;
            pboxHint.Visible = false;
            L1.Visible = true; L2.Visible = true; L3.Visible = true; L4.Visible = true; L5.Visible = true; L6.Visible = true;

            //Game plan for different themes
            if (level == "Beginner")
            {
                if (theme == "ASTRONOMY")
                {
                    if (lblUnfinished.Text == "C R A _ E R" && L3.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "E C _ I P S E";
                        L1.Text = "L"; L2.Text = "D"; L3.Text = "T"; L4.Text = "S"; L5.Text = "V"; L6.Text = "F";

                    }
                    else if (lblUnfinished.Text == "E C _ I P S E" && L1.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "_ O O N";
                        L1.Text = "L"; L2.Text = "D"; L3.Text = "S"; L4.Text = "N"; L5.Text = "M"; L6.Text = "F";
                    }
                    else if (lblUnfinished.Text == "_ O O N" && L5.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "O _ B I T";
                        L1.Text = "Z"; L2.Text = "R"; L3.Text = "P"; L4.Text = "C"; L5.Text = "A"; L6.Text = "M";
                    }
                    else if (lblUnfinished.Text == "O _ B I T" && L2.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "L U N _ R";
                        L1.Text = "A"; L2.Text = "P"; L3.Text = "R"; L4.Text = "M"; L5.Text = "O"; L6.Text = "L";
                    }
                    else if (lblUnfinished.Text == "L U N _ R" && L1.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "W A _ I N G";
                        L1.Text = "Z"; L2.Text = "R"; L3.Text = "P"; L4.Text = "C"; L5.Text = "N"; L6.Text = "M";
                    }
                    else if (lblUnfinished.Text == "W A _ I N G" && L5.Checked)
                    {
                        //Reset timer
                        lblWord.Visible = false;
                        this.BackgroundImage = Properties.Resources.astro;
                        pAstro.Visible = true;
                        frmCover.player.URL = "Stars.mp3";
                        frmCover.player.controls.play();
                        lblUnfinished.Text = "CORNY"; lblUnfinished.Visible = true; btnHint.Visible = false; pboxHint.Visible = false;
                        lblLevel.Text = "Intermediate";
                        txtTimerTick.Text = "0";
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        MessageBox.Show("YOU HAVE COMPLETED THE BEGINNER LEVEL OF BEING AN ASTRONAUT, LETS SEE IF YOU CAN DO SOMETHING HARDER " + lblName.Text + "!!! NOW TOUCH THE WORD CORNY TO CONTINUE YOUR QUEST!!!");

                    }
                }
                if (theme == "AQUA")
                {
                    if (lblUnfinished.Text == "S C _ O O L" && L6.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "C _ A B";
                        L1.Text = "Z"; L2.Text = "R"; L3.Text = "P"; L4.Text = "C"; L5.Text = "A"; L6.Text = "M";
                    }
                    else if (lblUnfinished.Text == "C _ A B" && L2.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "A L _ A E";
                        L1.Text = "B"; L2.Text = "P"; L3.Text = "G"; L4.Text = "I"; L5.Text = "N"; L6.Text = "O";
                    }
                    else if (lblUnfinished.Text == "A L _ A E" && L3.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "S _ U I D";
                        L1.Text = "P"; L2.Text = "J"; L3.Text = "H"; L4.Text = "Q"; L5.Text = "I"; L6.Text = "O";
                    }
                    else if (lblUnfinished.Text == "S _ U I D" && L4.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "D O L _ H I N";
                        L1.Text = "P"; L2.Text = "I"; L3.Text = "M"; L4.Text = "L"; L5.Text = "T"; L6.Text = "O";
                    }
                    else if (lblUnfinished.Text == "D O L _ H I N" && L1.Checked)
                    {
                        TimerTock.Start();
                        lblUnfinished.Visible = true; lblWord.Visible = false;
                        lblUnfinished.Text = "C O _ A L";
                        L1.Text = "I"; L2.Text = "O"; L3.Text = "V"; L4.Text = "A"; L5.Text = "R"; L6.Text = "U";
                    }
                    else if (lblUnfinished.Text == "C O _ A L" && L5.Checked)
                    {

                        lblWord.Visible = false;
                        this.BackgroundImage = Properties.Resources.aqua5;
                        pShark.Visible = true;
                        frmCover.player.URL = "Ocean.mp3";
                        frmCover.player.controls.play();
                        lblUnfinished.Text = "CORNY"; lblUnfinished.Visible = true; btnHint.Visible = false; pboxHint.Visible = false;
                        lblLevel.Text = "Intermediate";
                        txtTimerTick.Text = "0";
                        L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                        MessageBox.Show("YOU HAVE COMPLETED THE BEGINNER LEVEL OF BEING A MARINE BIOLOGIST, LETS SEE IF YOU CAN DO SOMETHING HARDER " + lblName.Text + "!!! NOW TOUCH THE WORDS CORNY TO CONTINUE YOUR QUEST!!!");
                    }

                }
            }

            if (theme == "ASTRONOMY")
            {
                if (lblUnfinished.Text == "C_N_TEL_ATION" && L4.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "M E _ E O _ O _ D";
                    L1.Text = "F'H'A"; L2.Text = "C'S'I"; L3.Text = "T'R'I"; L4.Text = "S'T'U"; L5.Text = "T'R'R"; L6.Text = "T'T'T";

                }
                else if (lblUnfinished.Text == "M E _ E O _ O _ D" && L3.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ R A V _ T Y";
                    L1.Text = "L'I"; L2.Text = "G'I"; L3.Text = "S'I"; L4.Text = "N'I"; L5.Text = "P'I"; L6.Text = "F'I";
                }
                else if (lblUnfinished.Text == "_ R A V _ T Y" && L2.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ O _ I A _";
                    L1.Text = "Z'D'C"; L2.Text = "R'D'C"; L3.Text = "P'F'R"; L4.Text = "C'D'Z"; L5.Text = "L'H'Y"; L6.Text = "M'N'B";
                }
                else if (lblUnfinished.Text == "_ O _ I A _" && L1.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "A _ I _ N";
                    L1.Text = "T'O"; L2.Text = "P'E"; L3.Text = "R'I"; L4.Text = "M'E"; L5.Text = "L'O"; L6.Text = "L'E";
                }
                else if (lblUnfinished.Text == "A _ I _ N" && L6.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ A L A _ Y";
                    L1.Text = "Z'D"; L2.Text = "R'O"; L3.Text = "P'A"; L4.Text = "C'E"; L5.Text = "G'X"; L6.Text = "M'X";
                }
                else if (lblUnfinished.Text == "_ A L A _ Y" && L5.Checked)
                {
                    //Reset timer
                    lblWord.Visible = false;
                    this.BackgroundImage = Properties.Resources.astro2;
                    frmCover.player.URL = "Kygo-Stargazing.mp3";
                    frmCover.player.controls.play();
                    lblUnfinished.Text = "CORNY"; lblUnfinished.Visible = true; btnHint.Visible = false; pboxHint.Visible = false;
                    lblLevel.Text = "Advanced";
                    txtTimerTick.Text = "0";
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    MessageBox.Show("YOU HAVE COMPLETED THE INTERMEDIATE LEVEL OF BEING AN ASTRONAUT!!!" + "\n" + "LETS SEE IF YOU CAN DO SOMETHING HARDER " + lblName.Text + "!!!" + "\n" + "NOW TOUCH THE WORD CORNY TO CONTINUE YOUR QUEST!!!");
                }
            }
            if (theme == "AQUA")
            {
                if (lblUnfinished.Text == "S U _ _ A R I N E" && L1.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "P L A _ _ T O N";
                    L1.Text = "H'A"; L2.Text = "S'I"; L3.Text = "T'R"; L4.Text = "N'K"; L5.Text = "R'R"; L6.Text = "T'F";

                }
                else if (lblUnfinished.Text == "P L A _ _ T O N" && L4.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ U S _ E L S";
                    L1.Text = "M'C"; L2.Text = "R'R"; L3.Text = "S'K"; L4.Text = "N'S"; L5.Text = "N'R"; L6.Text = "M'S";
                }
                else if (lblUnfinished.Text == "_ U S _ E L S" && L6.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "S E A _ _ _ D";
                    L1.Text = "Z'A'A"; L2.Text = "W'E'E"; L3.Text = "P'F'F"; L4.Text = "C'D'D"; L5.Text = "L'I'I"; L6.Text = "M'O'O";
                }
                else if (lblUnfinished.Text == "S E A _ _ _ D" && L2.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "S _ I P _ R E _ K";
                    L1.Text = "T'O'Y"; L2.Text = "P'E'T"; L3.Text = "H'W'C"; L4.Text = "M'E'H"; L5.Text = "L'R'U"; L6.Text = "P'O'L";
                }
                else if (lblUnfinished.Text == "S _ I P _ R E _ K" && L3.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "N A _ T _ _ U S";
                    L1.Text = "I'I'I"; L2.Text = "O'O'I"; L3.Text = "A'U'T"; L4.Text = "E'I'K"; L5.Text = "U'I'L"; L6.Text = "U'O'L";
                }
                else if (lblUnfinished.Text == "N A _ T _ _ U S" && L5.Checked)
                {
                    //Reset timer
                    lblWord.Visible = false;
                    frmCover.player.URL = "Under the Sea.mp3";
                    frmCover.player.controls.play();
                    this.BackgroundImage = Properties.Resources.bubbles;
                    pShark.Visible = true; pHula.Visible = true; pHawaii.Visible = true;
                    lblUnfinished.Text = "CORNY"; lblUnfinished.Visible = true; btnHint.Visible = false; pboxHint.Visible = false;
                    lblLevel.Text = "Advanced";
                    txtTimerTick.Text = "0";
                    L1.Visible = false; L2.Visible = false; L3.Visible = false; L4.Visible = false; L5.Visible = false; L6.Visible = false;
                    MessageBox.Show("YOU HAVE COMPLETED THE INTERMEDIATE LEVEL OF BEING A MARINE BIOLOGIST!!!" + "\n" + "LETS SEE IF YOU CAN GO INTO THE DEEP END " + lblName.Text + "!!!" + "\n" + "NOW TOUCH THE WORD CORNY TO CONTINUE YOUR QUEST!!!");
                }
            }
            if (theme == "ASTRONOMY")
            {
                if (lblUnfinished.Text == "B _ G  _ A N G" && L6.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ U _ E _ _ O V A";
                    L1.Text = "F'H'I'A"; L2.Text = "C'S'J'I"; L3.Text = "T'R'I'Y"; L4.Text = "S'T'U'G"; L5.Text = "S'P'R'N"; L6.Text = "T'T'T";

                }
                else if (lblUnfinished.Text == "_ U _ E _ _ O V A" && L5.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "I _ E R T I _";
                    L1.Text = "L'A"; L2.Text = "P'I"; L3.Text = "N'A"; L4.Text = "N'P"; L5.Text = "P'E"; L6.Text = "F'O";
                }
                else if (lblUnfinished.Text == "I _ E R T I _" && L3.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ E _ U _ A";
                    L1.Text = "Z'D'C"; L2.Text = "N'B'L"; L3.Text = "P'F'R"; L4.Text = "C'D'Z"; L5.Text = "L'H'Y"; L6.Text = "M'N'B";
                }
                else if (lblUnfinished.Text == "_ E _ U _ A" && L2.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "A _ T R _ _ O M E R";
                    L1.Text = "T'O'Y"; L2.Text = "P'E'T"; L3.Text = "R'I'P"; L4.Text = "S'O'N"; L5.Text = "L'O'L"; L6.Text = "K'O'L";
                }
                else if (lblUnfinished.Text == "A _ T R _ _ O M E R" && L4.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ O S _ O N _ U T";
                    L1.Text = "C'M'A"; L2.Text = "P'R'O"; L3.Text = "M'P'A"; L4.Text = "N'C'E"; L5.Text = "I'G'X"; L6.Text = "A'M'X";
                }
                else if (lblUnfinished.Text == "_ O S _ O N _ U T" && L1.Checked)
                {
                    passingTouch = lblNums.Text;
                    frmGameOver F1 = new frmGameOver();
                    F1.Show();

                    this.Visible = false;
                }
            }
            if (theme == "AQUA")
            {
                if (lblUnfinished.Text == "_ A _ R _ S" && L2.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "S E _ L _ O _";
                    L1.Text = "O'A'J"; L2.Text = "I'O'S"; L3.Text = "A'O'P"; L4.Text = "E'I'R"; L5.Text = "I'A'D"; L6.Text = "A'I'N";

                }
                else if (lblUnfinished.Text == "S E _ L _ O _" && L6.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "C _ O _ N F I _ H";
                    L1.Text = "E'N'E"; L2.Text = "E'P'I"; L3.Text = "E'R'O"; L4.Text = "L'W'S"; L5.Text = "O'H'O"; L6.Text = "E'F'E";
                }
                else if (lblUnfinished.Text == "C _ O _ N F I _ H" && L4.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ I G E _ SHARK";
                    L1.Text = "Z'R"; L2.Text = "W'T"; L3.Text = "D'L"; L4.Text = "I'T"; L5.Text = "T'R"; L6.Text = "M'P";
                }
                else if (lblUnfinished.Text == "_ I G E _ SHARK" && L5.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "_ T _ E R";
                    L1.Text = "O'T"; L2.Text = "E'T"; L3.Text = "I'C"; L4.Text = "M'H"; L5.Text = "A'Y"; L6.Text = "P'L";
                }
                else if (lblUnfinished.Text == "_ T _ E R" && L1.Checked)
                {
                    TimerTock.Start();
                    lblUnfinished.Visible = true; lblWord.Visible = false;
                    lblUnfinished.Text = "CO_ _AC_NTH";
                    L1.Text = "I'I'I"; L2.Text = "O'O'I"; L3.Text = "E'L'A"; L4.Text = "E'K'I"; L5.Text = "U'L'I"; L6.Text = "U'L'O";
                }
                else if (lblUnfinished.Text == "CO_ _AC_NTH" && L3.Checked)
                {
                    passingTouch = lblNums.Text;
                    frmGameOver F1 = new frmGameOver();
                    F1.Show();

                    this.Visible = false;

                }
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            //Show the hint picturebox for the different words
            pboxHint.Visible = true;
            if (lblLevel.Text == "Beginner")
            {
                //AUSTRONAUT THEME HINT PICTURES
                if (lblUnfinished.Text == "C R A _ E R")
                {
                    pboxHint.BackgroundImage = Properties.Resources.crater;
                }
                if (lblUnfinished.Text == "E C _ I P S E")
                {
                    pboxHint.BackgroundImage = Properties.Resources.eclipse;
                }
                if (lblUnfinished.Text == "_ O O N")
                {
                    pboxHint.BackgroundImage = Properties.Resources.moon;
                }
                if (lblUnfinished.Text == "O _ B I T")
                {
                    pboxHint.BackgroundImage = Properties.Resources.orbit;
                }
                if (lblUnfinished.Text == "L U N _ R")
                {
                    pboxHint.BackgroundImage = Properties.Resources.Lunar;
                }
                if (lblUnfinished.Text == "W A _ I N G")
                {
                    pboxHint.BackgroundImage = Properties.Resources.waning;
                }


                //AQUA THEME HINT PICTURES
                if (lblUnfinished.Text == "S C _ O O L")
                {
                    pboxHint.BackgroundImage = Properties.Resources.school;
                }
                if (lblUnfinished.Text == "C _ A B")
                {
                    pboxHint.BackgroundImage = Properties.Resources.crab;
                }
                if (lblUnfinished.Text == "A L _ A E")
                {
                    pboxHint.BackgroundImage = Properties.Resources.algae;
                }
                if (lblUnfinished.Text == "S _ U I D")
                {
                    pboxHint.BackgroundImage = Properties.Resources.squid;
                }
                if (lblUnfinished.Text == "D O L _ H I N")
                {
                    pboxHint.BackgroundImage = Properties.Resources.dolphin;
                }
                if (lblUnfinished.Text == "C O _ A L")
                {
                    pboxHint.BackgroundImage = Properties.Resources.coral;
                }
            }
            if (lblLevel.Text == "Intermediate")
            {
                //AUSTRONAUT THEME HINT PICTURES
                if (lblUnfinished.Text == "C_N_TEL_ATION")
                {
                    pboxHint.BackgroundImage = Properties.Resources.constellation;
                }
                if (lblUnfinished.Text == "M E _ E O _ O _ D")
                {
                    pboxHint.BackgroundImage = Properties.Resources.meteoroid;
                }
                if (lblUnfinished.Text == "_ R A V _ T Y")
                {
                    pboxHint.BackgroundImage = Properties.Resources.gravity;
                }
                if (lblUnfinished.Text == "_ O _ I A _")
                {
                    pboxHint.BackgroundImage = Properties.Resources.zodiac;
                }
                if (lblUnfinished.Text == "A _ I _ N")
                {
                    pboxHint.BackgroundImage = Properties.Resources.aliens;
                }
                if (lblUnfinished.Text == "_ A L A _ Y")
                {
                    pboxHint.BackgroundImage = Properties.Resources.galaxy;
                }

                //AQUA THEME HINT PICTURES
                if (lblUnfinished.Text == "S U _ _ A R I N E")
                {
                    pboxHint.BackgroundImage = Properties.Resources.submarine;
                }
                if (lblUnfinished.Text == "P L A _ _ T O N")
                {
                    pboxHint.BackgroundImage = Properties.Resources.plankton;
                }
                if (lblUnfinished.Text == "_ U S _ E L S")
                {
                    pboxHint.BackgroundImage = Properties.Resources.mussels;
                }
                if (lblUnfinished.Text == "S E A _ _ _ D")
                {
                    pboxHint.BackgroundImage = Properties.Resources.seaweed;
                }
                if (lblUnfinished.Text == "S _ I P _ R E _ K")
                {
                    pboxHint.BackgroundImage = Properties.Resources.shipwreck;
                }
                if (lblUnfinished.Text == "N A _ T _ _ U S")
                {
                    pboxHint.BackgroundImage = Properties.Resources.nautilus;
                }
            }
            if (lblLevel.Text == "Advanced")
            {
                //AUSTRONAUT THEME HINT PICTURES
                if (lblUnfinished.Text == "B _ G  _ A N G")
                {
                    pboxHint.BackgroundImage = Properties.Resources.big_bang;
                }
                if (lblUnfinished.Text == "_ U _ E _ _ O V A")
                {
                    pboxHint.BackgroundImage = Properties.Resources.supernova;
                }
                if (lblUnfinished.Text == "I _ E R T I _")
                {
                    pboxHint.BackgroundImage = Properties.Resources.inertia;
                }
                if (lblUnfinished.Text == "_ E _ U _ A")
                {
                    pboxHint.BackgroundImage = Properties.Resources.nebula;
                }
                if (lblUnfinished.Text == "A _ T R _ _ O M E R")
                {
                    pboxHint.BackgroundImage = Properties.Resources.astronomer;
                }
                if (lblUnfinished.Text == "_ O S _ O N _ U T")
                {
                    pboxHint.BackgroundImage = Properties.Resources.cosmonaut;
                }


                //AQUA THEME HINT PICTURES
                if (lblUnfinished.Text == "_ A _ R _ S")
                {
                    pboxHint.BackgroundImage = Properties.Resources.walrus;
                }
                if (lblUnfinished.Text == "S E _ L _ O _")
                {
                    pboxHint.BackgroundImage = Properties.Resources.sealion;
                }
                if (lblUnfinished.Text == "C _ O _ N F I _ H")
                {
                    pboxHint.BackgroundImage = Properties.Resources.clownfish;
                }
                if (lblUnfinished.Text == "_ I G E _ SHARK")
                {
                    pboxHint.BackgroundImage = Properties.Resources.tiger;
                }
                if (lblUnfinished.Text == "_ T _ E R")
                {
                    pboxHint.BackgroundImage = Properties.Resources.otter;
                }
                if (lblUnfinished.Text == "CO_ _AC_NTH")
                {
                    pboxHint.BackgroundImage = Properties.Resources.coelacanth;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPlayerDetails F1 = new frmPlayerDetails();
            F1.Show();

            this.Visible = false;
        }
    }
}
