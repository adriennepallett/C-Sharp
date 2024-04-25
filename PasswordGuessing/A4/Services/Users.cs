using System;
using A4.Models;

namespace A4.Services
{
	public class Users
	{
		List<UserModel> userList = new List<UserModel>();

		public Users()
		{
			userList.Add(new UserModel { ID = 1, Username = "Adrienne", Password = "Password" });
            userList.Add(new UserModel { ID = 1, Username = "Mike", Password = "Blue123" });
            userList.Add(new UserModel { ID = 1, Username = "John", Password = "Green456" });
            userList.Add(new UserModel { ID = 1, Username = "Rachel", Password = "NewYork" });
            userList.Add(new UserModel { ID = 1, Username = "Silas", Password = "ASD" });
        }

		public bool isValid(UserModel user)
		{
			return userList.Any(x => x.Username == user.Username && x.Password == user.Password);
		}
	}
}

