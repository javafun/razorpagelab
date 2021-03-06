﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tutorwebapp.Models;
using tutorwebapp.Services;
using tutorwebapp.Utils;

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

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);

                return new RedirectToPageResult("Confirmation","Contact");
            }

            return Page();
        }

        public IActionResult OnPostSubscribe(string address)
        {
            if (!RegexUtilities.IsValidEmail(address))
                throw new Exception("Email address is invalid");
            EmailService.SendEmail(address);
                return new RedirectToPageResult("Confirmation","Subscribe");
        }
    }
}
