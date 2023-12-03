using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class concerning : Form
    {
        public concerning()
        {
            InitializeComponent();
        }

        private void concerning_Load(object sender, EventArgs e)
        {
            label1.Text= "程序版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()+ "\n程序名称：Round Minecraft Launcher\n软件简称：RMCL\n作       者：Minecraft一角钱\n版权所有：Mnecraft一角钱\n免责声明：Minecraft版权归Mojang AB所有，使用本软件产生的版                      权问题，软件制作方概不负责。请支持正版。\n程序依赖：CMCL\n                   Microsoft.Toolkit.Uwp.Notifications\n                   Newtonsoft.Json\n链接前往：";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://space.bilibili.com/1527364468");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://afdian.net/a/yjq666");
        }
    }
}
