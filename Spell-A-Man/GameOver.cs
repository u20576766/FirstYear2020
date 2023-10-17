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
    public partial class frmGameOver : Form
    {
        
        public frmGameOver()
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
        private void frmGameOver_Load(object sender, EventArgs e)
        {
            lblNumss.Text = frmGame.passingTouch;
            int score = Convert.ToInt32(lblNumss.Text);
            
            if (score < 120)
            {
                this.BackColor = Color.Black;
                lblNumss.ForeColor = Color.White;
                lblResult.Text = "GAME OVER";
                lblResult.ForeColor = Color.White;
                btnNewGame.ForeColor = Color.White;
                lblScore.ForeColor = Color.White;
                lblNumss.Text = frmGame.passingTouch;
                pLose.Visible = true;
            }
            else
            {
                this.BackColor = Color.White;
                lblNumss.ForeColor = Color.Black;
                lblResult.Text = "YOU WON!!!";
                lblResult.ForeColor = Color.Black;
                lblScore.ForeColor = Color.Black;
                lblNumss.Text = frmGame.passingTouch;
                pWin.Visible = true;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmNewGame f1 = new frmNewGame();
            f1.Show();

            this.Visible = false;
        }
    }
}
