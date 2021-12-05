using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Grafcet.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Grafcet.App(), args);
            host.Run();
        }
    }
}
