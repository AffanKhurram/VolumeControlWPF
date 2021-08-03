using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace VolumeControlWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InterceptKeys.InitializeComponent();

        }
        public new void Shutdown ()
        {
            InterceptKeys.UnhookWindowsHookEx(InterceptKeys._hookID);
        }
    }
}
