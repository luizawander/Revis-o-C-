namespace ElectronicProduct
{
    public class ElectronicProduct
    {
        public string Name { get; set;}
        public string Brand { get; set;}
        public string Description { get; set;}
        public float Price { get; set;}

        public ElectronicProduct (string name, string brand, string description, float price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Description = description;
            this.Price = price;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name:{Name}, Brand:{Brand}, Description: {Description}, Price:{Price}");
        }
    }
}