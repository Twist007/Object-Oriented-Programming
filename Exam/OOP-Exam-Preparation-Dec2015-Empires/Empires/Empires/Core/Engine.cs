using System;
using System.Linq;
using System.Text;
using Empires.Charachters;
using Empires.Enums;

namespace Empires.Core
{
    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourseFactory resourseFactory;
        private IUnitFactory unitFactory;
        private IEmpiresData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory, IResourseFactory resourseFactory, IUnitFactory unitFactory, IEmpiresData data, IInputReader reader, IOutputWriter writer)
        {
            this.BuildingFactory = buildingFactory;
            this.ResourseFactory = resourseFactory;
            this.UnitFactory = unitFactory;
            this.Data = data;
            this.Reader = reader;
            this.Writer = writer;
        }

        public IBuildingFactory BuildingFactory
        {
            get { return buildingFactory; }
            set { buildingFactory = value; }
        }

        public IResourseFactory ResourseFactory
        {
            get { return resourseFactory; }
            set { resourseFactory = value; }
        }

        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }

        public IEmpiresData Data
        {
            get { return data; }
            set { data = value; }
        }

        public IInputReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }

        public IOutputWriter Writer
        {
            get { return writer; }
            set { writer = value; }
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.data.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resources[resource.ResourceType] += resource.Quantity;
                }

                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unkwnon command.");

            }
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            this.AppendTreasuryInfo(output);

            this.AppendBuildingInfo(output);

            this.AppendUnitsInfo(output);

            this.writer.PrintLine(output.ToString().Trim());

        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.Append($"--{unit.Key}: {unit.Value}{Environment.NewLine}");
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (IBuilding building in this.data.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.data.Resources)
            {
                output.Append($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, resourseFactory, unitFactory);

            this.data.AddBuilding(building);
        }
    }
}
