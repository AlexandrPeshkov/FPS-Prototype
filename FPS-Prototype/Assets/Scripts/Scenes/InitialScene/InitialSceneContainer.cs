using FPSPrototype.Common.Constants;
using FPSPrototype.Core.Scenes;
using UnityEngine;
using Zenject;

namespace FPSPrototype.Core.Inftrastructure.Installers.SceneContainers
{
    /// <summary>
    /// Dependencies of InitialScene
    /// </summary>
    public class InitialSceneContainer : BaseSceneContainer
    {
        [SerializeField]
        private Canvas _initialSceneCanvas;

        public override void InstallDependencies(DiContainer container)
        {
            container.Bind<Canvas>().WithId(SceneNames._rootScene).FromInstance(_initialSceneCanvas);
        }
    }
}