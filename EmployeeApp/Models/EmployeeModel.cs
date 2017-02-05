using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApp.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Gullname
        {
            get
            {
                return string.Format("{0} {1}",FirstName, LastName);
            }
        }
        [Required]
        [MaxLength(100,ErrorMessage ="First Name should not exceed more than 100 characters")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Last Name should not exceed more than 100 characters")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30, ErrorMessage = "Email address should be in this format xyz@ab.zx")]
        public string EmailAddress { get; set; }
        [MaxLength(200, ErrorMessage ="Comments should not exceen 200 characters")]
        public string Comments { get; set; }
    }
}