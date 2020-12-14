using FPSPrototype.Common.Constants;
using FPSPrototype.Common.Signals;
using Zenject;

namespace FPSPrototype.Core.Scenes
{
    public class InitialSceneInitializer : BaseSceneInitializer
    {
        private SignalBus _signalBus;

        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        protected override void InitPipeline()
        {
            base.InitPipeline();
            _scenePipeline.Add(LoadMainMenuScene);
        }

        private void LoadMainMenuScene()
        {
            _signalBus.AbstractFire(new LoadSceneSignal(SceneNames._mainMenuScene));
        }

        private void Awake()
        {
        }
    }
}