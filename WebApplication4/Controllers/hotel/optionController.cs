using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BE;
using BLL;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using zp;
using DAL;
using WebApplication4.Models;
using System.IO;
using System.Net.Mail;

namespace WebApplication4.Controllers.hotel
{
    public class optionController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult room()
        {
            return View("~/Views/Home/_rooms.cshtml");
        }
        public JsonResult tsjson()
        {
            return Json(new { Redirect = "jostejos" });
        }

        [HttpPost]
        public IActionResult jostejos(byte zarfiat, DateTime tarikhvorod, DateTime ZamanPayan)
        {
            bljostejos js = new bljostejos();

            var list = js.jostejos(zarfiat, tarikhvorod, ZamanPayan);

            //return View(js);
            return View("~/Views/option/jostejos.cshtml", js);
        }

        public IActionResult test(byte zarfiat, DateTime tarikhvorod, DateTime ZamanPayan)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dtv = new DateTime(tarikhvorod.Year, tarikhvorod.Month, tarikhvorod.Day, pc);
            DateTime dtkh = new DateTime(ZamanPayan.Year, ZamanPayan.Month, ZamanPayan.Day, pc);
            db db = new db();

            //var qhotels = db.hotels.Where(a => a.ZamanShoroa <= dtv && a.ZamanPayan >= dtkh && a.Faal == true && dtkh > DateTime.Now && dtv >= DateTime.Today).ToList();
            var qhotels3 = db.hotels.Where(a => a.ZamanShoroa <= tarikhvorod && a.ZamanPayan >= ZamanPayan && a.Faal == true /*&& tarikhvorod >= DateTime.Now && tarikhvorod >= DateTime.Today*/).ToList();
            if (qhotels3 == null)
                return RedirectToAction(nameof(Index));

