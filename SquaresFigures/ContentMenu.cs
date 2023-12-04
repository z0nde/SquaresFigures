namespace SquaresFigures
{
    /// <summary>
    /// Элемент меню, в котором содержится: элемент меню, строка характеризующая и поясняющая 
    /// что означает элемент меню, и интерфейс, для выполнения элементов меню.
    /// </summary>
    public class ContentMenu
    {
        public int Item { get; private set; }
        public string Content { get; private set; }
        public ICalculation Calculation { get; private set; }

        /// <summary>
        /// Конструктор, в который передаётся элемент меню.
        /// </summary>
        /// <param name="item">Элемент</param>
        /// <param name="content">Строка для охарактеризовки элемента меню</param>
        /// <param name="expansion">Интерфейс для действия и выполнения меню</param>
        public ContentMenu(int item, string content, ICalculation expansion) =>
            (Item, Content, Calculation) = (item, content, expansion);

        public override string ToString()
        {
            return $"{Item} - {Content}";
        }
    }
}