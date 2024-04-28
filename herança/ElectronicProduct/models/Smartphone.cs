namespace Smartphone
{
    using ElectronicProduct;
    
    public class Smartphone : ElectronicProduct
    {
        public string Scream { get; set; }
        public string Storage { get; set; }
        public string Camera { get; set; }

        public Smartphone(string scream, string storage, string camera, string name, string brand, string description, float price) 
            : base(name, brand, description, price)
        {
            this.Scream = scream;
            this.Storage = storage;
            this.Camera = camera;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Scream:{Scream}, Storage:{Storage}, Camera: {Camera}");
        }

    }

}