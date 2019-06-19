using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Design
{
    public class LightTheme : Theme
    {
        public override void Draw()
        {
            Console.WriteLine("со светлой темой");
        }
    }
}
