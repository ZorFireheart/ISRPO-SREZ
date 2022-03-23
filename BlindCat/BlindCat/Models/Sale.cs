using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindCat.Models
{
    public class Sale
    {
        public DateTime DateSale { get; set; }
        public Client Client { get; set; }
        public List<Telephone> Telephones { get; set; }

    }
}
