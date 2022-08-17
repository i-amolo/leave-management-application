using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amolo.leave_management.domain;

namespace amolo.leave_management.application.Persistence.Contracts
{
	public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
	{
	}
}
