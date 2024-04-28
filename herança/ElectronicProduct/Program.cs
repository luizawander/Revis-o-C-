using System;

namespace Program
{
    using Smartphone;
    using Television;

    class Program 
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Modelo S", "128GB", "20MP", "Nome do Smartphone", "MarcaX", "Descrição do Smartphone", 999.99f);

            Television television = new Television("55 inches", true, "My TV", "Sony", "4K Ultra HD Smart TV", 799.99f);

            smartphone.DisplayDetails();
            television.DisplayDetails();
        
        }   
    }
}
