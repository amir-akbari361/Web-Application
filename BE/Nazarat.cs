using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BE
{
   public class Nazarat
    {
        [Key]
        public int Nazarat_ID { get; set; }

        [Display(Name = "فرستنده")]
        [Required(AllowEmptyStrings = false)]
        public string Nazarat_Name { get; set; }

        [Display(Name = "متن نظر")]
        [Required(AllowEmptyStrings = false)]
        public string Nazarat_Matn { get; set; }

        [Display(Name = "تاریخ ثبت")]
        [Required(AllowEmptyStrings = false)]
        public string Nazarat_Zaman { get; set; }

        [Display(Name = "شناسه هتل")]
        [Required(AllowEmptyStrings = false)]
        public int Nazarat_HotelID { get; set; }

        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings = false)]
        public string Nazarat_Email { get; set; }

        [Display(Name = "آواتار")]
        [Required(AllowEmptyStrings = false)]
        public string Nazarat_avatar { get; set; }

        [ForeignKey(nameof(Nazarat_HotelID))]
        public virtual Hotel HotelNazar { get; set; }

    }
}
