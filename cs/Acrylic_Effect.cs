using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs
{
    internal class Acrylic_Effect
    {
        [DllImport("RMCL\\Acrylic_Effect.dll")]
        static extern bool Window(int jb);
        public Acrylic_Effect(int windowjb)
        {
            Window(windowjb);
        }
    }
}
