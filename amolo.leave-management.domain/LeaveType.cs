using amolo.leave_management.domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amolo.leave_management.domain
{
	public class LeaveType: BaseDomainEntity
	{
		public string Name { get; set; }
		public int DefaultDays { get; set; }

	}
}
