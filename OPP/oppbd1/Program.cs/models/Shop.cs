using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.models
{
    public class Shop
    {
        public Shop()
        {
            ShopPeople = new HashSet<PersonShop>();
        }
        public int Id { get; set; }
        public int Name { get; set; }
        public int StartHour{ get; set; }
        public int  EndHour{ get; set; }
        public virtual HashSet<PersonShop>  ShopPeople { get; set; }

        public int AddressId { get; set; }
        public virtual Address  Address { get; set; }

        public int PurposeId { get; set; }
        public virtual Purpose Purpose { get; set; }




    }
}
