namespace Program.cs.models
{
    public class PersonShop
    {
        public int PersonId { get; set; }
        public virtual Person Person {  get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}