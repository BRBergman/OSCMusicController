using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;




namespace WinFormsApp1
{
    internal class MediaPlayer
    {

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;// code to jump to next track
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;// code to play or pause a song
        public const int VK_MEDIA_PREV_TRACK = 0xB1;// code to jump to prev track

        public static void prev()
        {
            // Jump to previous track
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
        public static void next()
        {
            // Jump to previous track
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
        public static void play()//or pause
        {
            // Jump to previous track
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }



    }
}
