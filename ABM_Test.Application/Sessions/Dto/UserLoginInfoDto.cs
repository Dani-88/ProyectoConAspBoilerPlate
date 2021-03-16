using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABM_Test.Authorization.Users;
using ABM_Test.Users;

namespace ABM_Test.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
