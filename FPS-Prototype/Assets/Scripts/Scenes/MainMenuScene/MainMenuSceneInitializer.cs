using FPSPrototype.Core.Scenes;
using Zenject;

namespace FPSPrototype.Core.Assets.Scripts.Scenes
{
    public class MainMenuSceneInitializer : BaseSceneInitializer
    {
        private SignalBus _signalBus;

        [Inject]
        private DiContainer container;

        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        private void Awake()
        {
        }
    }
}