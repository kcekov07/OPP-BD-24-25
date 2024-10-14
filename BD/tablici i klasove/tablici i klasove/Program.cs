namespace tablici_i_klasove
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Car
        {
            public int CarManufacturerId { get; set; } 

            public virtual CarManufacturer CarManufactuer { get; set; }
            public int Id { get; set; } 
            public int Model { get; set; } 
            public int Description { get; set; } 
            public int Price { get; set; } 
            public int HorsePower { get; set; } 
            public int EngineType { get; set; } 
        }

        public class CarManufacturer
        {
            public virtual List<Car> Cars { get; set; }
            public int Id { get; set; }
            public int Name { get; set; }
            public int Email{ get; set; }
            public int Adress { get; set; }

        }


    }
}
