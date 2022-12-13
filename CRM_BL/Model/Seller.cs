using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CRM_BL.Model
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public virtual  ICollection<Check> Checks{ get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
