using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using JwtAuthDemo.Controllers;
using JwtAuthDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace JwtAuthDemo.Services
{
    public interface IUserService
    {
        bool IsAnExistingUser(string userName);
        bool IsValidUserCredentials(string userName, string password);
        List<string> GetUserRole(string userName);

        bool AddUser(AddUserRequest addUserRequest);
    }

    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserService(ILogger<UserService> logger, ApplicationDbContext context,
            UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public bool IsValidUserCredentials(string userName, string password)
        {
            _logger.LogInformation($"Validating user [{userName}]");
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return _signInManager.PasswordSignInAsync(
                userName,
                password,
                true, lockoutOnFailure:
                true).Result.Succeeded;
        }

        public bool IsAnExistingUser(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public List<string> GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return new List<string>();
            }

            var user = _context.Users.FirstOrDefault(user => user.UserName == userName);
            return _userManager.GetRolesAsync(user).Result.ToList();
        }

        public bool AddUser(AddUserRequest addUserRequest)
        {
            var createUserStatus = _userManager.CreateAsync(new ApplicationUser
            {
                UserName = addUserRequest.UserName,
                Name = addUserRequest.Name
            }, addUserRequest.Password).Result.Succeeded;

            var user = _userManager.FindByNameAsync(addUserRequest.UserName).Result;
            
            if (createUserStatus)
            {
                var userRoles = addUserRequest.RoleList.Select(r => new ApplicationUserRole
                {
                    RoleId = r.ToString(),
                    UserId = user.Id
                }).ToList();
                _context.UserRoles.AddRange(userRoles);
                _context.SaveChanges();
            }
            return createUserStatus;
        }
        
        
    }

    public static class UserRoles
    {
        public const string Admin = nameof(Admin);
        public const string BasicUser = nameof(BasicUser);
    }
}