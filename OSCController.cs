using Rug.Osc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
	internal class OSCController
	{
		static IPAddress localip = new(127001); // idk if this even works
		static int port = 9000;
		static Rug.Osc.OscSender OSCSender = new (localip,port);
		static Rug.Osc.OscReceiver OSCReceiver = new (localip,port);
		public OSCController()
		{
			OSCSender.Connect();
			OSCReceiver.Connect();
		}
		~OSCController()
		{
			OSCSender.Dispose();
			OSCReceiver.Dispose();
		}
		void oscSend() 
		{
			//todo: send the current state of the music
		}
		void oscReceive() 
		{
			//get inputs

			OscPacket paacket;
			paacket = OSCReceiver.Receive();
			//todo: see if this even works, read from oscpacket 
		}

		//https://github.com/dastevens/CoreOSC
	}

	

}
