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

        public void Create(ContentMenu listContent)
        {
            ListMenu.Add(listContent);
        }

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

        public void CompleteItemMenu(int item)
        {
            Expansion(FoundObj(item));
        }
    }
}
