using System;
using System.Collections;
using UnityEngine;

namespace FPSPrototype.Core.Inftrastructure.Services
{
    /// <summary>
    /// GameObject for start all coroutines
    /// </summary>
    internal class CoroutineHolder : MonoBehaviour
    { }

    public class CoroutineService : IDisposable
    {
        private CoroutineHolder _runner;

        private CoroutineService()
        {
            _runner = new GameObject("Static Coroutine Client").AddComponent<CoroutineHolder>();
            UnityEngine.Object.DontDestroyOnLoad(_runner);
        }

        public Coroutine StartCoroutine(IEnumerator coroutine) => _runner?.StartCoroutine(coroutine);

        public void Dispose()
        {
            UnityEngine.Object.DestroyImmediate(_runner);
        }
    }
}