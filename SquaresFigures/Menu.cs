namespace SquaresFigures
{
    public class Menu
    {
        private List<ContentMenu> ListMenu { get; set; } = new();

        public Menu() { }

        private void Expansion(ICalculation calc)
        {
            Console.WriteLine(calc.Calculate());
        }

        /// <summary>
        /// Метод для добавления элемента в список меню.
        /// </summary>
        /// <param name="listContent"></param>
        public void Create(ContentMenu listContent)
        {
            ListMenu.Add(listContent);
        }

        /// <summary>
        /// Метод для вывода списка меню.
        /// </summary>
        public void Read()
        {
            foreach (var item in ListMenu)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private ICalculation FoundObj(int obj)
        {
            return ListMenu
                .Where(s => s.Item == obj)
                .Select(s => s.Calculation).FirstOrDefault()!;
        }

        /// <summary>
        /// Метод для выполнения и перехода элемента меню.
        /// </summary>
        /// <param name="item"></param>
        public void CompleteItemMenu(int item)
        {
            Expansion(FoundObj(item));
        }
    }
}
