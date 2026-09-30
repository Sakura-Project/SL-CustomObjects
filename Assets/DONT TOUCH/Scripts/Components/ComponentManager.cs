using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using DONT_TOUCH.Enums;
using UnityEngine;

namespace DONT_TOUCH.Scripts.Components
{
    public static class ComponentManager
    {
        private static readonly Dictionary<ComponentType, Type> BlockComponents = new();
        private static bool ComponentsRegistered => BlockComponents.Count > 0;
        
        public static void RegisterAll()
        {
            BlockComponents.Clear();

            var componentTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass 
                            && !t.IsAbstract 
                            && typeof(IBlockComponent).IsAssignableFrom(t)
                            && typeof(MonoBehaviour).IsAssignableFrom(t));

            foreach (var type in componentTypes)
            {
                var attr =  type.GetCustomAttribute<BlockComponentAttribute>();
                if (attr == null)
                {
                    continue;
                }
            
                if (!BlockComponents.TryAdd(attr.Type, type))
                    continue;
            }
        }

        public static bool TryAddComponent(GameObject go, ComponentType type, [NotNullWhen(true)] out IBlockComponent? component)
        {
            if (!ComponentsRegistered)
            {
                RegisterAll();
            }
            component = null;
            if (go == null)
            {
                Debug.LogError("Failed create component: GameObject is null.");
                return false;
            }

            if (!BlockComponents.TryGetValue(type, out var componentType))
            {
                Debug.LogError("Failed create component: Type not found.");
                return false;
            }

            component = go.AddComponent(componentType) as IBlockComponent;
            if (component == null)
            {
                Debug.LogError("Failed create component: unity not created component.");
                return false;
            }
            return true;
        }

        public static void AssignComponents(GameObject go, List<ComponentData> data)
        {
            foreach (var componentData in data)
            {
                if (TryAddComponent(go, componentData.Type, out var component))
                {
                    component.Decompile(componentData);
                }
            }
        }
    }
}