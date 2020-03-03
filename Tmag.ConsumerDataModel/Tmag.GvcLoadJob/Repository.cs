using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Tmag.Common;

namespace Tmag.GvcLoadJob
{
    public class Repository : Common.Repositories.Repository
    {
        private ILogger _logger;

        public Repository()
        {
        }

        public Repository(IOptions<ConnectionStrings> settings)
        {
            ConnectionString = settings.Value.MainDb;
            DbContext = new Tmag.ConsumerData.Context(ConnectionString);
        }
        public override void ReloadContext()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
                DbContext = new Tmag.ConsumerData.Context(ConnectionString);
            }
        }
    }
}