            List<int> lstidhotel = new List<int>();
            foreach (var o in qhotels3)
            {
                var qjozeyat = db.hotels.Where(a => a.zarfiat <= zarfiat).FirstOrDefault();
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

                        //var qhotel = db.hotels.Where(a => a.Hotel_ID.Equals(item) && a.ZamanShoroa <= dtv && a.ZamanPayan >= dtkh && a.Faal == true && dtkh > DateTime.Now && dtv >= DateTime.Today).FirstOrDefault();
                        var qimg = db.hotels.Where(a => a.Hotel_ID == lstidhotel.FirstOrDefault()).Select(q => q.urlpic);



                        t.Add(qhotel);

                    }
                }

                string khoroj = string.Format("{0}/{1}/{2}", pc.GetYear(dtkh), pc.GetMonth(dtkh), pc.GetDayOfMonth(dtkh));
                string vorod = string.Format("{0}/{1}/{2}", pc.GetYear(dtv), pc.GetMonth(dtv), pc.GetDayOfMonth(dtv));

                ViewData["khoroj"] = khoroj;
                ViewData["vorod"] = vorod;
                return View(t);

            }
            else
            {
                //return RedirectToAction(nameof(Index));
                return View("~/Views/option/test.cshtml");
            }

        }
        public IActionResult jostejos()
        {
            return View("~/Views/option/jostejos.cshtml");
        }
        public ActionResult DetailModal(int id)
        {
            bljostejos b = new bljostejos();
            var country = b.read(id);
            return PartialView(country);
        }

        public IActionResult details(int id, DateTime vorod, DateTime khoroj)
        {
            db db = new db();
            bljostejos v = new bljostejos();
            var qpage = v.GetPage(id);


            PersianCalendar pc = new PersianCalendar();
            DateTime dtv = new DateTime(vorod.Year, vorod.Month, vorod.Day, pc);
            DateTime dtkh = new DateTime(khoroj.Year, khoroj.Month, khoroj.Day, pc);

            string dtk1 = string.Format("{0}/{1}/{2}", pc.GetYear(dtkh), pc.GetMonth(dtkh), pc.GetDayOfMonth(dtkh));
            string dtv1 = string.Format("{0}/{1}/{2}", pc.GetYear(dtv), pc.GetMonth(dtv), pc.GetDayOfMonth(dtv));


            if (dtk1 == "1/1/1")
            {
                DateTime dt1 = DateTime.Today;
                DateTime dt2 = DateTime.Today.AddDays(1);
                string dtk2 = string.Format("{0}/{1}/{2}", pc.GetYear(dt2), pc.GetMonth(dt2), pc.GetDayOfMonth(dt2));
                string dtv2 = string.Format("{0}/{1}/{2}", pc.GetYear(dt1), pc.GetMonth(dt1), pc.GetDayOfMonth(dt1));

                ViewData["khoroj"] = dtk2;
                ViewData["vorod"] = dtv2;
            }
            else
            {
                ViewData["khoroj"] = dtk1;
                ViewData["vorod"] = dtv1;

            }

            ViewData["id"] = qpage.id;

            return View(qpage);
        }

        public IActionResult Sabtnazar(int idhotel, string email, string name, string matn)
        {
            db db = new db();
            if (idhotel == 0 && email == null && matn == null)
                return RedirectToAction("Details", "Home", new { id = idhotel });
            Nazarat n = new Nazarat();
            n.Nazarat_Email = email;
            n.Nazarat_HotelID = idhotel;
            n.Nazarat_Matn = matn;
            n.Nazarat_Name = name;
            n.Nazarat_Zaman = Convert.ToString(DateTime.Now);
            n.Nazarat_avatar = "01.jpg";


            db.nazarats.Add(n);
            db.SaveChanges();
            return RedirectToAction("details", "option", new { id = idhotel });

        }




        private readonly IEmailSender _emailSender;
        public optionController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Rezerv(int idhotel, string tedadtakht, byte zarfeyat, DateTime vorod, DateTime khoroj)
        {
            db db = new db();

            PersianCalendar pc = new PersianCalendar();
            DateTime dtv = new DateTime(vorod.Year, vorod.Month, vorod.Day, pc);
            DateTime dtkh = new DateTime(khoroj.Year, khoroj.Month, khoroj.Day, pc);

            var nafarat = db.hotels.Where(a => a.zarfiat == zarfeyat).Select((p) => p.zarfiat).FirstOrDefault();
            var hotel = db.hotels.Where(a => a.Hotel_ID == idhotel).FirstOrDefault();


            var roz = khoroj.Date - vorod.Date;
            int m = roz.Days;

            //if (nafarat == null  && hotel == null)
            //    return RedirectToAction("", "");

            long mablagh = hotel.Jozeyat_Gheymat * Convert.ToInt64(nafarat) * m;

            string ip = HttpContext.Connection.RemoteIpAddress.ToString();

            var qrezerv = db.rezervHotels.Where(a => a.Rezerv_IP == ip && a.Rezerv_Vazeyt == false && hotel.Hotel_ID == idhotel && a.Rezerv_TeadadOthagh == hotel.tedad_takht && a.Rezerv_TeadadNafarat == hotel.zarfiat && a.Rezerv_Vorod == vorod && a.Rezerv_Khoroj == khoroj).FirstOrDefault();
            if (qrezerv == null)
            {
                RezevHotel r = new RezevHotel();
                r.Rezerv_IDHotel = idhotel;
                r.Rezerv_Khoroj = khoroj;
                r.Rezerv_TeadadNafarat = nafarat;
                r.Rezerv_TeadadOthagh = hotel.tedad_takht;
                r.Rezerv_Vorod = vorod;
                r.Rezerv_Vazeyt = false;
                r.Rezerv_Mablagh = mablagh;
                r.Rezerv_Roz = m;
                r.Rezerv_Codemeli = null;
                r.Rezerv_Email = null;
                r.Rezerv_Jensiat = 0;
                r.Rezerv_Mobile = null;
                r.Rezerv_Name = null;
                r.Rezerv_NameKhanevadgi = null;
                r.Rezerv_IP = HttpContext.Connection.RemoteIpAddress.ToString();
                db.rezervHotels.Add(r);
                db.SaveChanges();


                TempData["ip"] = r.Rezerv_IP;
                TempData["vorod"] = vorod;
                TempData["khoroj"] = khoroj;
                TempData["nafarat"] = nafarat;
                ViewData["nafarat"] = nafarat;
                TempData["takht"] = hotel.tedad_takht;
                TempData["mab"] = mablagh;
                ViewData["mab"] = mablagh;
                return RedirectToAction("ShowRezerv", "option");
                //return View("~/Views/‌hotel/option/ShowRezerv");
            }
            else
            {
                TempData["ip"] = HttpContext.Connection.RemoteIpAddress.ToString();
                TempData["nafarat"] = nafarat;
                TempData["takht"] = hotel.tedad_takht;
                return RedirectToAction("ShowRezerv", "option");
            }
        }
        public IActionResult ShowRezerv(int idhotel, /*string tedadtakht,*/ byte zarfeyat, DateTime vorod, DateTime khoroj)
        {

            db db = new db();
            var nafarat = db.hotels.Where(a => a.zarfiat == zarfeyat).Select((p) => p.zarfiat).FirstOrDefault();
            var hotel = db.hotels.Where(a => a.Hotel_ID == idhotel).FirstOrDefault();


            var roz = khoroj.Date - vorod.Date;
            int m = roz.Days;
            long mablagh = hotel.Jozeyat_Gheymat * /*nafarat*/ zarfeyat * m;

            //if (nafarat == null  && hotel == null)
            //    return RedirectToAction("","");
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();

            var qrezerv = db.rezervHotels.Where(a => a.Rezerv_IP == ip && a.Rezerv_Vazeyt == false && hotel.Hotel_ID == idhotel && a.Rezerv_TeadadOthagh == hotel.tedad_takht && a.Rezerv_TeadadNafarat == hotel.zarfiat && a.Rezerv_Vorod == vorod && a.Rezerv_Khoroj == khoroj).FirstOrDefault();
            if (qrezerv == null)
            {
                RezevHotel r = new RezevHotel();
                r.Rezerv_IDHotel = idhotel;
                r.Rezerv_Khoroj = khoroj;
                r.Rezerv_TeadadNafarat = nafarat;
                r.Rezerv_TeadadOthagh = hotel.tedad_takht;
                r.Rezerv_Vorod = vorod;
                r.Rezerv_Vazeyt = false;
                r.Rezerv_Mablagh = mablagh;
                r.Rezerv_Roz = m;
                r.Rezerv_Codemeli = null;
                r.Rezerv_Email = null;
                r.Rezerv_Jensiat = 0;
                r.Rezerv_Mobile = null;
                r.Rezerv_Name = null;
                r.Rezerv_NameKhanevadgi = null;
                r.Rezerv_IP = HttpContext.Connection.RemoteIpAddress.ToString();
                db.rezervHotels.Add(r);
                db.SaveChanges();

                //TempData["ip"] = r.Rezerv_IP;
                //TempData["vorod"] = vorod;
                //TempData["khoroj"] = khoroj;
                //TempData["nafarat"] = nafarat;
                //TempData["takht"] = hotel.tedad_takht;
                //TempData["mab"] = mablagh;
                ViewData["idrez"] = r.Rezerv_ID;
                ViewData["ip"] = TempData["ip"];
                ViewData["vorod"] = vorod;
                ViewData["khoroj"] = khoroj;
                ViewData["nafarat"] = nafarat;
                ViewData["takht"] = hotel.tedad_takht;
                ViewData["mab"] = mablagh;
                ViewData["id"] = idhotel;
                ViewData["roz"] = m;
            }
            else
            {
                ViewData["idrez"] = qrezerv.Rezerv_ID;
                ViewData["ip"] = TempData["ip"];
                ViewData["vorod"] = vorod;
                ViewData["khoroj"] = khoroj;
                ViewData["nafarat"] = zarfeyat;
                ViewData["roz"] = m;
                ViewData["mab"] = mablagh;
                ViewData["id"] = idhotel;

            }


            return View();
        }
        public async Task<IActionResult> Pardakht(int jensyat, string name, string namekhanvadegy, string codemeli, string email, string mobile, int idrezerv, int idhotel)
        {
            db db = new db();
            var qrezerv = db.rezervHotels.Where(a => a.Rezerv_ID == idrezerv && a.Rezerv_IDHotel == idhotel && a.Rezerv_Vazeyt == false).FirstOrDefault();

            if (qrezerv == null)
                return RedirectToAction("");
            else
            {

                ServicePointManager.Expect100Continue = false;
                PaymentGatewayImplementationServicePortTypeClient zp = new PaymentGatewayImplementationServicePortTypeClient();

                String MerchantID = "a01e03e4-00a2-11e7-93c3-005056a205be";
                String CallbackURL = "https://localhost:44319/option/KharidNahaei";
                int mablagh = Convert.ToInt32(qrezerv.Rezerv_Mablagh);
                String Description = " پرداخت تست";

                var x = await zp.PaymentRequestAsync(MerchantID, mablagh, Description, "", "", CallbackURL);
                if (x.Body.Status == 100)
                {
                    Random rnd = new Random();
                    string pigiry = rnd.Next(0000, 999999).ToString() + DateTime.Now.Millisecond;
                    PardakhtHotel p = new PardakhtHotel();
                    p.Pardakh_IDHotel = qrezerv.Rezerv_IDHotel;
                    p.Pardakh_Mablagh = qrezerv.Rezerv_Mablagh;
                    p.Pardakh_Marjaa = x.Body.Authority;
                    p.Pardakh_Pigiry = pigiry;
                    p.Pardakh_Rezerv = idrezerv;
                    p.Pardakh_Vazeiat = false;
                    p.Pardakh_ZamanVariz = DateTime.Now;
                    db.pardakhtHotels.Add(p);
                    db.SaveChanges();

                    qrezerv.Rezerv_Codemeli = codemeli;
                    qrezerv.Rezerv_Email = email;
                    qrezerv.Rezerv_Jensiat = jensyat;
                    qrezerv.Rezerv_Mobile = mobile;
                    qrezerv.Rezerv_Name = name;
                    qrezerv.Rezerv_NameKhanevadgi = namekhanvadegy;
                    db.Update(qrezerv);
                    db.SaveChanges();
                    return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + x.Body.Authority);
                }
                else
                {
                    return RedirectToAction("");
                }


            }

        }


        public async Task<IActionResult> KharidNahaei(string Status, string Authority)
        {
            db db = new db();
            if (Status == null && Authority == null)
                return RedirectToAction("Error", "Home");
            //try
            //{
            if (Status == "OK")
            {
                var qkhrid = db.pardakhtHotels.Where(a => a.Pardakh_Marjaa == Authority && a.Pardakh_Vazeiat == false).SingleOrDefault();

                if (qkhrid == null)
                    return RedirectToAction("Error", "Home");


                ServicePointManager.Expect100Continue = false;
                PaymentGatewayImplementationServicePortTypeClient zp = new PaymentGatewayImplementationServicePortTypeClient();
                String MerchantID = "a01e03e4-00a2-11e7-93c3-005056a205be";
                string Authoritys = Authority;
                int Amount = Convert.ToInt32(qkhrid.Pardakh_Mablagh);
                var x = await zp.PaymentVerificationAsync(MerchantID, Authoritys, Amount);
                if (x.Body.Status == 100)
                {
                    qkhrid.Pardakh_Trakonesh = Convert.ToString(x.Body.RefID);
                    qkhrid.Pardakh_Vazeiat = true;
                    db.Update(qkhrid);
                    db.SaveChanges();

                    var q = db.rezervHotels.Where(a => a.Rezerv_ID == qkhrid.Pardakh_Rezerv && a.Rezerv_Vazeyt == false).FirstOrDefault();

                    q.Rezerv_Vazeyt = true;
                    db.rezervHotels.Update(q);
                    db.SaveChanges();

                    PersianCalendar pc = new PersianCalendar();
                    string zaman = string.Format("{0}/{1}/{2}", pc.GetYear(qkhrid.Pardakh_ZamanVariz), pc.GetMonth(qkhrid.Pardakh_ZamanVariz), pc.GetDayOfMonth(qkhrid.Pardakh_ZamanVariz));
                    //try
                    //{
                    string matn = "رزرو شما با موفقیت انجام شد. شماره پیگیری" + qkhrid.Pardakh_Pigiry + ". تاریخ رزرو " + zaman + "";
                    await _emailSender.SendEmailAsync(q.Rezerv_Email, "رزرو با موفقیت انجام شد", matn);

                    //}
                    //catch
                    //{

                    //}


                    return RedirectToAction(nameof(Sorathesab), new { id = qkhrid.Pardakh_ID });

                }


            }
            //}
            //catch
            //{

            //}

            return View();
        }


        public IActionResult Sorathesab(int id)
        {
            db db = new db();
            if (id > 0)
            {
                var qkharid = db.pardakhtHotels.Where(a => a.Pardakh_ID == id && a.Pardakh_Vazeiat == true).FirstOrDefault();
                var q = db.rezervHotels.Where(a => a.Rezerv_ID == qkharid.Pardakh_Rezerv).FirstOrDefault();


                Sorathesabs s = new BE.Sorathesabs();
                s.Codepigiry = qkharid.Pardakh_Pigiry;
                s.Gheymat = qkharid.Pardakh_Mablagh;
                s.IDHotel = q.Rezerv_IDHotel;
                s.NameNameKhanevadgy = q.Rezerv_Name + " " + q.Rezerv_NameKhanevadgi;
                s.Tarikhvariz = qkharid.Pardakh_ZamanVariz;
                s.Trakonesh = qkharid.Pardakh_Trakonesh;

                return View(s);

            }
            else
            {
                return View(null);
            }

        }
        public async Task<IActionResult> SendEmail(string email)
        {
            string matn = "ایمیل شما با موفقیت ثبت شد";
            await _emailSender.SendEmailAsync(email, "خوش آمدید", matn);
            return View();
        }
        public async Task<IActionResult> SendContant(string name, string matn, string email)
        {
            db db = new db();
            blemail ble = new blemail();

            Contant c = new Contant();
            c.name = name;
            c.email = email;
            c.matn = matn;


            ble.create(c);
            string matnn = "ممنون از شما";
            await _emailSender.SendEmailAsync(email, "اطلاعات شما با موفقیت ثبت شد", matnn);
            return View("~/Views/option/SendEmail.cshtml");
        }

        public IActionResult thanks()
        {
            return View();
        }

        public IActionResult sign_in()
        {
            return View();
        }
        public IActionResult _sign_in(string UserName, string Password)
        {
            string h;
            SecurityMethod s = new SecurityMethod();
            h = s.Encript(Password);
            bllogin login = new bllogin();
            if (login.Login(UserName, h) == 1)
            {
                return View("~/Views/option/thanks.cshtml");
            }
            else
            {
                return View("~/Views/option/sign_in.cshtml");
            }
        }




        public IActionResult sign_up()
        {
            return View();
        }

        public IActionResult _sign_up(string Name, string UserName, string Password)
        {
            string h;
            SecurityMethod s = new SecurityMethod();
            h = s.Encript(Password);

            bllogin login = new bllogin();
            login.Register(new User_Login() { Name = Name, UserName = UserName, Password = h });
            return View("~/Views/option/thanks.cshtml");
        }


        public IActionResult blog_detail()
        {
            return View();
        }

    }
}
