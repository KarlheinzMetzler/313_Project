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


      }

      public void ReadData()
      {


      }
  }
}
