using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Adapter_Pattern
{
    public interface IMediaPlayer
    {
        void play(string audioType, string fileName);
    }
}
