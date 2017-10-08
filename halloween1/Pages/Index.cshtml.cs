using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace halloween1.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public string name { get; set; }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string subject { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Hey dummy, that's rude")]
        public string message { get; set; }
    

        public void OnGet()
        {
           
        }


        public void OnPost()
        {
            //message = "I am adding this to my message" + message
                if(string.IsNullOrEmpty(message))
            {
                Message = "Hey dummy, that is rude!!!";
            }
        }
    }
}
