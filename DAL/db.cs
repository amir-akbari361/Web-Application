using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using BE;

namespace DAL
{
    public class db : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AMIR\SQL2019;Initial Catalog=test;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Hotel> hotels { get; set; }
        public DbSet<RezevHotel> rezervHotels { get; set; }
        public DbSet<HotelRooms> HotelRooms { get; set; }
        public DbSet<DargahPardakht> dargahPardakhts { get; set; }
        public DbSet<Nazarat> nazarats { get; set; }
        public DbSet<PardakhtHotel> pardakhtHotels { get; set; }
        public DbSet<TanzimatEmail> tanzimatEmails { get; set; }
        public DbSet<Jostejo> Jostejo { get; set; }
        public DbSet<User_Login> user_Logins { get; set; }
        public DbSet<Contant> contants { get; set; }
    }
}
