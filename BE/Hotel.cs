using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
    public class Hotel
    {
        [Key]
        public int Hotel_ID { get; set; }

        [Display(Name = "نام هتل")]
        [Required(AllowEmptyStrings = false)]
        public string Name_Hotel { get; set; }

        [Display(Name = "آدرس ")]
        public string Adres { get; set; }

        [Display(Name = "قیمت هر شب")]
        [Required(AllowEmptyStrings = false)]
        public long Jozeyat_Gheymat { get; set; }

        [Display(Name = "تاریخ شروع دسترسی")]
        [Required(AllowEmptyStrings = false)]
        public DateTime ZamanShoroa { get; set; }

        [Display(Name = "تاریخ پایان دسترسی")]
        [Required(AllowEmptyStrings = false)]
        public DateTime ZamanPayan { get; set; }

        [Display(Name = "دسترسی فعال؟")]
        public bool Faal { get; set; }

        [Display(Name = "توضیحات")]
        [Required(AllowEmptyStrings = false)]
        public string Tozihat { get; set; }

        public string name { get; set; }
        public int bathroom { get; set; }
        public string urlpic { get; set; }
        public int tedad_takht { get; set; }
        public byte zarfiat { get; set; }
        /*-----------------------------------------------------*/
        public virtual ICollection<RezevHotel> RezevHotel { get; set; }
        public virtual ICollection<Nazarat> Nazarats { get; set; }
        public virtual ICollection<PardakhtHotel> PardakhtHotels { get; set; }




        //public virtual RezervHotel RezervHotels { get; set; }

        //[Key]
        //public int HotelId { get; set; }
        //public string Name { get; set; }

        //public virtual RezevHotel RezevHotel { get; set; }
    }
}
