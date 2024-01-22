using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WNPReduxAdapterLibrary;





namespace WinFormsApp1
{
    /*
    class webnowplaying //https://www.nuget.org/packages/WNPRedux-Adapter-Library/
    {
        void init()
        {
            void logger(WNPRedux.LogType type, string message)
            {
                Console.WriteLine($"{type}: {message}");

            }
            WNPRedux.Initialize(1234, "1.0.0", logger);
            

        }
        ~webnowplaying()
        {
            WNPRedux.Close();
        }

    }*/
    internal class MediaPlayer
    {
        static void logger(WNPRedux.LogType type, string message)
        {
            Console.WriteLine($"{type}: {message}");
        }
        ~MediaPlayer()
        {
            close();
        }
        public static void open(int port)
        {
            WNPRedux.Initialize(port, "1.0.0", logger);
        }
        public static void close()
        {
            WNPRedux.Close();
        }
    

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;// code to jump to next track
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;// code to play or pause a song
        public const int VK_MEDIA_PREV_TRACK = 0xB1;// code to jump to prev track

        public static void Prev(bool WNP)
        {
            if (WNP)
            {
                WNPRedux.mediaEvents.Previous();
            }
            else
            {
				keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
			}
		}
        public static void Next(bool WNP)
        {   
            if(WNP)
            { WNPRedux.mediaEvents.Next(); }
            else
            {
			    keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
			}
		}
        public static void PausePlay(bool WNP)
        {
            if (WNP)
            {
                WNPRedux.mediaEvents.TogglePlaying();
            }
            else
            {
                keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
            }
        }



    }
}
