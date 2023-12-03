using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.UI.Xaml.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Principal;
using System.Reflection;
using Windows.ApplicationModel.Activation;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Launcher.Window;

namespace Launcher
{
    public partial class sz : Form
    {
        public sz()
        {
            InitializeComponent();
        }
        string verp,javas,Player_Name;
        string j1 = "{\r\n  \"exitWithMinecraft\": false,\r\n  \"javaPath\": ";
        string j2 = ",\r\n  \"windowSizeWidth\": 854,\r\n  \"windowSizeHeight\": 480,\r\n  \"language\": \"zh\",\r\n  \"downloadSource\": 2,\r\n  \"checkAccountBeforeStart\": false,\r\n  \"accounts\": [{\r\n    \"playerName\": ";
        string j3 = ",\r\n    \"loginMethod\": 0,\r\n    \"ver\":";
        string j4=  ",\r\n    \"selected\": true\r\n  }],\r\n  \"printStartupInfo\": false,\r\n  \"maxMemory\": 8127\r\n}";
        int dow=0;
        bool exits = true;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Vir.Text == "")
            {
                xingxifs("下载模块:", "下载失败!");
            }
            dow = 0;
            cmd("RMCL\\hx install " + Vir.Text,true);
            DWJC.Enabled = true;
        }
        private void cmd(string str, bool Win)
        {
            hxexe();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = Win;
            p.Start();
            p.StandardInput.WriteLine(str + "&exit");
            p.StandardInput.AutoFlush = true;
        }
        private void hxexe()
        {
            if (File.Exists("RMCL\\hx.exe"))
            {

            }
            else
            {
                Error(2);
            }
        }
        string text1="",text2 = "", text3 = "";
        private void xg()
        {
            if (textBox1.Text != temp1 ||javalj.Text!=temp2||Namesz.Text!=temp3)
            {
                if (textBox1.Text == "")
                {
                    text1 = "游戏版本未输入!";
                }
                else
                {
                    text1 = "游戏版本:" + textBox1.Text;
                }
                if (javalj.Text == "")
                {
                    text2 = "Java路径未输入!";
                    javalj.Text = javas;
                }
                else
                {
                    text2 = "Java路径:" + javalj.Text;
                    javas = javalj.Text;
                    javas = javas.Replace("\\", "\\\\");
                }
                if (Namesz.Text == "")
                {
                    text3 = "未输入离线模式玩家名!";
                    Namesz.Text = Player_Name;
                }
                else
                {
                    text3 = "玩家名:" + Namesz.Text;
                    Player_Name = Namesz.Text;
                }
                xingxifs("设置模块:", text1 + "\n" + text2 + "\n" + text3);
                verp = textBox1.Text;
                File.WriteAllText("RMCL\\cmcl.json", j1 + "\"" + javas + "\"" + j2 + "\"" + Player_Name + "\"" + j3 + "\"" + verp + "\"" + j4);
            }
            else
            {
                
            }
        }

        private async Task MyFunctionAsync()
        {
            javalj.Text = javass();
            Namesz.Text = Player_Name;
            textBox1.Text = vers(9);
            Namesz.Text = namessss(9);
            javalj.Text = javass();
            temp1 = textBox1.Text;
            temp2 = javalj.Text;
            temp3 = Namesz.Text;
            javahcxx();
            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
        }
        string temp1, temp2, temp3;
        private async void sz_Load(object sender, EventArgs e)
        {
            await MyFunctionAsync();
        }

        private string javasss(string path)
        {
            System.IO.FileInfo fileInfo = null;
            try
            {
                fileInfo = new System.IO.FileInfo(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // 其他处理异常的代码
            }
            // 如果文件存在
            if (fileInfo != null && fileInfo.Exists)
            {
                System.Diagnostics.FileVersionInfo info = System.Diagnostics.FileVersionInfo.GetVersionInfo(path);
                Console.WriteLine("文件名称=" + info.FileName);
                Console.WriteLine("产品名称=" + info.ProductName);
                Console.WriteLine("公司名称=" + info.CompanyName);
                Console.WriteLine("文件版本=" + info.FileVersion);
                Console.WriteLine("产品版本=" + info.ProductVersion);
                // 通常版本号显示为「主版本号.次版本号.生成号.专用部件号」
                Console.WriteLine("系统显示文件版本：" + info.ProductMajorPart + '.' + info.ProductMinorPart + '.' + info.ProductBuildPart + '.' + info.ProductPrivatePart);
                Console.WriteLine("文件说明=" + info.FileDescription);
                Console.WriteLine("文件语言=" + info.Language);
                Console.WriteLine("原始文件名称=" + info.OriginalFilename);
                Console.WriteLine("文件版权=" + info.LegalCopyright);

                Console.WriteLine("文件大小=" + System.Math.Ceiling(fileInfo.Length / 1024.0) + " KB");
                return "产品名称: " + info.ProductName + "\n公司名称: " + info.CompanyName + "\n产品版本: " + info.ProductVersion;
            }
            return null;
            // 末尾空一行
            Console.WriteLine();
        }

        int off = 0;
        private void xingxifs(string title, string text)
        {
            try
            {
                new ToastContentBuilder()
                        .AddText(title)
                        .AddText(text)
                        .Show();
                if (off != 20)
                {
                    off++;
                }
                else
                {
                    ToastNotificationManagerCompat.History.Clear();
                    off = 0;
                }
            }
            catch {
                Error(1);
            }
        }

        bool qds = true;
        private string javass()
        {
            try
            {
                string json = File.ReadAllText("RMCL\\cmcl.json");
                Configuration config = JsonConvert.DeserializeObject<Configuration>(json);

                // 使用字典保存配置信息
                Dictionary<string, object> configInfo = new Dictionary<string, object>
                {
                    { "ExitWithMinecraft", config.ExitWithMinecraft },
                    { "JavaPath", config.JavaPath },
                    { "WindowSizeWidth", config.WindowSizeWidth },
                    { "WindowSizeHeight", config.WindowSizeHeight },
                    { "Language", config.Language },
                    { "DownloadSource", config.DownloadSource },
                    { "CheckAccountBeforeStart", config.CheckAccountBeforeStart },
                    { "Accounts", config.Accounts },
                    { "PrintStartupInfo", config.PrintStartupInfo },
                    { "MaxMemory", config.MaxMemory },
                    { "qd", config.qd }
                };

                // 输出javaPath的值
                string javaPath = configInfo["JavaPath"].ToString();
                qds = (bool)configInfo["qd"];
                return javaPath;
            }
            catch
            {
                Error(1);
                return null;
            }
            
        }
        private void Error(int i)
        {
            Error error = new Error(i);
            error.ShowDialog();
        }
      


        public class Configuration
        {
            public bool ExitWithMinecraft { get; set; }
            public string JavaPath { get; set; }
            public int WindowSizeWidth { get; set; }
            public int WindowSizeHeight { get; set; }
            public string Language { get; set; }
            public int DownloadSource { get; set; }
            public bool CheckAccountBeforeStart { get; set; }
            public List<Account> Accounts { get; set; }
            public bool PrintStartupInfo { get; set; }
            public int MaxMemory { get; set; }
            public bool qd { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(javalj.Text))
            {
                exits = false;
                xg();
                this.Close();
            }
            else
            {
                exits = false;
                MessageBox.Show(javalj.Text +"\n该路径的Java无效！请重新输入！","警告",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                javalj.Text = temp2;
                this.Close();
            }
        }
        int taa=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dow++;
            if (dow > 150)
            {
                if(IsProcessRunning("java")|| IsProcessRunning("javaw"))
                {
                    if(IsProcessRunning("java") || IsProcessRunning("javaw"))
                    {
                        taa = 1;
                    }
                }
                else if(taa==0)
                {
                    xingxifs("下载模块:", "下载失败!");
                    DWJC.Enabled = false;
                }
                else
                {
                    xingxifs("下载模块:", "下载成功!");
                    DWJC.Enabled = false;
                }
            }
        }
        static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            concerning concerning = new concerning();
            concerning.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kzt kzt = new kzt("where javaw");
            kzt.ShowDialog();
        }

        private void JavaJCs_Tick(object sender, EventArgs e)
        {
            javahcxx();
        }
        private void javahcxx()
        {
            if (javalj.Text != "")
            {
                javaxx.Text = javasss(javalj.Text);
            }
        }
        private void xggg(object sender, EventArgs e)
        {
            javaxx.Text = "获取中...";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRP(System.Drawing.Rectangle rect, int a)
        {
            int diameter = a;
            System.Drawing.Rectangle arcRect = new System.Drawing.Rectangle(rect.Location, new Size(diameter, diameter));
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(arcRect, 180, 90);
            arcRect.X = rect.Right - diameter;
            gp.AddArc(arcRect, 270, 90);
            arcRect.Y = rect.Bottom - diameter;
            gp.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;
            gp.AddArc(arcRect, 90, 90);
            gp.CloseFigure();
            return gp;
        }
        private const int wmParameter = 0x84;
        private const int paramOne = 0x1;
        private const int paramTwo = 0x2;
        protected override void WndProc(ref Message id)
        {
            // 引用消息ID(ref Message ID)
            switch (id.Msg)
            {
                case wmParameter:
                    base.WndProc(ref id);
                    if ((int)id.Result == paramOne)
                        id.Result = (IntPtr)paramTwo;
                    return;
            }
            base.WndProc(ref id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text != temp1 || javalj.Text != temp2 || Namesz.Text != temp3)
            {
                bool_exti(sender, e);
            }
        }
        private void bool_exti(object sender, FormClosedEventArgs e)
        {
            if (exits == true)
            {
                DialogResult dr = MessageBox.Show("当前设置已经被修改，请问是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.No)
                {
                    Close();
                }
                else if (dr == DialogResult.Yes)
                {
                    button1_Click(sender, e);
                }
                else
                {
                    sz sz = new sz();
                    sz.ShowDialog();
                }
            }
        }
        public class Account
        {
            public string PlayerName { get; set; }
            public int LoginMethod { get; set; }
            public bool Selected { get; set; }
            public string ver { get; set; }
        }
        string jsonString;
        private string vers(int charactersToRemove)
        {
            try
            {
                jsonString = File.ReadAllText("RMCL\\cmcl.json");
                //读取
                JObject jsonObject = JObject.Parse(jsonString);
                JArray accountsArray = (JArray)jsonObject["accounts"];
                List<Dictionary<string, object>> accountsList = accountsArray.ToObject<List<Dictionary<string, object>>>();

                List<string> accountNames = new List<string>();

                foreach (var account in accountsList)
                {
                    accountNames.Add($"Account: {account["ver"]}");
                }

                string temp2 = accountNames.Last();
                //取字符
                string jg = temp2.Substring(charactersToRemove);

                return jg;
            }
            catch
            {
                Error(1);
                return null;
            }
        }
        private string namessss(int charactersToRemove)
        {
            try
            {
                jsonString = File.ReadAllText("RMCL\\cmcl.json");
                //读取
                JObject jsonObject = JObject.Parse(jsonString);
                JArray accountsArray = (JArray)jsonObject["accounts"];
                List<Dictionary<string, object>> accountsList = accountsArray.ToObject<List<Dictionary<string, object>>>();

                List<string> accountNames = new List<string>();

                foreach (var account in accountsList)
                {
                    accountNames.Add($"Account: {account["playerName"]}");
                }

                string temp2 = accountNames.Last();
                //取字符
                string jg = temp2.Substring(charactersToRemove);

                return jg;
            }
            catch
            {
                Error(1);
                return null;
            }
        }
    }
}
