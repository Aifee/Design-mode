using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Adapter_Pattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMusicPlayer;
        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }
        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
