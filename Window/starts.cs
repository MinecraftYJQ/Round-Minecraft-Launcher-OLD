using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Window
{
    public partial class starts : Form
    {
        public starts()
        {
            InitializeComponent();
        }

        private void starts_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"RMCL\assets\Windows Notify Calendar.wav";
            player.Load(); //同步加载声音
            player.Play(); //启用新线程播放
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
