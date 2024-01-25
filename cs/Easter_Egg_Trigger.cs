using Launcher.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs
{
    internal class Easter_Egg_Trigger
    {
        string day_time = DateTime.Now.ToString("MM-dd");
        public Easter_Egg_Trigger()
        {
            Judgment(day_time);
        }
        private void Judgment(string day)
        {
            Console.WriteLine(day_time);
            if (day == "03-27")
            {
                Console.WriteLine("彩蛋-LXB生日触发");
                Birthday_Happy birthday_Happy = new Birthday_Happy();
                birthday_Happy.ShowDialog();
            }
            if (day == "12-25")
            {
                Console.WriteLine("彩蛋-圣诞节触发");
                Christmas_Happy christmas_Happy = new Christmas_Happy();
                christmas_Happy.Show();
            }
        }
    }
}
