using UnityEngine;
using UnityEngine.UIElements;

namespace FPSPrototype.UI
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Menu buttons")]
        [SerializeField]
        private Button exitButton;

        private void Awake()
        {
            exitButton.clicked += OnExitClick;
        }

        private void OnExitClick()
        {
            throw new System.NotImplementedException();
        }
    }
}