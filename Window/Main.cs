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
using System.Diagnostics;
using Windows.UI.Xaml.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Principal;
using System.Reflection;
using Windows.ApplicationModel.Activation;
using Windows.Gaming.Preview.GamesEnumeration;
using Windows.UI.Xaml;
using Launcher.Window;
using Windows.ApplicationModel.VoiceCommands;
using System.Windows;
using Launcher.cs;
using System.Media;

namespace Launcher
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        string WTitle= "Round Minecraft Launcher ";
        string player_Name="player",versions="",jsonString;
        int taaaa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            taaaa++;
            Random ran = new Random();
            int n = ran.Next(10);
            if (n == 7)
            {
                if (taaaa == 0)
                {
                    blue blue = new blue();
                    blue.ShowDialog();
                   button2.Enabled = false;
                    xingxifs("彩蛋:","你被骗了!");
                }
                if (taaaa == 10)
                {
                    taaaa = 0;
                }
                button2.Enabled = true;
            }
            else
            {
                versions = vers(9);
                if (versions == "")
                {
                    xingxifs("启动游戏模块:", "未输入游戏版本!");
                    button2.Enabled = true;
                }
                else
                {
                    jdt.Style= ProgressBarStyle.Marquee;
                    Sl.Enabled = true;
                    button2.Enabled = true;

                }
                

            }
        }
        
        
        
        private void hxexe()
        {
            if (File.Exists("RMCL\\hx.exe"))
            {
                
            }
            else
            {
                Error(2,"核心文件错误！");
                Unt.Enabled = false;
            }
        }
        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRP(System.Drawing.Rectangle rect, int a)
        {
            int diameter = a;
            System.Drawing.Rectangle arcRect = new System.Drawing.Rectangle(rect.Location, new System.Drawing.Size(diameter, diameter));
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


        private async void Form1_Load(object sender, EventArgs e)
        {
            await MyFunctionAsync();
            //progressBar1.Style = ProgressBarStyle.Marquee;
            // 设置ProgressBar的颜色为Win10蓝色
            //progressBar1.ForeColor = Color.FromArgb(0, 120, 215);
        }
        private string Names(int charactersToRemove)
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
            catch (Exception ex)
            {
                Unt.Enabled = false;
                Error(1, ex.ToString());
                return null;
            }
        }

        private void Unt_Tick(object sender, EventArgs e)
        {
            player_Name = Names(9);
            label1.Text = "玩家名:" + player_Name;
            versions = vers(9);
            hxexe();
        }
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
            catch (Exception ex)
            {
                Error(1, ex.ToString());
                return null;
            }
        }
        private void jd_Tick(object sender, EventArgs e)
        {
            jdt.Style = ProgressBarStyle.Blocks;
            jd.Enabled = false;
            if (IsProcessRunning("javaw") || IsProcessRunning("java"))
            {
                if (htjc)
                {
                    Games_off.Enabled = true;
                    xingxifs("游戏启动模块:", "游戏已启动!\n游戏版本:" + versions + "               玩家名称:" + player_Name + "\n登录方式:离线登录    后台监测:已启用");
                }
                else
                {
                    Games_off.Enabled = false;
                    xingxifs("游戏启动模块:", "游戏已启动!\n游戏版本:" + versions + "               玩家名称:" + player_Name + "\n登录方式:离线登录    后台监测:未启用");
                }
            }
            else
            {
                xingxifs("游戏启动模块:", "游戏启动失败");
                jdt.Style = ProgressBarStyle.Blocks;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            off_java();
            button2.Enabled = false;
            Sl.Enabled = false;
            jdt.Style = ProgressBarStyle.Blocks;
        }
        int off = 0;
        
        private void Games_off_Tick(object sender, EventArgs e)
        {
            if (IsProcessRunning("javaw")|| IsProcessRunning("java"))
            {

            }
            else
            {
                Games_off.Enabled = false;
                xingxifs("游戏监测模块:", "游戏已退出!");
            }
        }

       
        bool htjc = true,xxtc=true;

        private void button3_Click(object sender, EventArgs e)
        {
            //sz sz = new sz();
            //sz.ShowDialog();
            //上面的是设置界面载入代码

            //下面是单窗口设置代码
            szyc();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            concerning concerning = new concerning();
            concerning.ShowDialog();
        }

        private void off_java()
        {
            if (IsProcessRunning("javaw")||IsProcessRunning("java"))
            {
                cmd("taskkill /f /im java.exe", true);
                cmd("taskkill /f /im javaw.exe", true);
                xingxifs("Java进程模块:", "所有Java进程已结束!");
                MessgageBoxR("游戏关闭", "所有Minecraft for Java已安全退出！");
            }
            else
            {
                xingxifs("Java进程模块:", "当前没有正在运行的Java进程!");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t();
        }
        private void t()
        {
            if (File.Exists(javalj.Text))
            {
                exits = false;
                xg();
                zjm();
                temp1 = textBox1.Text;
                temp2 = javalj.Text;
                temp3 = Namesz.Text;
            }
            else
            {
                exits = false;
                MessgageBoxR("警告",javalj.Text + "\n该路径的Java无效！请重新输入！");
                javalj.Text = temp2;
                zjm();
            }
        }


        static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }
        


        private void szyc()
        {
            //false
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button8.Visible = false;

            jdt.Visible = false;
            //true
            button4.Visible = true;
            label10.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            label7.Visible = true;
            label5.Visible = true;
            javaxx.Visible = true;
            Vir.Visible = true;
            javalj.Visible = true;
            textBox1.Visible = true;
            Namesz.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;

            //
            label4.Size = new System.Drawing.Size(122, 34);
            pictureBox8.Size = new System.Drawing.Size(154, 449);
            label4.Location = new System.Drawing.Point(554, 37);
            pictureBox8.Location = new System.Drawing.Point(554, 31);
            pictureBox11.Location = new System.Drawing.Point(554, 37);
        }
        private void zjm()
        {
            //true
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            jdt.Visible = true;
            button8.Visible = true;
            //false
            button4 .Visible = false;
            button4.Visible = false;
            label10.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            label7.Visible = false;
            label5.Visible = false;
            javaxx.Visible = false;
            Vir.Visible = false;
            javalj.Visible = false;
            textBox1.Visible = false;
            Namesz.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

            //
            label4.Size = new System.Drawing.Size(182, 34);
            pictureBox8.Size = new System.Drawing.Size(226, 449);
            label4.Location = new System.Drawing.Point(495, 37);
            pictureBox8.Location = new System.Drawing.Point(495, 31);
            pictureBox11.Location= new System.Drawing.Point(495, 37);
        }


        private void MessgageBoxR(string title,string text)
        {
            MessageBox_NB messageBox_NB=new MessageBox_NB(Location.X,Location.Y,title,text);
            
        }










        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        string verp, javas;
        string j1 = "{\r\n  \"exitWithMinecraft\": false,\r\n  \"javaPath\": ";
        string j2 = ",\r\n  \"windowSizeWidth\": 854,\r\n  \"windowSizeHeight\": 480,\r\n  \"language\": \"zh\",\r\n  \"downloadSource\": 2,\r\n  \"checkAccountBeforeStart\": false,\r\n  \"accounts\": [{\r\n    \"playerName\": ";
        string j3 = ",\r\n    \"loginMethod\": 0,\r\n    \"ver\":";
        string j4 = ",\r\n    \"selected\": true\r\n  }],\r\n  \"printStartupInfo\": false,\r\n  \"maxMemory\": 8127\r\n}";
        int dow = 0;
        bool exits = true;
        private void button6_Click(object sender, EventArgs e)
        {
            if (Vir.Text == "")
            {
                xingxifs("下载模块:", "下载失败!");
            }
            dow = 0;
            cmd("RMCL\\hx install " + Vir.Text, true);
            DWJC.Enabled = true;
        }
        private void cmd(string str, bool Win)
        {
            hxexe();
            command command=new command(str,Win);
        }
        
        string text1 = "", text2 = "", text3 = "";
        private void xg()
        {
            if (textBox1.Text != temp1 || javalj.Text != temp2 || Namesz.Text != temp3)
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
        string Player_Name;
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
            starts starts = new starts();
            starts.ShowDialog();
            h1.Enabled = true;

            //System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();

            Text = WTitle + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            hxexe();
            if (File.Exists("RMCL\\cmcl.json"))
            {
                try
                {
                    string fileContent = null;

                    // 使用using语句创建StreamReader对象，确保文件资源被正确释放
                    using (StreamReader reader = new StreamReader("RMCL\\cmcl.json"))
                    {
                        // 读取文件内容
                        fileContent = reader.ReadToEnd();
                    }

                    // 如果文件内容为空，则执行操作
                    if (string.IsNullOrEmpty(fileContent))
                    {
                        // 向文件写入JSON内容
                        string jsonContent = "{\r\n  \"exitWithMinecraft\": false,\r\n  \"javaPath\": \"\",\r\n  \"windowSizeWidth\": 854,\r\n  \"windowSizeHeight\": 480,\r\n  \"language\": \"zh\",\r\n  \"downloadSource\": 2,\r\n  \"checkAccountBeforeStart\": false,\r\n  \"accounts\": [\r\n    {\r\n      \"playerName\": \"PlayerName\",\r\n      \"ver\":\"\",\n      \"loginMethod\": 0,\r\n      \"selected\": true\r\n    }\r\n  ],\r\n  \"printStartupInfo\": false,\r\n  \"maxMemory\": 8127,\r\n}";
                        File.WriteAllText("RMCL\\cmcl.json", jsonContent);
                    }
                }
                catch (Exception ex)
                {
                    Error(1, ex.ToString());
                }
            }
            Unt.Enabled = true;
            player_Name = Names(9);
            xingxifs("启动模块:", "你好!" + player_Name + "!欢迎使用RMCL!\nRMCL版本:" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            label1.Text = "玩家名:" + player_Name;
            Title.Text = Text;
            
        }
        string temp1, temp2, temp3;
        

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
                
                return "产品名称: " + info.ProductName + "\n公司名称: " + info.CompanyName + "\n产品版本: " + info.ProductVersion;
            }
            return null;
            // 末尾空一行
            Console.WriteLine();
        }

        private void xingxifs(string title, string text)
        {
            message_fs message_Fs=new message_fs(title, text);
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
            catch (Exception ex)
            {
                Error(0, ex.ToString());
                return null;
            }

        }
        private void Error(int i,string ex)
        {
            jd.Enabled = false;
            Unt.Enabled = false;
            Games_off.Enabled = false;
            DWJC.Enabled = false;
            JavaJCs.Enabled = false;
            Sl.Enabled = false;
            timer1.Enabled = false;

            Error error = new Error(i, ex);
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

        
        int taa = 0;


        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Vir.Text == "")
            {
                xingxifs("下载模块:", "下载失败!");
            }
            dow = 0;
            cmd("RMCL\\hx install " + Vir.Text, true);
            DWJC.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kzt kzt = new kzt("where javaw");
            kzt.ShowDialog();
        }

        private void JavaJCs_Tick_1(object sender, EventArgs e)
        {
            javahcxx();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                archive_export ae = new archive_export();
                ae.ShowDialog();
            }
            catch (Exception ex)
            {
                Error(3, ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                archive_export ae = new archive_export();
                ae.ShowDialog();
            }
            catch(Exception ex)
            {
                Error(4, ex.ToString());
            }
        }

        private void Sl_Tick(object sender, EventArgs e)
        {
            Sl.Enabled = false;
            cmd("RMCL\\hx " + versions, true);
            //Thread.Sleep(1000);
            jd.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                button2.BackColor = Color.DeepSkyBlue;
                button2.ForeColor = Color.Black;
            }
            else
            {
                button2.BackColor = Color.DarkGray;
                button2.ForeColor = Color.DimGray;
            }
        }

        int ij = 0;
        private void h1_Tick(object sender, EventArgs e)
        {
            ij++;
            Location=new System.Drawing.Point(Location.X, Location.Y-5);
            if (ij == 5)
            {
                h1.Enabled=false;
                h2.Enabled=true;
            }
        }

        private void h2_Tick(object sender, EventArgs e)
        {
            ij--;
            Location = new System.Drawing.Point(Location.X, Location.Y + 5);
            if (ij ==0)
            {
                h2.Enabled = false;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Versions_list versions_List = new Versions_list();
            versions_List.ShowDialog();
        }

        private void javalj_TextChanged(object sender, EventArgs e)
        {
            javaxx.Text = "获取中...";
        }

        private void DWJC_Tick(object sender, EventArgs e)
        {
            dow++;
            if (dow > 150)
            {
                if (IsProcessRunning("java") || IsProcessRunning("javaw"))
                {
                    if (IsProcessRunning("java") || IsProcessRunning("javaw"))
                    {
                        taa = 1;
                    }
                }
                else if (taa == 0)
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

        
        public class Account
        {
            public string PlayerName { get; set; }
            public int LoginMethod { get; set; }
            public bool Selected { get; set; }
            public string ver { get; set; }
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
            catch (Exception ex)
            {
                Error(1, ex.ToString());
                return null;
            }
        }
    }
}
