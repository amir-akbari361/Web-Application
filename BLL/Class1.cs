using System;
using DAL;
using BE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bljostejos
    {
        dajostejos d = new dajostejos();
        public Hotel read(int id)
        {
            return d.read(id);
        }
        public string update(int id, Hotel knew)
        {
            return d.update(id, knew);
        }
        public string delete(int id)
        {
            return d.delete(id);
        }
        public Page GetPage(int id)
        {
            return d.GetPage(id);
        }
        //public Hotel Find(int zarfiat)
        //{
        //    dajostejos d = new dajostejos();
        //    return d.Find(zarfiat);
        //}
        public List<Hotel> jostejos(byte zarfiat, DateTime tarikhvorod, DateTime tarikhkhoroj)
        {
            return d.jostejos(zarfiat, tarikhvorod, tarikhkhoroj);
        }
        public Rezerv getrezervhotel(int id)
        {
            return d.getrezervhotel(id);
        }

    }
    public class blroom
    {
        public List<HotelRooms> read()
        {
            dlroom t = new dlroom();
            return t.read();
        }
    }

    public class blcom
    {
        public List<Nazarat> read()
        {
            dlcom t = new dlcom();
            return t.read();
        }
    }
    public class blhotel
    {
        public void create(Hotel hotel)
        {
            dlhotel d = new dlhotel();
            d.create(hotel);
        }
    }



    public class bllogin
    {
        Login_User_DAL dal = new Login_User_DAL();

        public byte Login(string username, string password)
        {
            return dal.Login(username, password);
        }

        public void Register(User_Login u)
        {
            dal.Register(u);
        }
        public List<User_Login> read()
        {
            return dal.read();
        }
        public string update(int id, User_Login knew)
        {
            return dal.update(id, knew);
        }
        public User_Login read(int id)
        {
            return dal.read(id);
        }
        //public string delete(int id)
        //{
        //    return dal.delete(id);
        //}
        public List<User_Login> searchlist(string text)
        {
            return dal.searchlist(text);
        }
        //public User_Login readadmin()
        //{
        //    return dal.readadmin();
        //}
        public string forgot(string name, string username)
        {
            return dal.forgot(name, username);
        }
    }

    public class blemail
    {
        public void create(Contant crmr)
        {
            dlemail dlh = new dlemail();
            dlh.create(crmr);
        }
    }
}
