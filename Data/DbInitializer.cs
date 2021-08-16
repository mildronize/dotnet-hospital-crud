using Hospital.Models;
using System;
using System.Linq;

namespace Hospital.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HospitalContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Member.
            if (context.Member.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Member[]
            {
                new Member{Name="Carson Alexander",HospitalNumber="003214",PhoneNumber="0876483746", Email="carson.a@gmail.com"},
                new Member{Name="Meredith Alonso",HospitalNumber="003354",PhoneNumber="0897463845", Email="meredith.a@gmail.com"},
            };
           
            context.SaveChanges();
        }
    }
}

