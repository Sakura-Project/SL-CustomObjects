using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    [BlockComponent(ComponentType.CameraSystem)]
    public sealed class CameraSystemComponent : MonoBehaviour, IBlockComponent
    {
        public ComponentData Compile()
        {
            return new ComponentData()
            {
                Type = ComponentType.CameraSystem,
            };
        }

        public void Decompile(ComponentData componentData)
        {
        }
    }
}