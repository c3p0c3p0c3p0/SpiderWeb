using System.Threading.Tasks;

namespace SpiderWeb.io.Data
{
    public interface IioDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
