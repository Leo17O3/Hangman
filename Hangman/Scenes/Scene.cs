using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Scene
    {
        protected List<GameObject> GameObjectsInScene;

        public virtual void Start(Renderer renderer, string word = null)
        {
            renderer.Reset();
            renderer.AddGameObjectsForRendering(GameObjectsInScene);
            renderer.Render();
        }

        public virtual void ChangeScene() { }

        public List<GameObject> GetGameObjectsInScene()
        {
            return GameObjectsInScene;
        }
    }
}
