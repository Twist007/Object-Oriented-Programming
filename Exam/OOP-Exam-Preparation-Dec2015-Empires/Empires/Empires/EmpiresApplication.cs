using Empires.Core;
using Empires.Core.Factories;
using Empires.IO;

namespace Empires
{
    class EmpiresApplication
    {
        public static void Main(string[] args)
        {
            var buildingFactory=new BuildingFactory();
            var unitFactory=new UnitFactory();
            var resourseFactory=new ResourceFactory();
            var reader=new ConsoleReader();
            var writer= new ConsoleWriter();
            var  data=new EmpiresData();

            var engine=new Engine(buildingFactory,resourseFactory,unitFactory,data,reader,writer);
            engine.Run();
        }
    }
}
