using System;
using System.Collections.Generic;
using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    [BlockComponent(ComponentType.ScpDoor)]
    public sealed class ScpDoor : MonoBehaviour, IBlockComponent
    {
        public static readonly List<ScpDoor> AllDoors = new();
        public DefaultRoleTypeId Role;

        public ComponentData Compile()
        {
            return new ComponentData()
            {
                Type = ComponentType.ScpDoor,
                Properties = new Dictionary<string, object>()
                {
                    { nameof(Role), Role }
                }
            };
        }

        public void Decompile(ComponentData componentData)
        {
            if (componentData.Properties.TryGetValue("Role", out var roleObj))
            {
                Role = (DefaultRoleTypeId)Convert.ToSByte(roleObj);
            }
        }

        public void Awake()
        {
            AllDoors.Add(this);
        }

        public void OnDestroy()
        {
            AllDoors.Remove(this);
        }
    }
}