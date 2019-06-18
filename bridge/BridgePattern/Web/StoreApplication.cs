using BridgePattern.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Web
{
    public class StoreApplication : BaseWebApplication
    {
        public StoreApplication(params Theme[] themes): base(themes) { }

        public override void Init()
        {
            Console.WriteLine("Приложение магазина инициализировано: ");
            Themes?.ToList().ForEach((x) => x.Draw());
        }
    }
}
