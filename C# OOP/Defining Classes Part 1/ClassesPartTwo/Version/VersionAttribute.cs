using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPartTwo.Version
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | 
        AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
            this.Version = major + "." + minor;
        }

        public int Major { get; set; }

        public int Minor { get; set; }

        public string Version { get; private set; }
    }
}
