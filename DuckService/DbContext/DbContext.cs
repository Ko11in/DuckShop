using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuckService.DB
{
    public static class DuckShopContext
    {
        private static ProductContext _context;

        public static ProductContext context
        {
            get
            {
                if (_context == null)
                    _context = new ProductContext("DBConnection");
                return _context;
            }
        }
    }
}