using Launcher.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.cs
{
    internal class MessageBox_NB
    {
        public MessageBox_NB(int X,int Y,int w,int h,string title,string text) 
        {
            /*bj bj=new bj(X,Y,w,h,title,text);
            bj.ShowDialog();*/
            MessageBox.Show(text,title,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
