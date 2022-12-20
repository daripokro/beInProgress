// Класс регистрации пользователя

using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Model
{
	public class UserRegistration
	{

		[ Required( ErrorMessage = "Username is required" ) ]
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

	}
}

