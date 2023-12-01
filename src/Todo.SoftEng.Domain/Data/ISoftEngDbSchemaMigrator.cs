using System.Threading.Tasks;

namespace Todo.SoftEng.Data;

public interface ISoftEngDbSchemaMigrator
{
    Task MigrateAsync();
}
