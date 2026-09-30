namespace DONT_TOUCH.Scripts.Components
{
    public interface IBlockComponent
    {
        public ComponentData Compile();
        public void Decompile(ComponentData componentData);
    }
}