using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amolo.leave_management.application.DTO.LeaveRequest
{
	internal class LeaveRequestDto: Profile
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public LeaveTypeDto LeaveType { get; set; }
		public int LeaveTypeId { get; set; }
		public DateTime DateRequested { get; set; }
		public string RequestComments { get; set; }
		public DateTime DateActioned { get; set; }
		public bool? Approved { get; set; }
		public bool Cancelled { get; set; }
	}
}
