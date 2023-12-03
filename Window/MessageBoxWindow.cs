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
    public partial class MessageBoxWindow : Form
    {
        int xs, ys;
        string titles, texts;
        public MessageBoxWindow(int x,int y,string title,string text)
        {
            InitializeComponent();
            xs= x;
            ys= y+423/4;
            titles = title;
            texts = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageBoxWindow_Load(object sender, EventArgs e)
        {
            Location = new Point(xs, ys);
            label1.Text = titles;
            label3.Text = texts;
        }
    }
}
