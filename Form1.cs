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
		OSCController oscController;

		public Form1()
		{

			InitializeComponent();
			oscController = new();	
			Thread myThread = new Thread(new ThreadStart(oscController.oscReceive));
			myThread.Start();
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
			MediaPlayer.PausePlay();
		}
		private void Next_Click(object sender, EventArgs e)
		{
			MediaPlayer.Next();
		}

		private void Prev_Click(object sender, EventArgs e)
		{
			MediaPlayer.Prev();
		}
		private static void logger(WNPRedux.LogType type, string message)
		{
			Console.WriteLine($"{type}: {message}");
		}

		private void Open_Click(object sender, EventArgs e)
		{
			WNPRedux.Initialize(int.Parse(PortTextBox.Text), "1.0.0", logger);
			OnOffBox.Checked = true;
		}

		private void Close_Click(object sender, EventArgs e)
		{
			WNPRedux.Close();
			OnOffBox.Checked = false;
		}

		private void PortTextBox_TextChanged(object sender, EventArgs e)
		{
			WNPRedux.Close();
			OnOffBox.Checked = false;
		}

		private void PortTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char numsOnly = e.KeyChar;

			if (!Char.IsDigit(numsOnly) && numsOnly != 8)
			{
				e.Handled = true;
			}
		}

		private void WNPEnabled_CheckedChanged(object sender, EventArgs e)
		{
			MediaPlayer.WebNowPlaying = WNPEnabled.Checked;
		}

		private void OSCEnable_CheckedChanged(object sender, EventArgs e)
		{
			

		}
				
	}
}