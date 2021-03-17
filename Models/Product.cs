using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CJProje.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Ocak { get; set; }
        public int Şubat { get; set; }
        public int Mart { get; set; }
        public int Nisan { get; set; }
        public int Mayıs { get; set; }
        public int Haziran { get; set; }
        public int Temmuz { get; set; }
        public int Ağustos { get; set; }
        public int Eylül { get; set; }
        public int Ekim { get; set; }
        public int Kasım { get; set; }
        public int Aralık { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}

