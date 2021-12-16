using System;
using System.Collections.Generic;
using System.Text;
using SD.ProjectTemplate.Localization;
using Volo.Abp.Application.Services;

namespace SD.ProjectTemplate
{
    /* Inherit your application services from this class.
     */
    public abstract class ProjectTemplateAppService : ApplicationService
    {
        protected ProjectTemplateAppService()
        {
            LocalizationResource = typeof(ProjectTemplateResource);
        }
    }
}
