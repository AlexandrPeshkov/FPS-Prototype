using FPSPrototype.Common.Constants;
using FPSPrototype.Common.Signals;
using Zenject;

namespace FPSPrototype.Core.Inftrastructure
{
    /// <summary>
    /// Application point entry
    /// </summary>
    public class Startup
    {
        private readonly SignalBus _signalBus;

        public Startup(SignalBus signalBus)
        {
            _signalBus = signalBus;
            Initialize();
        }

        public void Initialize()
        {
            _signalBus.Fire(new LoadSceneSignal(SceneNames._rootScene));
        }
    }
}