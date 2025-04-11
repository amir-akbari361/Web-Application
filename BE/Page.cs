using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Page
    {
        [Key]
        public int id { get; set; }
        public int HotelID { get; set; }
        public string NameHotel { get; set; }
        public long GheymatYekShab { get; set; }
        public string imgUrl { get; set; }
        public DateTime ZamanShoroa { get; set; }
        public DateTime ZamanPayan { get; set; }
        public bool Faal { get; set; }
        public string Tozihat { get; set; }

        public int tedad_takht { get; set; }
        public byte zarfiat { get; set; }

        public List<Nazarha> lstnazar { get; set; }

        

        public class Nazarha
        {
            public int Nazarat_ID { get; set; }
            public string Nazarat_Name { get; set; }
            public string Nazarat_Zaman { get; set; }
            public string Nazarat_Email { get; set; }
            public string Nazarat_Matn { get; set; }
            public string Nazarat_avatar { get; set; }
        }

    }
}
