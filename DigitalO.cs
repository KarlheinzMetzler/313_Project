using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;

namespace Lab
{
	class DigitalO
	{
		//Create a new task for a digital channel
		Task digitalOut = new Task();
		//Create a new single channel writer
		DigitalSingleChannelWriter writer;
		
		public void OpenChannel(string portLine, string portName)
		{
			//Create a new digital output channel called "Doutport0"
			digitalOut.DOChannels.CreateChannel("dev1/port0", "DigitalChn0", ChannelLineGrouping.OneChannelForAllLines);
			
			//Initialise the single channel writer and assign stream of channel to it
			writer = new DigitalSingleChannelWriter(digitalOut.Stream);
		}
		
		public void WriteData(int length)
		{
			//call WriteSingleSamplePort method to write data to the channel
			if(writer != null)
				writer.WriteSingleSamplePort(true, (UInt32)length);
		}
	}
}