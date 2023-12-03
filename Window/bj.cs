using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Window
{
    public partial class bj : Form
    {
        int xs, ys;
        string titles, texts;
        public bj(int x,int y,string title,string text)
        {
            InitializeComponent();
            xs = x;
            ys = y+37;
            titles = title;
            texts = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBoxWindow messageBoxWindow = new MessageBoxWindow(Location.X,Location.Y,titles,texts);
            messageBoxWindow.ShowDialog();
            Close();
        }

        private void bj_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(xs, ys);
        }
    }
}
