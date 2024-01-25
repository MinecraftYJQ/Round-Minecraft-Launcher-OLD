using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs
{
    internal class Message_fs
    {
        int off = 0;
        public Message_fs(string title,string text) 
        {
            Console.WriteLine("Message_fs启动");
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
            catch (Exception ex)
            {
                Error(1,ex.ToString());
            }
        }
        private void Error(int i,string ex)
        {
            Error error = new Error(i, ex);
            error.ShowDialog();
        }
    }
}
