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
    public partial class kzt : Form
    {
        string str;
        public kzt(string command)
        {
            InitializeComponent();
            str= command;
        }

        private void kzt_Load(object sender, EventArgs e)
        {
            textBox1.Text = cmd(str);

        }
        private string cmd(string str)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.StandardInput.WriteLine(str+ "&exit");
                string output = p.StandardOutput.ReadToEnd();
                p.StandardInput.AutoFlush = true;
                output = output + "命令已运行完毕，控制台已退出。";
                return output;
            }
            catch (Exception ex)
            {
                Error(2,ex.ToString());
                return null;
            }
        }
        private void Error(int i,string ex)
        {
            Error error = new Error(i,ex);
            error.ShowDialog();
            System.Environment.Exit(0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            concerning concerning = new concerning();
            concerning.ShowDialog();
        }
    }
}
