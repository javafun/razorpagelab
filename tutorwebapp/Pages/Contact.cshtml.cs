using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tutorwebapp.Models;
using tutorwebapp.Services;

namespace tutorwebapp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                Message = "Your email has been sent.";
            }
        }

        public void OnPostSubscribe(string address)
        {
                EmailService.SendEmail(address);
                Message = "Your have been added to the mailing list.";
        }
    }
}
