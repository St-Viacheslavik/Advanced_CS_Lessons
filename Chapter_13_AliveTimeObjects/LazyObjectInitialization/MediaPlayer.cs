using System;

namespace LazyObjectInitialization
{
    public class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }

        private readonly Lazy<AllTracks> _allTracks = new Lazy<AllTracks>();

        public AllTracks GerAllTracks()
        {
            return _allTracks.Value;
        }
    }
}
