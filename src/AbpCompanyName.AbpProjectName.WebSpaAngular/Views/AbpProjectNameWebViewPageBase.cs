using Abp.Web.Mvc.Views;

namespace AbpCompanyName.AbpProjectName.WebSpaAngular.Views
{
    public abstract class AbpProjectNameWebViewPageBase : AbpProjectNameWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpProjectNameWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpProjectNameWebViewPageBase()
        {
            LocalizationSourceName = AbpProjectNameConsts.LocalizationSourceName;
        }
    }
}