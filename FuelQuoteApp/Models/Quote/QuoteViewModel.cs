using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FuelQuoteApp.Models.Quote
{
    public class QuoteViewModel
    {
        [Required(ErrorMessage = "Please enter the required quantity of fuel!")]
        public int GallonsRequested { get; set; }

        [ReadOnly(true)]
        public string DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Please enter the date!")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        [ReadOnly(true)]
        public float PricePerGallon { get; set; }

        [ReadOnly(true)]
        public float TotalAmount { get; set; }
    }
}
