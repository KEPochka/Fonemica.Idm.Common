using System;

namespace Fonemica.Idm.Common.Models
{
	public class UserModel
	{
		public Guid Id { get; set; }

		public Guid Generation { get; set; }

		public string Login { get; set; }

        public string Password { get; set; }

        public DateTime? Locked { get; set; }
    }
}