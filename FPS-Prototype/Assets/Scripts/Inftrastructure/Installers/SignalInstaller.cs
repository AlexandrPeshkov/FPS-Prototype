using FPSPrototype.Common.Signals;
using Zenject;

namespace FPSPrototype.Core.Assets.Scripts.Inftrastructure.Installers
{
    public class SignalInstaller : MonoInstaller<SignalInstaller>
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<LoadSceneSignal>();
        }
    }
}