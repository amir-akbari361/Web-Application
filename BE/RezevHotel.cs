using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BE
{
    public class RezevHotel
    {
        [Key]
        public int Rezerv_ID { get; set; }

        [Display(Name = "شناسه هتل")]
        public int Rezerv_IDHotel { get; set; }


        [Display(Name = "جنسیت رزرو کننده")]
        public int Rezerv_Jensiat { get; set; }


        [Display(Name = "نام ")]
        public string Rezerv_Name { get; set; }


        [Display(Name = "نام خانوادگی ")]
        public string Rezerv_NameKhanevadgi { get; set; }


        [Display(Name = "کدملی")]
        public string Rezerv_Codemeli { get; set; }


        [Display(Name = "تلفن همراه ")]
        public string Rezerv_Mobile { get; set; }


        [Display(Name = "ایمیل")]
        public string Rezerv_Email { get; set; }


        [Display(Name = "تعداد نفرات")]
        [Required(AllowEmptyStrings = false)]
        public int Rezerv_TeadadNafarat { get; set; }

        [Display(Name = "تعداد اتاق")]
        [Required(AllowEmptyStrings = false)]
        public int Rezerv_TeadadOthagh { get; set; }

        [Display(Name = "تاریخ ورود")]
        [Required(AllowEmptyStrings = false)]
        public DateTime Rezerv_Vorod { get; set; }

        [Display(Name = "تاریخ خروج")]
        [Required(AllowEmptyStrings = false)]
        public DateTime Rezerv_Khoroj { get; set; }

        [Display(Name = "مبلغ پرداختی")]
        public long Rezerv_Mablagh { get; set; }


        [Display(Name = "وضعیت")]
        public bool Rezerv_Vazeyt { get; set; }

        [Display(Name = "تعداد روز اقامت")]
        public int Rezerv_Roz { get; set; }

        [Display(Name = "شناسه IP")]
        public string Rezerv_IP { get; set; }


        public int? Hotel_ID { get; set; }


        [ForeignKey("Hotels")]
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<PardakhtHotel> PardakhtHotels { get; set; }

        //[Key]
        //public int RezevHotelId { get; set; }
        //public string Tell { get; set; }



        //public int? HotelId { get; set; }

        //[ForeignKey("Hotel")]
        //public virtual IEnumerable<Hotel> Hotels { get; set; }
    }
}
