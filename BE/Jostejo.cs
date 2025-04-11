using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class Jostejo
    {
        [Key]
        public int id { get; set; }
        public int HotelID { get; set; }
        public string NameHotel { get; set; }
        public long GheymatYekShab { get; set; }
        public string imgUrl { get; set; }
        public string Adres { get; set; }
        public string Tozihat { get; set; }
        public int bathroom { get; set; }
        public int tedad_takht { get; set; }

    }
}
