using Abp.AutoMapper;
using ABM_Test.Sessions.Dto;

namespace ABM_Test.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}