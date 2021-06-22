using PjWebMvc.Models;
using PjWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PjWebMvc.Data
{
    public class SeedingService
    {
        private PjWebMvcContext _context;

        public SeedingService(PjWebMvcContext context) 
        {
            _context = context;
        }

        public void Seed() 
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) {
                return; //DB has been seeded
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "Bob@gmail.com", new DateTime(1998, 4, 21), 1001.0, d1);
            Seller s2 = new Seller(2, "Bob yelow", "Bob2@gmail.com", new DateTime(1997, 4, 21), 1002.0, d2);
            Seller s3 = new Seller(3, "Bob Black", "Bob3@gmail.com", new DateTime(1996, 4, 21), 1003.0, d1);
            Seller s4 = new Seller(4, "Bob green", "Bob4@gmail.com", new DateTime(1995, 4, 21), 1004.0, d4);
            Seller s5 = new Seller(5, "Bob pink", "Bob5@gmail.com", new DateTime(1994, 4, 21), 1005.0, d3);
            Seller s6 = new Seller(6, "Bob Wrhite", "Bob6@gmail.com", new DateTime(1993, 4, 21), 1006.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1,d2,d3,d4);

            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6);

            _context.SalesRecord.AddRange(r1);

            _context.SaveChanges();
        }

    }
}
