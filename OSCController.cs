using Rug.Osc;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
	class OSCController// https://opensoundcontrol.stanford.edu/spec-1_0.html
	{
		static IPAddress localip = IPAddress.Parse("127.0.0.1");
		static int port = 9001;
		//static Rug.Osc.OscSender OSCSender = new(localip, port);
		static Rug.Osc.OscReceiver OSCReceiver = new(localip, port);

		const string PausePlay = "1";
		const string Next = "2";
		const string Prev = "3";
		public OSCController()
		{
			//OSCSender.Connect();
			OSCReceiver.Connect();
		}
		~OSCController()
		{
			Dispose();
		}
		public void oscSend()
		{
			//todo: send the current state of the music
		}
		public void oscReceive()
		{
			try
			{
				while (OSCReceiver.State != OscSocketState.Closed)
				{

					if (OSCReceiver.State == OscSocketState.Connected)
					{
						OscPacket packet = OSCReceiver.Receive();
						Console.WriteLine(packet.ToString());
						string[] OSCString = packet.ToString().Split(',');
						string Address = OSCString[0];
						string[] message = new string[OSCString.Length - 1];
						for (int i = 1; i < OSCString.Length; i++) 
						{
							message[i-1] = OSCString[i].Trim(new char[] { '"', ' ' });
						}

						foreach (string str in message)
						{
							if (Address == "/avatar/parameters/VRCEmote")
							{

								if (str == PausePlay)
								{
									MediaPlayer.PausePlay();
								}
								if ( str == Next)
								{
									MediaPlayer.Next();
								}
								if ( str == Prev)
								{
									MediaPlayer.Prev();
								}
							}
						}
						
					}
				}
			}
			catch (Exception ex)
			{
				// if the socket was connected when this happens
				// then tell the user
				if (OSCReceiver.State == OscSocketState.Connected)
				{
					Console.WriteLine("Exception in listen loop");
					Console.WriteLine(ex.Message);
				}
			}
		}

		public static void Dispose()
		{
			//OSCSender.Dispose();
			OSCReceiver.Dispose();//fix this 
		}
	}
}
