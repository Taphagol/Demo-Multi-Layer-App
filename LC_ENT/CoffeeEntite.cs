using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_ENT
{
    public class CoffeeEntite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Roast { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }


        public CoffeeEntite()
        {

        }

        public CoffeeEntite(int Id, string Name, string Type, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;
           
        }
    }





}
