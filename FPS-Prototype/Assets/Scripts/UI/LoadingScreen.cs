using FPSPrototype.Core.Inftrastructure.Services;
using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace FPSPrototype.UI
{
    /// <summary>
    /// Load screen for wait scene
    /// </summary>
    public class LoadingScreen : MonoBehaviour
    {
        [SerializeField]
        private Text _loadingPercentValue;

        [SerializeField]
        private Slider _progressBar;

        private AsyncOperation _asyncOperation;

        private CoroutineService _coroutineService;

        [Inject]
        private void Construct(AsyncOperation asyncOperation, CoroutineService coroutineService)
        {
            _asyncOperation = asyncOperation;
            _coroutineService = coroutineService;
            _coroutineService.StartCoroutine(WaitOperation(_asyncOperation));
        }

        private void Start()
        {
        }

        private IEnumerator WaitOperation(AsyncOperation operation)
        {
            while (operation.isDone == false)
            {
                float progress = Mathf.Clamp01(operation.progress / 0.9f);
                _progressBar.value = progress;
                _loadingPercentValue.text = progress.ToString("P", CultureInfo.InvariantCulture);
                yield return null;
            }
        }

        public class Factory : PlaceholderFactory<AsyncOperation, LoadingScreen>
        {
        }
    }
}