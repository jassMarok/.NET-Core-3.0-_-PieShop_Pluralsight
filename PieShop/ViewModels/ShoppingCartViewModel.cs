using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public Decimal ShoppingCartTotal { get; set; }
    }
}
