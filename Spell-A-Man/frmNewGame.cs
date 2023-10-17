using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Spell_A_Man
{
    public partial class frmNewGame : Form
    {
        public frmNewGame()
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

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //When button is clicked PlayerDetails form will appear and the NewGame form will disappear
            frmPlayerDetails F1 = new frmPlayerDetails();
            F1.Show();
            this.Visible = false;
        }

        public void btnON_Click(object sender, EventArgs e)
        {
            frmCover.player.controls.play();
            if(btnON.Enabled)
            {
                btnON.Visible = false;
                btnOFF.Visible = true;
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

        public void frmNewGame_Load(object sender, EventArgs e)
        {
            //The tooltips for th off and on buttons of the sound
            ToolTip tipAll = new ToolTip();
            tipAll.ShowAlways = true;
            tipAll.SetToolTip(this.btnOFF, "Sound OFF");
            tipAll.SetToolTip(this.btnON, "Sound ON");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Message box to tell the user how to play the game
            MessageBox.Show("THE GAME WORKS IN THE FOLLOWING WAYS: " + "\n" +
                "1.When you have placed in your nickname, level and theme. You will be asked to click a button to start." +
                "\n" + "2.Once you have clicked the button, you will have 60seconds to fill in the missing letter(s) of 6 unfinished words." + "\n" +
                "3.You have 10 seconds to finish choosing the right letter(s) for each word." + "\n" +
                "4.In each of these words, you hava 5seconds to open and view a hint by clicking the hint button when it appears." + "\n" +
                "5.Remember that when your choice has been proven to be correct, click the new word button to do the next one!!!" + "\n" + "If its not correct, keep guessing to find the correct one." + "\n"
                + "6.If your score is below 120, its Game Over. GOODLUCK!!!");
        }

    }
}
