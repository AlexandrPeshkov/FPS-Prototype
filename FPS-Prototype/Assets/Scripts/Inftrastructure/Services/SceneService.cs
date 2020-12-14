using FPSPrototype.Common.Constants;
using FPSPrototype.Common.Signals;
using FPSPrototype.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace FPSPrototype.Core.Inftrastructure.Services
{
    /// <summary>
    /// Scene loader service
    /// </summary>
    public class SceneService
    {
        private readonly LoadingScreen.Factory _loadingScreenFactory;

        private readonly ZenjectSceneLoader _sceneLoader;

        private readonly CoroutineService _coroutineService;

        private readonly DiContainer _container;

        private string CurrentScene { get; set; } = SceneNames._rootScene;

        public SceneService(SignalBus signalBus,
            LoadingScreen.Factory loadingScreenFactory,
            DiContainer container,
            ZenjectSceneLoader sceneLoader,
            CoroutineService coroutineService)
        {
            _loadingScreenFactory = loadingScreenFactory;
            _container = container;
            _coroutineService = coroutineService;
            _sceneLoader = sceneLoader;

            signalBus.Subscribe<LoadSceneSignal>(LoadSceneSignalHandler);
        }

        private void LoadSceneSignalHandler(LoadSceneSignal signal)
        {
            AsyncOperation loadSceneOperation = _sceneLoader.LoadSceneAsync(signal.SceneName, LoadSceneMode.Single);

            Canvas sceneCanvas = GetSceneMainCanvas(CurrentScene);

            LoadingScreen loadingScreen = _loadingScreenFactory.Create(loadSceneOperation);
            loadingScreen.transform.SetParent(sceneCanvas.transform, false);

            //_coroutineService.StartCoroutine(loadingScreen.WaitOperation(loadSceneOperation));

            CurrentScene = signal.SceneName;
        }

        private Canvas GetSceneMainCanvas(string scene)
        {
            return _container.ResolveId<Canvas>(scene);
        }
    }
}