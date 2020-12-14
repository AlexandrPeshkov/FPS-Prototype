using FPSPrototype.Common.Constants;
using FPSPrototype.Common.Signals;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace FPSPrototype.UI
{
    /// <summary>
    /// Game main menu controller
    /// </summary>
    public class MainMenu : MonoBehaviour
    {
        #region UI

        //menu buttons
        [SerializeField]
        private Button _testPolygonButton;

        [SerializeField]
        private Button _connectButton;

        [SerializeField]
        private Button _createHostButton;

        [SerializeField]
        private Button _settingsButton;

        [SerializeField]
        private Button _exitButton;

        #endregion UI

        private SignalBus _signalBus;

        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        private void Awake()
        {
            _connectButton.onClick.AddListener(OnConnectButtonClick);
            _createHostButton.onClick.AddListener(OnCreateButtonClick);
            _settingsButton.onClick.AddListener(OnSettingsButtonClick);
            _exitButton.onClick.AddListener(OnExitClick);

            _testPolygonButton.onClick.AddListener(OnTestPolygonButtonClick);
        }

        private void OnConnectButtonClick()
        {
        }

        private void OnCreateButtonClick()
        {
        }

        private void OnSettingsButtonClick()
        {
        }

        private void OnTestPolygonButtonClick()
        {
            _signalBus.AbstractFire(new LoadSceneSignal(SceneNames._testPolygonScene));
        }

        private void OnExitClick()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}