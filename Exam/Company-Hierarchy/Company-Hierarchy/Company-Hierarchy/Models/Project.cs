using System;

namespace Company_Hierarchy
{
    public class Project
    {
        public Project(string name, string details, DateTime? startData, bool isOpen)
        {
          this.Name = name;
          this.Details = details;
          this.StartData = startData;
          this.IsOpen = isOpen;
        }

        public string Name { get; set; }

        public string Details { get; set; }

        public DateTime? StartData { get; set; }

        public bool IsOpen { get; set; }

    }
}
