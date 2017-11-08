using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Bridge_Pattern
{
    public interface IDrawAPI
    {
        void drawCircle(int radius, int x, int y);
    }
}
