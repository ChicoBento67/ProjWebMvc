using PjWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PjWebMvc.Services
{
    public class SellerService
    {
        private readonly PjWebMvcContext _context;

        public SellerService(PjWebMvcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
