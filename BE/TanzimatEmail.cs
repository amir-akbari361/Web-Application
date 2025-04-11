using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BE
{
    public class TanzimatEmail
    {
        [Key]
        public int Eamil_ID { get; set; }

        [Display(Name = " ایمیل ارسال")]
        public string Eamil_EmailSend { get; set; }

        [Display(Name = "کلمه عبور")]
        public string Eamil_Password { get; set; }

        [Display(Name = "نام کاربری")]
        public string Eamil_UserName { get; set; }

        [Display(Name = "پورت")]
        public string Eamil_Port { get; set; }

        [Display(Name = "Smtp")]
        public string Eamil_Smtp { get; set; }

    }
}
