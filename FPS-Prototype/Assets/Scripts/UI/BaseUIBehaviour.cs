using FPSPrototype.Core.Assets.Scripts.Extensions;
using UnityEngine;
using UnityEngine.UIElements;

namespace FPSPrototype.Core.UI
{
    /// <summary>
    /// UI element based on Unity CSS
    /// </summary>
    [RequireComponent(typeof(UIDocument))]
    public class BaseUIBehaviour : MonoBehaviour
    {
        [SerializeField]
        protected UIDocument _UIDocument;

        private void Awake()
        {
            if (_UIDocument == null)
            {
                _UIDocument = GetComponent<UIDocument>();
            }
            this.ResolveUIControls(_UIDocument);
        }
    }
}