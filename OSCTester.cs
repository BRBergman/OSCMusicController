using Rug.Osc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1// just pull this up in vscode or something
{
	internal class OSCTester
	{
		OSCTester() {
			// See https://aka.ms/new-console-template for more information
			

			const string PausePlay = "PausePlay";
			const string Next = "Next";
			const string Prev = "Prev";

			IPAddress localip = IPAddress.Parse("127.0.0.1"); // idk if this even works
			Console.WriteLine(localip.ToString());
			int port = 9000;

			using (var sender = new OscSender(localip, port))
			{

				sender.Connect();
				if (sender.State == OscSocketState.Connected)
				{
					Console.WriteLine("connectes=");
					sender.Send(new OscMessage("/BergOSC/MusicBox", PausePlay));
				}
				sender.Close();
			}



			//OscMessage <- look into this 
			//https://opensoundcontrol.stanford.edu/spec-1_0.html

		}
	}
}
