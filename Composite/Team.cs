using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Team: IResource
    {
        private List<IResource> resources = new List<IResource>();

        public void add(IResource resource)
        {
            resources.Add(resource);
        }

        public void deploy()
        {
            foreach (var resource in resources)
            {
                resource.deploy();
            }
        }
    }
}
