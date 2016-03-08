using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy
{
    public class Developer : RegularEmployee
    {
        public Developer(uint id, string firstName, string lastName, decimal salary, DepartmanType departman) 
            : base(id, firstName, lastName, salary, departman)
        {
            this.Projects=new List<Project>();
        }

        public List<Project> Projects { get; }

        public void CloseProject(Project project)
        {
            bool found=false;

            for (int i = 0; i < this.Projects.Count; i++)
            {
                if (this.Projects[i].Name==project.Name)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new ArgumentException("Project is not parts of this developer's project.");
            }

            project.IsOpen = false;
        }
    }
}
