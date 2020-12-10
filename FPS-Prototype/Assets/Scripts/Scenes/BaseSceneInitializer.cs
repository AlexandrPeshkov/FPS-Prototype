using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace FPSPrototype.Core.Scenes
{
    public abstract class BaseSceneInitializer : MonoBehaviour
    {
        [SerializeField]
        private BaseSceneContainer sceneContainer;

        private DiContainer _container;

        protected readonly List<Action> _scenePipeline = new List<Action>();

        [Inject]
        private void Construct(DiContainer container)
        {
            _container = container;
            InitPipeline();
        }

        protected virtual void InitPipeline()
        {
            _scenePipeline.Add(AddDependencies);
        }

        private void Start()
        {
            ExecutePipeline();
        }

        protected void AddDependencies()
        {
            sceneContainer.InstallDependencies(_container);
        }

        private void ExecutePipeline()
        {
            foreach (var action in _scenePipeline)
            {
                action?.Invoke();
            }
        }
    }
}