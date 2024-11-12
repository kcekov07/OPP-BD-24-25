namespace Program.cs.models
{
    public class Person
    {
        public Person()
        {
            PersonShops = new HashSet<PersonShop>();
        }
        public int EGN { get; set; }
        public string Name { get; set; }
        public int? Age{ get; set; }
        public string Proffession { get; set; }
        public virtual HashSet<PersonShop> PersonShops { get; set; }
    }
}