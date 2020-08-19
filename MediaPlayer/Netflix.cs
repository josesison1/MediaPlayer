using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    class Netflix : IPanel
    {
        
        string deviceName = "media streaming";

        public Netflix(string playerName)
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
            Console.WriteLine($" ...fast forwarding {deviceName} player.");
        }
        public bool Stop()
        {
            Console.WriteLine($" ...stopping {deviceName} player.");
            return false;
        }

        public void Record()
        {
            Console.WriteLine($" ...{deviceName} is not allowed to record.");
        }
    }
}
