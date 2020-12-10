using UnityEngine.SceneManagement;

namespace FPSPrototype.Common.Signals
{
    public class LoadSceneSignal
    {
        public string SceneName { get; private set; }

        public LoadSceneMode Mode { get; private set; }

        public LoadSceneSignal(string scene, LoadSceneMode mode = LoadSceneMode.Single)
        {
            SceneName = scene;
            Mode = mode;
        }
    }
}