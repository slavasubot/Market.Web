﻿using System;
using System.Collections.Generic;
using System.Linq;
using Market.Data.Contexts;
using Market.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Market.Data.Repositories
{
   public class UserRepository : IUserRepository, IDisposable
   {
       private readonly AuthContext _authContext;
       private readonly UserManager<User> _userManager;

       public UserRepository()
       {
           _authContext = new AuthContext();
           _userManager = new UserManager<User>(new UserStore<User>(_authContext));



       }


        public List<string> Create(User user, string password)
        {
            var result = _userManager.Create(user, password);
            if (result.Errors.Any())
            {
                return result.Errors.ToList();
            }
            return null;
        }

        public void Update(User user)
        {
            _userManager.Update(user);
        }

        public void Delete(User user)
        {
            _userManager.Delete(user);
        }

        public List<string> ConfirmEmail(string userId, string code)
        {
            var result = _userManager.ConfirmEmail(userId, code);
            if (result.Errors.Any())
            {
                return result.Errors.ToList();
            }
            return null;
        }

        public List<string> ChangePassword(string email, string oldPassword, string newPassword)
        {
            var result = _userManager.ChangePassword(_userManager.FindByEmail(email).Id, oldPassword, newPassword);
            if (result.Errors.Any())
            {
                return result.Errors.ToList();
            }
            return null;
        }

        public List<string> ResetPassword(string userId, string code, string newPassword)
        {
            var result = _userManager.ResetPassword(userId, code, newPassword);
            if (result.Errors.Any())
            {
                return result.Errors.ToList();
            }
            return null;
        }

        public bool CheckEmail(string email)
        {
            var identityUser = _userManager.FindByEmail(email);
            return identityUser.EmailConfirmed;
        }

        public User FindUser(string email, string password)
        {
            var identityUser = _userManager.Find(email, password);
            return identityUser;
        }

        public User FindById(string userId)
        {
            var identityUser = _userManager.FindById(userId);
            if (identityUser != null)
            {
                return identityUser;
            }
            return null;
        }

        public User GetByEmail(string email)
        {
            var identityUser = _userManager.FindByEmail(email);
            if (identityUser != null)
            {
                return identityUser;
            }
            return null;
        }

        public string GetId(string email)
        {
            var identityUser = _userManager.FindByEmail(email);
            if (identityUser != null)
            {
                return identityUser.Id;
            }
            return null;
        }

        public string GenerateEmailToken(string userId)
        {
            var identityUser = _userManager.FindById(userId);
            if (identityUser != null)
            {
                return _userManager.GenerateEmailConfirmationToken(userId);
            }

            return null;
        }

        public string GeneratePwdToken(string userId)
        {
            var identityUser = _userManager.FindById(userId);
            if (identityUser != null)
            {
                return _userManager.GeneratePasswordResetToken(userId);
            }

            return null;
        }

        public void Dispose()
        {
            _authContext.Dispose();
            _userManager.Dispose();
        }
   }
}
