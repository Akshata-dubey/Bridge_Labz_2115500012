using System;
using RepositoryLayer.Services;
using ModelLayer.DTO;
using NLog;

namespace BusinessLayer.Services
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _userRegistrationRL;
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public List<UserDTO> RegistrationBL(UserDTO user)
        {
            try
            {
                _logger.Info($"Checking if user {user.Email} already exists.");
                List<UserDTO> currentUsers = _userRegistrationRL.GetUsers();

                if (currentUsers.Any(data => data.Email == user.Email))
                {
                    _logger.Warn($"User {user.Email} already exists. Registration skipped.");
                    return currentUsers;
                }

                _logger.Info($"User {user.Email} is being registered.");
                return _userRegistrationRL.RegistrationRL(user);
            }
            catch (Exception ex)
            {
                _logger.Error($"Error in Business Layer: {ex.Message}");
                throw;
            }
        }
    }
}
