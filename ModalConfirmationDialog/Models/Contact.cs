using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModalConfirmationDialog.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\S+@\S+\.\S+$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public int Color_ID { get; set; }
    }
}