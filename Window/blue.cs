using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Launcher
{
    public partial class blue : Form
    {
        public blue()
        {
            InitializeComponent();
        }
        
        private void blue_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            label3.Text = a.ToString() + "% Complete";
            if (a == 101)
            {

                this.Close();
            }
        }
    }
}
