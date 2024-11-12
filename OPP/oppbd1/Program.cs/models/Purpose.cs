namespace Program.cs.models
{
    public class Purpose
    {
        public Purpose()
        {
            Shops = new HashSet<Shop>();
        }
        public int Id { get; set; }
        public int Name { get; set; }
        
        public int Description { get; set; }
       
        public virtual HashSet<Shop> Shops { get; set; }
    }
}