using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Adapter_Pattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }

        public void playMp4(string fileName)
        {
            
        }
    }
}
