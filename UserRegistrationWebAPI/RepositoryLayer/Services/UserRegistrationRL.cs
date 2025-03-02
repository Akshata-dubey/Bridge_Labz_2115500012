using System;
using System.Collections.Generic;
using ModelLayer.DTO;
using NLog;

namespace RepositoryLayer.Services
{
    public class UserRegistrationRL
    {
        private static readonly List<UserDTO> users = new List<UserDTO>();  // ✅ Static list for persistence
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public List<UserDTO> GetUsers()
        {
            try
            {
                _logger.Info("Fetching all registered users.");
                return users;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while fetching users.");
                throw;
            }
        }
        public List<UserDTO> RegistrationRL(UserDTO user)
        {
            try
            {
                if (user == null)
                {
                    _logger.Warn("Attempted to register a null user.");
                    throw new ArgumentNullException(nameof(user), "User object cannot be null.");
                }

                if (users.Exists(u => u.Email == user.Email))
                {
                    _logger.Warn($"User with email {user.Email} already exists.");
                    return users;  // ✅ Prevents duplicate users
                }

                _logger.Info($"Registering user: {user.Email}");
                users.Add(user);

                _logger.Info($"Total registered users: {users.Count}");
                return users;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during user registration.");
                throw;
            }
        }
    }
}
