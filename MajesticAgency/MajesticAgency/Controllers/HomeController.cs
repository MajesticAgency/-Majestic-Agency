using Core.Entities;
using Core.Entities.ViewModel;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;
using System.Net.Mail;
using System.Net;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace MajesticAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        private readonly ISubService _subService;
        private readonly IOrder _order;
        private readonly IEmail _email;

        private readonly IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IService service, ISubService subService, IOrder order , IConfiguration configuration, IEmail email)
        {
            _logger = logger;
            _service = service;
            _subService = subService;
            _order = order;
            _configuration = configuration;
            _email = email;
        }

        public async Task<IActionResult> Index()
        {
            ViewModels viewModels = new ViewModels();
            viewModels.Services = await _service.GetServices();
            return View(viewModels);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ViewModels model)
        {
            model.Services = await _service.GetServices();

            var sub = "TestSubject";
            var body = "Test";
            _email.SendOrderEmailForClient(model, sub, body);

            var subCompany = "TestSubject Company";
            var bodyCompany = "Test Company";
            _email.SendOrderEmailForCompany(model, subCompany, bodyCompany);
            return View(model);
        }

        public async Task<IActionResult> ServiceDetails(int id)
        {
            var service = await _service.GetService(id);
            return View(service);
        }
        public async Task<IActionResult> Career()
        {
            ViewModels viewModels = new ViewModels();
            viewModels.Services = await _service.GetServices();
            return View(viewModels);
        }
        [HttpPost]
        public IActionResult Career(ViewModels models)        
        {
            var sub = "Majestic Agency Job Application";
            var body = $"Dear {models.Career.FullName},\r\n\r\n\r\nThe \"Majestic Agency\" has received your Form & CV has been successfully submitted, \r\nWe are currently reviewing many applicants will contact you if you have been selected for an interview.\r\n\r\n\r\nIn the mean time we wish you good luck in your quest for a new job.\r\n\r\nKeep this email for your own personal records.\r\n\r\n\r\nWishing you all the best,\r\nThe Majestic Agency Team";
            _email.SendCareerEmailForClient(models, sub, body);



            var subCompany = "Majestic Agency Job Application";
            var bodyCompany = "To whom it may concern,\r\n\r\n\r\nThe \"Majestic Agency\" has received a Form & CV has been successfully submitted, Please review, Keep this email for own career records and inform the relevant department." +
                $"\r\n\r\nName: {models.Career.FullName}\r\n" +
                $"Age: {models.Career.Age}\r\n" +
                $"Marital Status: {models.Career.MaritalStatus}\r\n" +
                $"Email Address: {models.Career.EmailAddress}\r\n" +
                $"Phone Number: {models.Career.PhoneNumber}\r\n" +
                $"Current Residence: {models.Career.CurrentResidence}\r\n" +
                $"Working Field: {models.Career.WorkingField}\r\n" +
                $"Number of years of experience working in your field: {models.Career.NumOfExperience}\r\n" +
                $"Current Work: {models.Career.CurrentWork}\r\n" +
                $"Do you have a desire to learn?: {models.Career.Q1}\r\n" +
                $"Do you have the ability to generate creative ideas to deliver them to your target customers?: {models.Career.Q2}\r\n" +
                $"According to previous experiences, what is your ability to deliver the required job on time: {models.Career.Q3}\r\n" +
                $"In the company, we use a set of programs that help us increase employee productivity, such as project management and time monitoring programs. \r\nWriting plans for future steps and writing reports on the tasks performed is an important part of the responsibilities. Are you ready to abide by them? : {models.Career.Q4}\r\n" +
                $"Expected salary to work: {models.Career.ExpectedSalary}\r\n" +
                $"Features that make you better than others to get this job?: {models.Career.Features}\r\n" +
                $"Behance link: {models.Career.BehanceLink}\r\n" +
                $"Other notes: {models.Career.Note}\r\n" +



                $"\r\n\r\nWishing you all the best,";
            _email.SendCareerEmailForCompany(models, subCompany, bodyCompany);

            return RedirectToAction("Index", "Home");
        }
    }
}
