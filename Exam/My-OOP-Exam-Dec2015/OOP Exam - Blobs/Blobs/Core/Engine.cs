using System;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Engine : IRunadle
    {
        private IBlobsCreator creator;
        private IBlobsData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public IBlobsCreator Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        public IBlobsData Data
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
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            string command = inputParams[0];

            switch (command)
            {
                case "create":
                    this.ExecuteCreateCommand(inputParams[1], int.Parse(inputParams[2]), int.Parse(inputParams[3]),
                        inputParams[4], inputParams[5]);
                    break;
                case "attack":
                    this.ExecuteAttackComand(inputParams[1], inputParams[2]);
                    break;
                case "status":
                    ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Unkwnon command.");
            }
        }

        private void ExecuteStatusCommand()
        {

        }

        private void ExecuteAttackComand(string attacker, string target)
        {

        }

        private void ExecuteCreateCommand(string name, int helath, int damage, string behavior, string attack)
        {
            //var blob = creator.CreateBlob(name, helath, damage, behavior, attack);
            //this.data.AddBlobs(blob);
        }
    }
}
