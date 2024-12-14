using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            DiedPerson diedPerson = new DiedPerson();
            renderer.AddGameObjectsForRendering(diedPerson.GetDiedPersonParts());
            renderer.Render();
        }
    }

    
}
