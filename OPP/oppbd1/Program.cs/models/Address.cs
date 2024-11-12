namespace Program.cs.models
{
    public class Address
    {
        public Address()
        {
            Shops = new HashSet<Shop>();
        }
        public int Id { get; set; }
        public int TownName { get; set; }
        public int StreetName { get; set; }
        public int Description { get; set; }
        public int StreetNumber { get; set; }
        public virtual HashSet<Shop> Shops { get; set; }

        
    }
}