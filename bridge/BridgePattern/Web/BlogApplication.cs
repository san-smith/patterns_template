using BridgePattern.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Web
{
    public class BlogApplication : BaseWebApplication
    {
        public BlogApplication(params Theme[] themes): base(themes) { }

        public override void Init()
        {
            Console.WriteLine("Блог инициализирован: ");
            Themes?.ToList().ForEach((x) => x.Draw());
        }
    }
}
