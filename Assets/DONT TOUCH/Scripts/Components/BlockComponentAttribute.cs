using System;
using DONT_TOUCH.Enums;

namespace DONT_TOUCH.Scripts.Components
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BlockComponentAttribute : Attribute
    {
        public ComponentType Type { get; }
    
        public BlockComponentAttribute(ComponentType type)
        {
            Type = type;
        }
    }
}