using System;

namespace FPSPrototype.Core.Common.Attrubutes
{
    /// <summary>
    /// Unity UI Builder (css\xml system) element identifier
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class UCSSAttribute : Attribute
    {
        public string Name { get; private set; }

        public string[] Classes { get; private set; }

        public UCSSAttribute(string name = null, params string[] classes)
        {
            Name = name;
            Classes = classes;
        }
    }
}