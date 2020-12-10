using FPSPrototype.Core.Common.Attrubutes;
using FPSPrototype.Core.UI;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace FPSPrototype.Core.Assets.Scripts.Extensions
{
    /// <summary>
    /// Extensions for UI elements
    /// </summary>
    public static class UIBehaviourExtensions
    {
        /// <summary>
        /// Automatically set ui field reference to ui document block by id attribute;
        /// </summary>
        /// <param name="UIDocument"></param>
        /// <param name="control"></param>
        public static void ResolveUIControls<TControl>(this TControl control, UIDocument UIDocument) where TControl : BaseUIBehaviour
        {
            if (UIDocument == null || control == null)
            {
                Debug.LogError("BaseUIBehaviour have null references");
                return;
            }

            var fields = control.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                UCSSAttribute ucss = field.GetCustomAttribute<UCSSAttribute>();
                if (ucss != null)
                {
                    VisualElement visualElement = UIDocument.rootVisualElement.Q(ucss.Name, ucss.Classes);
                    if (visualElement != null)
                    {
                        field.SetValue(control, visualElement);
                    }
                    else
                    {
                        Debug.LogError($"Cannot resolve UI field with id {ucss.Name} on {control.name}");
                    }
                }
            }
        }
    }
}