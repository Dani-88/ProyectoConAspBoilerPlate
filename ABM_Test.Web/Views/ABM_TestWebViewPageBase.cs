using Abp.Web.Mvc.Views;

namespace ABM_Test.Web.Views
{
    public abstract class ABM_TestWebViewPageBase : ABM_TestWebViewPageBase<dynamic>
    {

    }

    public abstract class ABM_TestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABM_TestWebViewPageBase()
        {
            LocalizationSourceName = ABM_TestConsts.LocalizationSourceName;
        }
    }
}