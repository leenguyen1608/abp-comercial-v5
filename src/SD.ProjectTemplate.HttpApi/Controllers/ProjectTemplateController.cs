using SD.ProjectTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SD.ProjectTemplate.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProjectTemplateController : AbpControllerBase
    {
        protected ProjectTemplateController()
        {
            LocalizationResource = typeof(ProjectTemplateResource);
        }
    }
}