using Capitalisam.Execution;
using Capitalisam.Interfaces;

namespace Capitalisam
{
   public class Program
    {
        public static void Main(string[] args)
        {
            IEngine engine = new CapitalisamEngine();
            engine.Run();
        }
    }
}
