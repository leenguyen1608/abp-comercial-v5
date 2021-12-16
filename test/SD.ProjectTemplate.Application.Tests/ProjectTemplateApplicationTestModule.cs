using Volo.Abp.Modularity;

namespace SD.ProjectTemplate
{
    [DependsOn(
        typeof(ProjectTemplateApplicationModule),
        typeof(ProjectTemplateDomainTestModule)
        )]
    public class ProjectTemplateApplicationTestModule : AbpModule
    {

    }
}