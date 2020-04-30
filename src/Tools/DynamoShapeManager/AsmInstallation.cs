using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoShapeManager
{
    internal class AsmInstallation
    {
        public Version Version { get; set; }
        public string Location { get; set; }

        public AsmInstallation(string location, Version version)
        {
            Location = location;
            Version = version;
        }
    }
}
