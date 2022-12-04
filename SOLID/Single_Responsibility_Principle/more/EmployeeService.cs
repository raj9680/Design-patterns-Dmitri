using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Collections.Generic;
using System.Threading.Tasks;


/*

Requirement 1: Bob (Tech Lead) explains requirements to Mark (a .Net developer). One of the primary
requirement was to build a module which will have employee registration functionality. 

Requirement 2: 
    1. We need to store employee email address with existing fields. 
    2. When an employee registers then he/she gets an email. 


Problem with Preceding Design

There are two requirements. Both requirements have changed, those are totally different. One is changing the data; whereas another one
is impacting the functionality. Hence, we have two different types of reason to change a single class. So, it violates the SRP
Principle.

*/

namespace Single_Responsibility_Principle.more
{

    public class Employee  // Separate Class for Managing Employee Entiies
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }


    class StaticData // Separate Class for Employee Data Storage
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }


    public class EmployeeService  // Separate Class For Employee Functionality
    {
        public async Task EmployeeRegistration(Employee employee)
        {
            StaticData.Employees.Add(employee); // Processing add employee data

            EmailService emailService = new EmailService();  // Processing email sending feature
            await emailService.SendEmailAsync(employee.Email, "Registration", "Congratulation ! Your are successfully registered.");
        }
    }


    public class EmailService  // Separate Class for Email Sending Service
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Mark Adam", "madam@sample.com"));
            emailMessage.To.Add(new MailboxAddress(string.Empty, email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.LocalDomain = "paathshaala.com";
                await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
        }
    }
}
