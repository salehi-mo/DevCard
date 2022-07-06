using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل کارکترهای این فیلد 3  می باشد")]
        [MaxLength(100,ErrorMessage = "حداکثر طول این فیلد 100 کاراکتر می باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل اشتباه می باشد")]
        public string Email { get; set; }
        
        public string Services { get; set; }
        public string Message { get; set; }

    }
}
