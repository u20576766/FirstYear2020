using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spell_A_Man
{
    
    public partial class frmPlayerDetails : Form
    {
        public static string passingText, passingTheme, passingLevel;
        public frmPlayerDetails()
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            //When button is clicked the PlayerDetails form will disappear and the NewGame form will appear
            frmNewGame F1 = new frmNewGame();
            F1.Show();

            this.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare variables
            string nickName = txtNickName.Text;
            string level = cboxLevels.Text;
            string theme = cboxTheme.Text;

            //Passing the nickname,level and theme to the game form
            passingText = txtNickName.Text;
            passingTheme = cboxTheme.Text;
            passingLevel = cboxLevels.Text;

            //If statement for filling in player details
            if (nickName == "" || level == "" || theme == "")
            {
                MessageBox.Show("Please fill in all your details...");
            }
            else
            {
                frmGame F1 = new frmGame();
                F1.Show();
                this.Visible = false;
                MessageBox.Show("GOODLUCK " + nickName + " PLEASE CLICK ON THE WORD 'CORNY' TO START YOUR " + theme + " THEMED GAME!!!");
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

        private void btnOFF_Click(object sender, EventArgs e)
        {
            frmCover.player.controls.stop();
            if (btnOFF.Enabled)
            {
                btnON.Visible = true;
                btnOFF.Visible = false;
            }
        }

        private void frmPlayerDetails_Load(object sender, EventArgs e)
        {
            ToolTip tipAll = new ToolTip();
            tipAll.ShowAlways = true;
            tipAll.SetToolTip(this.btnOFF, "Sound OFF");
            tipAll.SetToolTip(this.btnON, "Sound ON");
        }
    }
}
