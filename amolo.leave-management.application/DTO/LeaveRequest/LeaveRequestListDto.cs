using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amolo.leave_management.application.DTO.LeaveRequest
{
	internal class LeaveRequestListDto : Profile
	{
		public LeaveTypeDto LeaveType { get; set; }
		public DateTime DateRequested { get; set; }
		public bool? Approved { get; set; }
	}
}
