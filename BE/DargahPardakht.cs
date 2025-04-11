using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE
{
   public class DargahPardakht
    {
        [Key]
        public int DargahPardakht_ID { get; set; }

        [Display(Name = "نام بانک")]
        public string DargahPardakht_NameBank { get; set; }

        [Display(Name = "کد فعالسازی درگاه")]
        public string DargahPardakht_Code { get; set; }
    }
}
