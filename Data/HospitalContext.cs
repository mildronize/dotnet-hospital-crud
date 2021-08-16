using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
    }
}