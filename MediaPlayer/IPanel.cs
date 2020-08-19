

namespace MediaPlayer
{
    interface IPanel
    {
        public string DeviceName { get; }
        bool Play();

        void Pause();

        void Ffwd();

        bool Stop();

        void Record();

    }
}
