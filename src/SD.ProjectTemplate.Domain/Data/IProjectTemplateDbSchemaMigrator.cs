using System.Threading.Tasks;

namespace SD.ProjectTemplate.Data
{
    public interface IProjectTemplateDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
