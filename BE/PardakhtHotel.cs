using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BE
{
    public class PardakhtHotel
    {
        [Key]
        public int Pardakh_ID { get; set; }

        [Display(Name = "شناسه هتل")]
        [Required(AllowEmptyStrings = false)]
        public int Pardakh_IDHotel { get; set; }

        [Display(Name = "تاریخ پرداخت")]
        [Required(AllowEmptyStrings = false)]
        public DateTime Pardakh_ZamanVariz { get; set; }

       [Display(Name = "شماره پیگیری")]
        [Required(AllowEmptyStrings = false)]
        public string Pardakh_Pigiry { get; set; }

        [Display(Name = "مبلغ پرداخت")]
        [Required(AllowEmptyStrings = false)]
        public long Pardakh_Mablagh { get; set; }

        [Display(Name = "وضعیت پرداخت")]
        public bool Pardakh_Vazeiat { get; set; }

        [Display(Name = "شماره تراکنش")]
        public string Pardakh_Trakonesh { get; set; }

        [Display(Name = "شماره مرجع بانکی")]
        [Required(AllowEmptyStrings = false)]
        public string Pardakh_Marjaa { get; set; }

        [Display(Name = "شماره رزرو")]
        [Required(AllowEmptyStrings = false)]
        public int Pardakh_Rezerv { get; set; }


        [ForeignKey(nameof(Pardakh_Rezerv))]
        public virtual RezevHotel RezevHotel { get; set; }

        [ForeignKey(nameof(Pardakh_IDHotel))]
        public virtual Hotel HotelPardakht { get; set; }

    }
}
