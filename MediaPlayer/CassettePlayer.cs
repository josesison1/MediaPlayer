using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    public class CassettePlayer : IPanel, IPowerSupply
    {
        string deviceName = "cassette player";

        public void Voltage()
        {
            Console.WriteLine($" {deviceName} requires 12 volts!.");
        }
        public void VolumeUp()
        {
            Console.WriteLine($" {deviceName} just got louder!.");
        }
        public CassettePlayer (string playerName)
        {
            deviceName = playerName;
        }
   
        public string DeviceName => deviceName;
        public bool Play()
        {
            Console.WriteLine($" {deviceName} is playing.");
            return true;
        }

        public void Pause()
        {
            Console.WriteLine($" ...pause the {deviceName} player.");
        }

        public void Ffwd()
        {
            Console.WriteLine($" ...fast forwarding {deviceName} player");
        }
        public bool Stop()
        {
            Console.WriteLine($" ...stopping {deviceName} player");
            return false;
        }
        public void Record()
        {
            Console.WriteLine($" ...{deviceName} is recording");
        }
    }
}
