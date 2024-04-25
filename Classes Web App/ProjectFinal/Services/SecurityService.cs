using System;
using ProjectFinal.Models;

namespace ProjectFinal.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { ID = 1, Username = "Adrienne", Password = "password" });
            knownUsers.Add(new UserModel { ID = 2, Username = "Brogan", Password = "password" });
            knownUsers.Add(new UserModel { ID = 3, Username = "a", Password = "p" });
        }

        public bool isValid(UserModel user)
        {
            return knownUsers.Any(x => x.Username == user.Username && x.Password == user.Password);
            
        }
    }
}

