using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    [BlockComponent(ComponentType.ComputerUsb)]
    public sealed class ComputerUsbComponent : MonoBehaviour, IBlockComponent
    {
        public ComponentData Compile()
        {
            return new ComponentData()
            {
                Type = ComponentType.ComputerUsb
            };
        }

        public void Decompile(ComponentData componentData)
        {
            
        }
    }
}