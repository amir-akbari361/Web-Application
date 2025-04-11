using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BE
{
    public  class Sorathesabs
    {
        [Key]
        public int id { get; set; }
        public int IDHotel { get; set; }
        public long Gheymat { get; set; }
        public DateTime Tarikhvariz { get; set; }
        public string NameNameKhanevadgy { get; set; }
        public string Codepigiry { get; set; }
        public string Trakonesh { get; set; }
    }
}
