using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TuViWinForm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}