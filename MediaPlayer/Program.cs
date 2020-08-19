using System;
using System.Data.Common;

namespace MediaPlayer
{
    class Program
    {
        static void start ( IPanel player )
        {
            player.Play();
        }

        static void skip ( IPanel player)
        {
            player.Ffwd();
        }

        static void stop (IPanel player)
        {
            player.Stop();
        }

        static void record (IPanel player)
        {
            player.Record();
        }
        static void Main(string[] args)
        {
            var music = new Mp3Player("Jose's iPod");
            start(music);
            skip(music);
            stop(music);

            Console.WriteLine();

            var music01 = new CassettePlayer("1984 Ford Escort Cassette Player");
            start(music01);
            skip(music01);
            stop(music01);
            music01.VolumeUp();
            music01.Voltage();

            Console.WriteLine();

            var music02 = new Netflix("Connie's Sister's Netflix Account");
            start(music02);
            skip(music02);
            stop(music02);
            

        }
    }
}
