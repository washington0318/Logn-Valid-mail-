using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class LogonViewModel
    {
        public string Account { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "需輸入4~20字串密碼")]
        public string Password { get; set; }
        [EmailAddress]
        public string Message { get; set; }
       
    }
}