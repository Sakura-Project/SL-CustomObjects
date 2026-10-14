using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    [BlockComponent(ComponentType.RadioCenter)]
    public sealed class RadioCenterComponent : MonoBehaviour, IBlockComponent
    {
        public ComponentData Compile()
        {
            return new ComponentData()
            {
                Type = ComponentType.RadioCenter
            };
        }

        public void Decompile(ComponentData componentData)
        {
        }
    }
}