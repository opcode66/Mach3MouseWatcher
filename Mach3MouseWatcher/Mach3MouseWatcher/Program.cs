//Written by Todd R. Mariana a.k.a. Opcode66
//http://mantra.audio http://deepgroovesmastering.com http://groovegraphics.net http://cutterheadrepair.com

using System;
using System.Windows.Forms;

namespace Mach3MouseWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
