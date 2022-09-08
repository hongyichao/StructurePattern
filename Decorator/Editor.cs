using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Editor
    {
        public void openProject(String path)
        {
            List<IArtefact> artefacts = new List<IArtefact>{
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider")
            };

            artefacts[1] = new ErrorArtefact(artefacts[1]);
            artefacts[0] = new MainArtefact(artefacts[0]);

            foreach (var a in artefacts) 
            {
                Console.WriteLine(a.Render());                
            }
        }
    }
}
