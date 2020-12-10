﻿using FPSPrototype.Core.Common.Interfaces;
using UnityEngine;
using Zenject;

namespace FPSPrototype.Core.Scenes
{
    public abstract class BaseSceneContainer : MonoBehaviour, ISceneSubContainer
    {
        public abstract void InstallDependencies(DiContainer container);
    }
}