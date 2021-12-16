using SD.ProjectTemplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SD.ProjectTemplate
{
    [DependsOn(
        typeof(ProjectTemplateEntityFrameworkCoreTestModule)
        )]
    public class ProjectTemplateDomainTestModule : AbpModule
    {

    }
}