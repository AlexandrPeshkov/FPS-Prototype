using FPSPrototype.Core.Common.Attrubutes;
using FPSPrototype.Core.UI;
using UnityEngine;
using UnityEngine.UIElements;

namespace FPSPrototype.UI
{
    /// <summary>
    /// Game main menu controller
    /// </summary>
    [RequireComponent(typeof(UIDocument))]
    public class MainMenu : BaseUIBehaviour
    {
        //menu buttons
        [UCSS("menu-button-connect")]
        private Button _connectButton;

        [UCSS("menu-button-create")]
        private Button _createHostButton;

        [UCSS("menu-button-settings")]
        private Button _settingsButton;

        [UCSS("menu-button-exit")]
        private Button _exitButton;

        private void OnEnable()
        {
            _connectButton.clicked += OnConnectButtonClick;
            _createHostButton.clicked += OnCreateButtonClick;
            _settingsButton.clicked += OnSettingsButtonClick;
            _exitButton.clicked += OnExitClick;
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