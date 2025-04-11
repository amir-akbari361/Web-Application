using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BE;
using System.Configuration;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace DAL
{
    public class dajostejos
    {

        db db = new db();
        public List<Hotel> jostejos(byte zarfiat, DateTime tarikhvorod, DateTime tarikhkhoroj)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dtv = new DateTime(tarikhvorod.Year, tarikhvorod.Month, tarikhvorod.Day, pc);
            DateTime dtkh = new DateTime(tarikhkhoroj.Year, tarikhkhoroj.Month, tarikhkhoroj.Day, pc);
            var qhotels2 = db.hotels.Where(s => s.zarfiat == zarfiat).ToList();
      
            List<int> lstidhotel = new List<int>();
            foreach (var o in qhotels2)
            {
                var qjozeyat = db.hotels.Where(a => a.zarfiat == zarfiat).FirstOrDefault();
                if (qjozeyat != null)
                    lstidhotel.Add(o.Hotel_ID);
                else
                    lstidhotel.Add(0);

            }

            if (lstidhotel.Count() > 0)
            {
                List<Hotel> t = new List<Hotel>();
                List<Jostejo> lstjostejo = new List<Jostejo>();
                foreach (var item in lstidhotel)
                {
                    if (item > 0)
                    {
                        var qhotel = db.hotels.Where(a => a.Hotel_ID.Equals(item) && a.Faal == true).FirstOrDefault();

                        var qimg = db.hotels.Where(a => a.Hotel_ID == lstidhotel.FirstOrDefault()).Select(q => q.urlpic);



                        t.Add(qhotel);

                
                    }
                }

                string khroj = string.Format("{0}/{1}/{2}", pc.GetYear(dtkh), pc.GetMonth(dtkh), pc.GetDayOfMonth(dtkh));
                string vorod = string.Format("{0}/{1}/{2}", pc.GetYear(dtv), pc.GetMonth(dtv), pc.GetDayOfMonth(dtv));

                return t;
            }
            else
            {
                return null;
            }

        }

        public Hotel read(int id)
        {
            return db.hotels.Where(i => i.Hotel_ID == id).Single();
        }

        public string update(int id, Hotel knew)
        {
            Hotel h = new Hotel();
            h = read(id);
            h.Adres = knew.Adres;
            h.bathroom = knew.bathroom;
            h.Faal = knew.Faal;
            h.Jozeyat_Gheymat = knew.Jozeyat_Gheymat;
            h.name = knew.name;
            h.Name_Hotel = knew.Name_Hotel;
            h.tedad_takht = knew.tedad_takht;
            h.Tozihat = knew.Tozihat;
            h.urlpic = knew.urlpic;
            h.ZamanShoroa = knew.ZamanShoroa;
            h.ZamanPayan = knew.ZamanPayan;
            h.zarfiat = knew.zarfiat;

            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        public string delete(int id)
        {
            Hotel h = new Hotel();
            h = (from i in db.hotels where i.Hotel_ID == id select i).Single();
            db.hotels.Remove(h);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }

        public Page GetPage(int id)
        {
            var get = (from a in db.hotels where a.Hotel_ID == id && a.Faal == true select a).SingleOrDefault();

            if (get == null)
                return null;


            var qnazar = db.nazarats.Where(a => a.Nazarat_HotelID.Equals(id)).ToList();
            List<Page.Nazarha> lstnazarha = new List<Page.Nazarha>();
            foreach (var item in qnazar)
            {
                Page.Nazarha n = new Page.Nazarha();
                n.Nazarat_Email = item.Nazarat_Email;
                n.Nazarat_ID = item.Nazarat_ID;
                n.Nazarat_Name = item.Nazarat_Name;
                n.Nazarat_Zaman = item.Nazarat_Zaman;
                n.Nazarat_Matn = item.Nazarat_Matn;
                n.Nazarat_avatar = item.Nazarat_avatar;
                lstnazarha.Add(n);
            }



            Page p = new Page();
            p.Faal = get.Faal;
            p.GheymatYekShab = get.Jozeyat_Gheymat;
            p.HotelID = get.Hotel_ID;
            p.NameHotel = get.Name_Hotel;
            p.ZamanPayan = get.ZamanPayan;
            p.ZamanShoroa = get.ZamanShoroa;
            p.Tozihat = get.Tozihat;
            p.lstnazar = lstnazarha;
            p.imgUrl = get.urlpic;
            p.tedad_takht = get.tedad_takht;
            p.zarfiat = get.zarfiat;

            return p ?? null;

        }
        public Rezerv getrezervhotel(int id)
        {
            var q = db.hotels.Where(a => a.Hotel_ID == id && a.Faal == true).FirstOrDefault();

            Rezerv r = new Rezerv();
            r.IDHotel = q.Hotel_ID;
            r.NameHotel = q.Name_Hotel;
            r.Tasvir = q.urlpic;
            r.Adres = q.Adres;
            r.Gheymat = q.Jozeyat_Gheymat;

            return r;
        }

    }
    public class dlroom
    {
        db db = new db();
        public List<HotelRooms> read()
        {
            return db.HotelRooms.ToList();
        }
    }
    public class dlcom
    {
        db db = new db();
        public List<Nazarat> read()
        {
            return db.nazarats.Take(6).ToList();
        }
    }
    public class dlhotel
    {
        db db = new db();
        public void create(Hotel t)
        {
            db.hotels.Add(t);
            db.SaveChanges();
        }
    }



    public class Login_User_DAL
    {
        db db = new db();
        public byte Login(string username, string password)
        {
            if (db.user_Logins.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.user_Logins.Any(i => i.UserName == username && i.Password == password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        public void Register(User_Login u)
        {
            db.user_Logins.Add(u);
            db.SaveChanges();
        }
        public List<User_Login> searchlist(string text)
        {
            return (db.user_Logins.Where(i => i.Name.Contains(text) || i.UserName.Contains(text)).ToList());
        }
        public List<User_Login> read()
        {
            return db.user_Logins.Take(25).ToList();
        }
        public User_Login read(int id)
        {
            return db.user_Logins.Where(i => i.id == id).Single();
        }
        public string update(int id, User_Login knew)
        {
            User_Login h = new User_Login();
            h = read(id);
            h.Name = knew.Name;
            h.Password = knew.Password;
            h.UserName = knew.UserName;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        public string forgot(string name, string username)
        {
            return db.user_Logins.Where(i => i.Name == name && i.UserName == username).Single().Password;
        }
    }

    public class dlemail
    {
        public void create(Contant crmr)
        {
            db db = new db();
            db.contants.Add(crmr);
            db.SaveChanges();
        }
    }
}