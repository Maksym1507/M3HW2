using Autofac;
using M3HW2.Configs;

namespace M3HW2
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}