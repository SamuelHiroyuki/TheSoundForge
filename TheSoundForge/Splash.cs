using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TheSoundForge
{
    public partial class frmSplash : Form
    {
        SoundPlayer s = new SoundPlayer(@"C:\Users\samhi\Documents\Visual Studio 2015\Projects\TheSoundForge\TheSoundForge\Resources\musica.wav");
        public frmSplash()
        {
            InitializeComponent();            
            s.Play();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            s.Stop();
            tmrSplash.Enabled = false;
            this.Hide();
        }

    }
}
