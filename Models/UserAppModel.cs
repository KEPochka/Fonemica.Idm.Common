using System;
using Fonemica.Idm.Common.Enums;

namespace Fonemica.Idm.Common.Models
{
	public class UserAppModel
	{
		public Guid UserId { get; set; }

		public Guid Generation { get; set; }

		public SysType SysType { get; set; }

        public bool ReadOnly { get; set; }
    }
}