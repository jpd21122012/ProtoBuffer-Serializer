using ProtoSerialization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoSerialization.Data
{
    public static class ProjectObjects
    {
        public static List<Project> ProjectList = new List<Project>
        {
            new Project
            {
                ID = 1,
                Name = "Jorge Perales Diaz"
            }
        };
    }
}
