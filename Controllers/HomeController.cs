using Microsoft.AspNetCore.Mvc;
using Project_01.Models;
using System.Diagnostics;

using Microsoft.Extensions.Logging;

using System;

using System.Net;
using System.Net.Mail;

namespace Project_01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // add this code for the email sender
        private readonly IEmailSender _emailSender;

        //ILogger<HomeController> logger,
        public HomeController(IEmailSender emailSender,ILogger<HomeController> logger)
        {
            _logger = logger;
            //add this code
            _emailSender = emailSender;

        }

        // add this code for the email sender
       /* [HttpPost]
        public async Task<IActionResult> Index()
        {
            var email = "decekikuul@gmail.com";
            var subject = "TEst";
            var message = "helo";

            await _emailSender.SendEmailAsync(email, subject, message);

            return View();
        }*/

        public async Task<IActionResult> Index()
        {
            var email = "decekikuul@gmail.com";
            var subject = "TEst";
            var message = "helo";

    /*        await _emailSender.SendEmailAsync(email, subject, message);*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // add 
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(SendMailDto sendMailDto)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("decekikuul@gmail.com");

                //To Email Address - your need to enter your to email address
                mail.To.Add("decekikuul@gmail.com");

                mail.Subject = sendMailDto.Subject;

                //you can specify also CC and BCC - i will skip this
                //mail.CC.Add("");
                //mail.Bcc.Add("");

                mail.IsBodyHtml = true;

                string content = "Name : " + sendMailDto.Name;
                content += "<br/> Message : " + sendMailDto.Message;

                mail.Body = content;


                //create SMTP instant

                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("decekikuul@gmail.com", "password");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587; // this is default port number - you can also change this
                smtpClient.EnableSsl = true; // if ssl required you need to enable it
                smtpClient.Send(mail);
                

                ViewBag.Message = "Mail Send";

                // now i need to create the from 
                ModelState.Clear();

            }
            catch (Exception ex)
            {
                //If any error occured it will show
                ViewBag.Message = ex.Message.ToString();
            }
            return View();
        }
    }

}
