namespace Television
{
    using ElectronicProduct;

    public class Television : ElectronicProduct
    {
        public string Screen { get; set; }
        public bool IsSmart { get; set; }

        public Television(string screen, bool isSmart, string name, string brand, string description, float price) 
            : base(name, brand, description, price)
        {
            Screen = screen;
            IsSmart = isSmart;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Screen: {Screen}, IsSmart: {IsSmart}");
        }
    }
}

