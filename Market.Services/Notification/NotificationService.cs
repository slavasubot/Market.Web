using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Data.Repositories;

namespace Market.Services.Notification
{
   public class NotificationService : INotificationService
   {
       private readonly IUserRepository _userRepository;

       public NotificationService(IUserRepository userRepository)
       {
           _userRepository = userRepository;
       }
        public void SendEmail(EmailNotificationMessage message)
        {
            throw new NotImplementedException();
        }

        public void SendConfirmationEmailForNewUser(Domain.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public void SendConfirmationEmailForExistingUser(string email)
        {
            throw new NotImplementedException();
        }

        public void SendResetPasswordEmail(string email)
        {
            throw new NotImplementedException();
        }

        public EmailNotificationMessage BuildConfirmEmailForNewUserNotificationMessage(string link, string email)
        {
            throw new NotImplementedException();
        }

        public EmailNotificationMessage BuildConfirmEmailForExistingUserNotificationMessage(string link, string email)
        {
            throw new NotImplementedException();
        }

        public EmailNotificationMessage BuildResetPasswordNotificationMessage(string link, string email)
        {
            throw new NotImplementedException();
        }

        public string BuildEmailConfirmationLink(string userId, string code, bool passwordRecovery)
        {
            throw new NotImplementedException();
        }

        public string BuildPasswordResetLink(string userId, string code)
        {
            throw new NotImplementedException();
        }
    }
}
