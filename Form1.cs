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
    public partial class frmCover : Form
    {
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public frmCover()
        {
            InitializeComponent();
            player.URL = "Thomas-Newman-The-Starship-Avalon-Main-Title.mp3";
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
        public void frmCover_Load(object sender, EventArgs e)
        {
            //Start timer to display the Cover form and play soundtrack
            player.controls.play();
            frmNext.Interval = 3500;
            frmNext.Tick += new
            EventHandler(frmClose_Tick);
            frmNext.Start();
        }

        private void frmClose_Tick(object sender, EventArgs e)
        { 
            //Stop timer to display the New Game form and hide the Cover form
            frmNext.Stop();
            frmNewGame main = new frmNewGame();
            main.Show();
            this.Visible = false;

        }
    }
}
