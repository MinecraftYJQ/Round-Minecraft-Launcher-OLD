using Launcher.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Versions_list : Form
    {
        public Versions_list()
        {
            InitializeComponent();
        }

        int i = 0;
        string[] verpath = new string[1000];
        string[] ver = new string[1000];

        private void unt()
        {
            textBox1.Text = "";
            string path = ".minecraft\\versions";
            string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

            foreach (string directory in directories)
            {
                i++;
                if (i >= 1000)
                {
                    textBox1.Text = "";
                    Error error = new Error(4, "你游戏版本太多辣！\r\n删少一点！");
                    error.ShowDialog();
                }
                ver[i] = directory.Substring(20);
                verpath[i] = directory;
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                textBox1.Text += "版本            " + directory.Substring(20) + "\r\n";
            }
        }

        private void Versions_list_Load(object sender, EventArgs e)
        {
            try
            {
                unt();
            }
            catch (Exception ex)
            {
                Error error = new Error(4, ex.ToString());
                error.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unt();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            delete();
        }

        private int delete()
        {
            for (int j = 0; j <= i; j++)
            {
                DialogResult result;

                if (textBox2.Text == ver[j])
                {
                    try
                    {
                        Directory.Delete(verpath[j], true);
                        unt();
                        message_fs message_Fss = new message_fs("版本管理模块:", textBox2.Text + "\n删除成功！");
                        return 0;
                    }
                    catch(Exception ex)
                    {
                        //System.Windows.MessageBox.Show(textBox2.Text + "\n此版本无效！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                }
            }
            System.Windows.MessageBox.Show(textBox2.Text + "\n此版本无效！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            message_fs message_Fs = new message_fs("版本管理模块:", textBox2.Text + "\n此版本无效！");
            return 0;
        }
    }
}