using WNPReduxAdapterLibrary;
using System.Threading;
using System;
using WebSocketSharp;

namespace WinFormsApp1
{
    /*
     * c# to webnowplaying media control    -- done
     * webnowplaying spotify support        -- done
     * text box of currently playing song   -- to do
     * osc to control the program           -- to do
     * control media from vrcaht avi        -- to do
    */
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        ~Form1()
        {
            WNPRedux.Close();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            WNPRedux.mediaEvents.TogglePlaying();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            WNPRedux.mediaEvents.Next();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            WNPRedux.mediaEvents.Previous();
        }
        private static void logger(WNPRedux.LogType type, string message)
        {
            Console.WriteLine($"{type}: {message}");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            WNPRedux.Initialize(1234, "1.0.0", logger);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            WNPRedux.Close();
        }

        
      
    }
}