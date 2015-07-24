using Market.Domain.Entities;

namespace Market.Services.Services
{
    public interface IUserService
    {
        void Create(User user, string password, string confirmPassword);
        void Activate(string userId, string code);
        void Update(User user);
        void Delete(User user);
        void ChangePassword(string email, string oldPassword, string newPassword, string confirmNewPassword);
        void ResetPassword(string userId, string code, string newPassword, string confirmNewPassword);
        User FindUser(string email, string password);
        User GetByEmail(string email);

        bool CheckEmail(string email);
    }
}
