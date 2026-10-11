using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    [BlockComponent(ComponentType.Scp106SinkPaddle)]
    public sealed class Scp106SinkPaddle : MonoBehaviour, IBlockComponent
    {
        public ComponentData Compile()
        {
            return new ComponentData()
            {
                Type = ComponentType.Scp106SinkPaddle,
            };
        }

        public void Decompile(ComponentData componentData)
        {
        
        }
    }
}