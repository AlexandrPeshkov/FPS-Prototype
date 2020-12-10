using UnityEngine;
using Zenject;

namespace FPSPrototype.UI.Inftrastructure.Installers
{
    public class ComponentInstaller : MonoInstaller<ComponentInstaller>
    {
        [SerializeField]
        private LoadingScreen _loadingScreenPrefab;

        public override void InstallBindings()
        {
            Container.BindFactory<AsyncOperation, LoadingScreen, LoadingScreen.Factory>()
                .FromComponentInNewPrefab(_loadingScreenPrefab);
        }
    }
}