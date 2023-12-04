namespace SquaresFigures
{
    public class ContentMenu
    {
        public int Item { get; private set; }
        public string Content { get; private set; }
        public ICalculation Calculation { get; private set; }

        public ContentMenu(int item, string content, ICalculation expansion) =>
            (Item, Content, Calculation) = (item, content, expansion);

        public override string ToString()
        {
            return $"{Item} - {Content}";
        }
    }
}