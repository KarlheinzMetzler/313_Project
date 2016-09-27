using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;
using NationalInstruments;

namespace Lab
{
  class Analogl
  {
      //create a new task for an analog input
      Task analogIn = new Task();
      //create a new single analog channel reader
      AnalogSingleChannelReader reader;
      //create new AnalogWaveform type to hold the read data
      NationalInstruments.AnalogWaveform<double> data;
      int samplesPerChannel = 20;

      public void OpenChannel()
      {
            //create a new analog inputChannel called "Ainport0"
            analogIn.AIChannels.CreateVoltageChannel("Dev0/ai0", "Ainport0", AITerminalConfiguration.Rse, -10.0, 10.0, AIVoltageUnits.volts);
            //configure timing specs
            analogIn.Timing.ConfigureSampleClock("", 100.0, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, samplesPerChannel);
            //Initialise the single analog input channel reader
            reader = new AnalogSingleChannelReader(analogIn.Stream);
      }

      public void ReadData()
      {
          data = reader.ReadWaveform(samplesPerChannel);

          for(int i = 0; i < samplesPerChannel; i++)
            Console.WriteLine("Sample{0}=>time={1}, value{2}", i +1, data.Samples[i].TimeStamp, data.Samples[i].Value);
          //Clear the Task
          analogIn.Dispose();

      }
  }
}
