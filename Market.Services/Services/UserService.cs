using Market.Data.Repositories;
using Market.Domain.Entities;


namespace Market.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User user, string password, string confirmPassword)
        {
            _userRepository.Create(user, password);
        }

        public void Activate(string userId, string code)
        {
            _userRepository.ConfirmEmail(userId, code);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public void ChangePassword(string email, string oldPassword, string newPassword, string confirmNewPassword)
        {
            _userRepository.ChangePassword(email, oldPassword, newPassword);
        }

        public void ResetPassword(string userId, string code, string newPassword, string confirmNewPassword)
        {
            _userRepository.ResetPassword(userId, code, newPassword);
        }

        public User FindUser(string email, string password)
        {
            return _userRepository.FindUser(email, password);
        }

        public User GetByEmail(string email)
        {
            return _userRepository.GetByEmail(email);
        }

        public bool CheckEmail(string email)
        {
            return _userRepository.CheckEmail(email);
        }
    }
}
