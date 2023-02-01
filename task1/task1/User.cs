using System;
namespace task1
{
	internal class User
	{
		public string UserName;

		private string _password;


		public string Password {
			set
			{
				if (CheckPassword(value))
				{
					_password = value;
				}
			}
			get => _password;
			}




		static public bool CheckPassword(string password)
		{
			if (string.IsNullOrWhiteSpace(password) || password.Length<8 || password.Length>25)
				return false;

			foreach (var i in password)
			{
                {
                    if (char.IsDigit(i))
                        return true;
                }
            }
			return false;
        }
	}
}

