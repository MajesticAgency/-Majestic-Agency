using Core.Entities.ViewModel;
using Core.Interface;
using MimeKit;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EmailRepository : IEmail
    {
        public void SendCareerEmailForClient(ViewModels viewModel, string subject , string body)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential networkCredential = new NetworkCredential("ma.majesticagency@gmail.com", "lqhivbrqdjocaevv");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;

                using (MailMessage mm = new MailMessage("ma.majesticagency@gmail.com", viewModel.Career.EmailAddress))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.IsBodyHtml = false;
                    smtp.Send(mm);
                   
                }
                smtp.Dispose();
            }
        }
        public void SendOrderEmailForClient(ViewModels viewModel, string subject, string body)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential networkCredential = new NetworkCredential("ma.majesticagency@gmail.com", "lqhivbrqdjocaevv");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;

                using (MailMessage mm = new MailMessage("ma.majesticagency@gmail.com", viewModel.Order.Email))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.IsBodyHtml = false;
                    smtp.Send(mm);
                }
                smtp.Dispose();
            }
        }
        public void SendCareerEmailForCompany(ViewModels viewModel, string subject, string body)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential networkCredential = new NetworkCredential("ma.majesticagency@gmail.com", "lqhivbrqdjocaevv");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;

                using (MailMessage mm = new MailMessage("ma.majesticagency@gmail.com", "ma.majesticagency@gmail.com"))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    if (viewModel.Career.CV.Length > 0)
                    {
                        string fileName = Path.GetFileName(viewModel.Career.CV.FileName);
                        mm.Attachments.Add(new Attachment(viewModel.Career.CV.OpenReadStream(), fileName));
                    }
                    mm.IsBodyHtml = false;
                    smtp.Send(mm);

                }
                smtp.Dispose();
            }
        }
        public void SendOrderEmailForCompany(ViewModels viewModel, string subject, string body)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential networkCredential = new NetworkCredential("ma.majesticagency@gmail.com", "lqhivbrqdjocaevv");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;

                using (MailMessage mm = new MailMessage("ma.majesticagency@gmail.com", "ma.majesticagency@gmail.com"))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    if (viewModel.Order.FileUrl.Length > 0)
                    {
                        string fileName = Path.GetFileName(viewModel.Order.FileUrl.FileName);
                        mm.Attachments.Add(new Attachment(viewModel.Order.FileUrl.OpenReadStream(), fileName));
                    }
                    mm.IsBodyHtml = false;
                    smtp.Send(mm);

                }
                smtp.Dispose();
            }
        }
    }
}
