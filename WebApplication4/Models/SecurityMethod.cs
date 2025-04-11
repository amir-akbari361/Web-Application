using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class SecurityMethod
    {
        public string Encript(String data)
        {
            String ret = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(data));
            return ret;
        }
        public String Decript(String data)
        {
            String ret = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(data));
            return ret;
        }
    }
}
