using Launcher.cs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Windows.Media.Audio;

namespace Launcher
{
    public partial class archive_export : Form
    {
        public archive_export()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] paths = new string[1000];
        string[] bools = new string[1000];
        private void archive_export_Load(object sender, EventArgs e)
        {
            un();
        }
        private void xingxifs(string title,string text)
        {
            message_fs message_fs=new message_fs(title, text);
        }
        string path;
        string saves;
        private void button1_Click(object sender, EventArgs e)
        {
            saves_HC();
        }
        static void CopyFolder(string sourceFolder, string destinationFolder)
        {
            try
            {
                // 创建目标文件夹
                Directory.CreateDirectory(destinationFolder);

                // 复制文件
                foreach (string file in Directory.GetFiles(sourceFolder))
                {
                    string destinationFile = Path.Combine(destinationFolder, Path.GetFileName(file));
                    File.Copy(file, destinationFile, true);
                }

                // 递归复制子文件夹
                foreach (string subFolder in Directory.GetDirectories(sourceFolder))
                {
                    string destinationSubFolder = Path.Combine(destinationFolder, Path.GetFileName(subFolder));
                    CopyFolder(subFolder, destinationSubFolder);
                }
            }
            catch (Exception ex)
            {
                error(3, ex.ToString());
            }
        }

        private static void error(int v,string ex)
        {
            Error error = new Error(v,ex);
            error.ShowDialog();
        }

        private int saves_HC()
        {
            
            saves = textBox1.Text;
            for (int j = 0; j <= i; j++)
            {
                if (saves == bools[j])
                {
                    Thread.Sleep(1000);
                    path = paths[j];
                    //MessageBox.Show(path);
                    string sourcePath = path;
                    string destinationPath = textBox2.Text+"\\" + saves;

                    CopyFolder(sourcePath, destinationPath);
                    xingxifs("存档导出模块:", "存档导出成功!\n存档:" + saves + "已导出成功!\n已导出至:" + destinationPath);
                    MessageBox.Show("存档导出成功!\n存档:"+saves+"已导出成功!\n已导出至:"+ destinationPath, "导出成功!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return 0;
                }
            }
            xingxifs("存档导出模块:", saves + "\n此需要导出的存档名无效!");
            MessageBox.Show(saves+"\n此需要导出的存档名无效!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            un();
        }

        private void un()
        {
            try
            {
                //i = 0;
                this.listView1.Items.Clear();
                this.listView1.View = View.List;
                this.listView1.SmallImageList = this.imageList1;
                this.listView1.BeginUpdate();
                //for (int i = 0; i < 10; i++)
                //{
                //    ListViewItem lvi = new ListViewItem();
                //    lvi.ImageIndex = i;
                //    lvi.Text = "存档:" + i;
                //    this.listView1.Items.Add(lvi);
                //}
                string path = ".minecraft\\saves";


                string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

                foreach (string directory in directories)
                {
                    i++;
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    paths[i] = directory;
                    string trimmedDirectory = directory.Substring(17);
                    bools[i] = trimmedDirectory;
                    lvi.Text = "存档:" + trimmedDirectory;

                    this.listView1.Items.Add(lvi);
                }
                this.listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                error(4, ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command command = new command("start .minecraft\\saves",true);
        }
    }
}