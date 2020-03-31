using System;
using Fonemica.Idm.Common.Enums;

namespace Fonemica.Idm.Common.Models
{
	public class RoleModel
	{
		public int Id { get; set; }

        public Guid Generation { get; set; }

		public SysType SysType { get; set; }

		public string Name { get; set; }

        public string Code { get; set; }
	}
}