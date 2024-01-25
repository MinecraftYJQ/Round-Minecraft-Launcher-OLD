using Launcher.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Launcher.cs
{
    internal class Info_Box
    {
        public Info_Box(string Text,string Title,MessageBoxButtons messagebutton,MessageBoxIcon icon)
        {
            Console.WriteLine(Text+Title+messagebutton+icon);
            /*Info_Box_Window info_Box_Window=new Info_Box_Window(Text,Title,messagebutton,icon);
            info_Box_Window.ShowDialog();*/
            System.Windows.Forms.MessageBox.Show(Text,Title,messagebutton,icon);
        }
    }
}
