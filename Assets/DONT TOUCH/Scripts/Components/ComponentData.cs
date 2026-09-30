using System;
using System.Collections.Generic;
using DONT_TOUCH.Enums;

namespace DONT_TOUCH.Scripts.Components
{
    [Serializable]
    public sealed class ComponentData
    {
        public ComponentType Type { get; set; }
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}

