using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Design
{
    public class DarkTheme : Theme
    {
        public override void Draw()
        {
            Console.WriteLine("с тёмной темой");
        }
    }
}
