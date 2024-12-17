using System.Collections.Generic;

namespace Hangman
{
    class Scene
    {
        protected List<GameObject> GameObjectsInScene;

        public virtual void Start(Renderer renderer, Scene[] scenes, int currentIndex, string word = null)
        {
            renderer.Reset();
            renderer.AddGameObjectsForRendering(GameObjectsInScene);
            renderer.Render();
        }

        public virtual void ChangeScene(Scene[] scenes, int index) { }

        public List<GameObject> GetGameObjectsInScene()
        {
            return GameObjectsInScene;
        }
    }
}
