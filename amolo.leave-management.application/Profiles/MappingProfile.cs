using amolo.leave_management.application.DTO;
using amolo.leave_management.application.DTO.LeaveRequest;
using amolo.leave_management.domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amolo.leave_management.application.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
			CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
			CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
			CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
		}
	}
}
