using System.Collections.Generic;
using DONT_TOUCH.Enums;
using DONT_TOUCH.Scripts.Components;


public class SchematicBlockData
{
    public string Name { get; set; }

    public int ObjectId { get; set; }
    public int ParentId { get; set; }

    public virtual string AnimatorName { get; set; }

    public SerializableVector Position { get; set; }

    public SerializableVector Rotation { get; set; }

    public SerializableVector Scale { get; set; }

    public virtual BlockType BlockType { get; set; }
    public virtual List<ComponentData> Components { get; set; } = new();
    public virtual Dictionary<string, object> Properties { get; set; }
}