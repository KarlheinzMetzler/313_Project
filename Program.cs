using System;
using System.Collections.Generic;
using System.Linq;
using System.text;

namespace Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			DigitalO dout = new DigitalO();
			dOut.openChannel();
			dOut.WriteData(0); // 0: fan/heater off, 1: fan on, 2: heater on, 3: fan/heater on

			/*
			AnalogI aIn = new AnalogI();
			aIn.OpenChannel();
			aIn.ReadData();
			*/
		}
	}
}
