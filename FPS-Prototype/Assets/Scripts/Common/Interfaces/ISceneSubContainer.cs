using Zenject;

namespace FPSPrototype.Core.Common.Interfaces
{
    public interface ISceneSubContainer
    {
        void InstallDependencies(DiContainer container);
    }
}