namespace GoF_Patterns.Struct.Composite
{
    /// <summary>
    /// Описывает интерфейс составного объекта
    /// </summary>
    internal interface IComponent : ILeaf
    {
        void GetChild(int some_index);
        void Add(ILeaf leaf);
        void Remove(ILeaf leaf);
    }
}
