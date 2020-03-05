using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MusicApp
{
    class Mp3Player : IDisposable
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lp, int lenght, IntPtr callback);

        public void Dispose()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void open(string file)
        {
            String format = @"open ""{0}""type MPEGVideo alias MediaFile";
            string command = string.Format(format, file);
            mciSendString(command,null,0,IntPtr.Zero); 

        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
