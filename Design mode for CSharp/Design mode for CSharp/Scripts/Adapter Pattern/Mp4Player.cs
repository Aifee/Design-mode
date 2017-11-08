using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Adapter_Pattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {
            throw new NotImplementedException();
        }

        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}
