using BridgePattern.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Web
{
    public abstract class BaseWebApplication
    {
        public Theme[] Themes { get; private set; }

        public BaseWebApplication(Theme[] themes)
        {
            Themes = themes;
        }

        public abstract void Init();
    }
}
