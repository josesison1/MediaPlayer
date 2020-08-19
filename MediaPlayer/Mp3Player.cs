using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    class Mp3Player : IPanel
    {
        private string deviceName;
        public string DeviceName { get => deviceName; }

        public Mp3Player()
        {
            deviceName = "MP3";
        }
        
        public Mp3Player (string playerName)
        {
            deviceName = playerName;
        }

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
            Console.WriteLine($" ...fast forwarding {deviceName} player." );
        }
        public bool Stop()
        {
            Console.WriteLine($" ...stopping {deviceName} player.");
            return false;
        }
        public void Record()
        {
            Console.WriteLine($" ...{deviceName} is recording.");
        }
    }
}
