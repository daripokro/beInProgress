// Класс авторизации пользователя
using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
	public class LoginUser
	{
		public LoginUser()
		{
		}
		[ Required( ErrorMessage = "Username is required" ) ]
		public string UserName { get; set; }

		public string Password { get; set; }
    }
}
