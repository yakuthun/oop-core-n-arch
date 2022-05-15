using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        //property tanımlayacağız.
        //sınıf içerisindeki tanımlama prop'tur
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
