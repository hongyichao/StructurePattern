using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class HumanResource: IResource
    {
        public void deploy()
        {
            Console.WriteLine("Deploying a human resource");
        }
    }
}
