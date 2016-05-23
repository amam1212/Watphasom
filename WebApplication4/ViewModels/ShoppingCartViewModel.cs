using WebApplication4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication4.Models.Entities;

namespace WebApplication4.ViewModel
{
    public class ShoppingCartViewModel
    {
        [Key]
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}