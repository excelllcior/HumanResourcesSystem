using System.Configuration;

namespace HumanResourcesSystem.Repositories.Common
{
    public abstract class BaseRepository
    {
        protected string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString.ToString();
    }
}
