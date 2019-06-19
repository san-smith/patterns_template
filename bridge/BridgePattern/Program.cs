using BridgePattern.Design;
using BridgePattern.Web;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример шаблона проектирования \"Мост\"");

            var blogApplication = new BlogApplication(new DarkTheme());
            var storeApplication = new StoreApplication(new LightTheme());
            var webSite = new WebSite(new LightTheme(), new DarkTheme());

            blogApplication.Init();
            Console.WriteLine();

            storeApplication.Init();
            Console.WriteLine();

            Console.WriteLine("Модифицируем реализацию ");
            storeApplication.Themes = new Theme[1] { new DarkTheme() };
            storeApplication.Init();
            Console.WriteLine();

            webSite.Init();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
