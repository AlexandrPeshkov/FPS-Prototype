using FPSPrototype.Core.Inftrastructure.Services;
using Zenject;

namespace FPSPrototype.Core.Inftrastructure.Installers
{
    public class ServiceInstaller : MonoInstaller<ServiceInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<Startup>().AsSingle().NonLazy();

            Container.Bind<SceneService>().AsSingle().NonLazy();
            Container.Bind<CoroutineService>().AsSingle().NonLazy();

            SetExecutionOrder();
        }

        private void SetExecutionOrder()
        {
        }
    }
}