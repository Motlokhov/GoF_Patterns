namespace GoF_Patterns.Struct.Composite
{
    /// <summary>
    /// интерфейс для минимально простого объекта
    /// </summary>
    internal interface ILeaf
    {
        /// <summary>
        /// Операция или набор операций который будут выполнятся родителем
        /// </summary>
        void SomeOperation(); 
    }
}
