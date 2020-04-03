using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FuelQuoteApp.Models.Client
{
    public class ClientProfileViewModel
    {
        [Required(ErrorMessage = "Full name is required!")]
        [MaxLength(50,ErrorMessage ="Maximum characters allowed is 50!!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Address 1 is required!")]
        [MaxLength(100, ErrorMessage = "Maximum characters allowed is 100!!")]
        public string Address1 { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum characters allowed is 100!!")]
        public string Address2 { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum characters allowed is 100!!")]
        [Required(ErrorMessage = "City is required!")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required!")]
        public States? State { get; set; }

        [Required(ErrorMessage = "ZipCode is required!")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
    }
}
