namespace MyPizzaRazorPages.model
{
    public class MenuItem : IMenuItem
    {
        public MenuItem()
        {
        }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
        }

        public int Number { get;  set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }

        public virtual string GetInfo()
        {
            return "";
        }

        public override string ToString()
        {
            return $"{nameof(Number)}={Number.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Price)}={Price.ToString()}, {nameof(Type)}={Type.ToString()}, {nameof(IsVegan)}={IsVegan.ToString()}";
        }
    }
}
