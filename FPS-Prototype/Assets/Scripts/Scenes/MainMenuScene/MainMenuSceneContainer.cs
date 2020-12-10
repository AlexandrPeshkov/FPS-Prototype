using FPSPrototype.Common.Constants;
using FPSPrototype.Core.Scenes;
using UnityEngine;
using Zenject;

namespace FPSPrototype.Core.Inftrastructure.Installers.SceneContainers
{
    /// <summary>
    /// Dependencies of MainMenuScene
    /// </summary>
    public class MainMenuSceneContainer : BaseSceneContainer
    {
        [SerializeField]
        private Canvas _mainMenuSceneCanvas;

        public override void InstallDependencies(DiContainer container)
        {
            container.Bind<Canvas>().WithId(SceneNames._mainMenuScene).FromInstance(_mainMenuSceneCanvas);
        }
    }
}