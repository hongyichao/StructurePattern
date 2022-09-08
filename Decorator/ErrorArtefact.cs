using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ErrorArtefact : IArtefact
    {
        private IArtefact artefact;        
        public ErrorArtefact(IArtefact artefact) 
        {
            this.artefact = artefact;
        }

        public string Render()
        {
            var item = this.artefact.Render();
            return item + " [Error]";
        }
    }
}
