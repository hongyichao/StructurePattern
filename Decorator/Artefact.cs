using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Artefact : IArtefact
    {
        public string item;
        public Artefact(string item) 
        { 
            this.item = item;
        }

        public string Render()
        {
            return "rendering: " + item;
        }
    }
}
