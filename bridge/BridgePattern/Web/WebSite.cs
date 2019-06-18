using BridgePattern.Design;
using BridgePattern.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Web
{
    public class WebSite : BaseWebApplication
    {
        public WebSite(params Theme[] themes) : base(themes) { }

        public override void Init()
        {
            Console.WriteLine("Веб-сайт инициализирован: ");
            Themes?.ToList().ForEach((x) => x.Draw());
        }
    }
}
