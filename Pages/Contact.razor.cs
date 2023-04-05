
using System.Net.Mail;

namespace MyPortfolio.Pages
{
    public partial class Contact
    {
		public String FirstName { get; set; } = "";

		public String LastName { get; set; } = "";

		public String EmailAddr { get; set; } = "";

		public String Subject { get; set; } = "";

		public String Message { get; set; } = "";

		public void SendEmail()
		{
			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress("chase.sparksad@gmail.com");
				mail.To.Add("chaspa97.cs@gmail.com");
				mail.Subject = $"Website contact form: {Subject}";
				mail.Body = $"Email from website user {FirstName} {LastName}. <br /><br />Respond to {EmailAddr}, not this email. <br /><br />Message as follows: {Message}";
				mail.IsBodyHtml = true;
				
			}

			FirstName = "";
			LastName = "";
			Subject = "";
			EmailAddr = "";
			Message = "";
		}
	}
}
